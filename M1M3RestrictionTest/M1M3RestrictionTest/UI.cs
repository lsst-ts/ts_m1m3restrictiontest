using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace M1M3RestrictionTest
{
    public partial class UI : Form
    {
        private Arduino arduino;
        private Displacement displacement;
        private ILC ilc;
        private double zero = 0;
        private bool lastSupplyState = false;
        private double lastDisplacement = 0;
        private double lastMasterControl = 0;
        private double lastSlaveControl = 0;
        private double lastMasterSensor = 0;
        private double lastSlaveSensor = 0;
        private List<Sample> samples;

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            arduino = new Arduino(Properties.Settings.Default.ArduinoCOM);
            displacement = new Displacement(Properties.Settings.Default.DisplacementCOM);
            ilc = new ILC(Properties.Settings.Default.ILCCOM);
            if (!Properties.Settings.Default.Simulate)
            {
                arduino.Open();
                displacement.Open();
                ilc.Open();
            }
            btnDisableRestriction_Click(sender, e);
            btnReadDisplacement_Click(sender, e);
            btnSetILCs_Click(sender, e);
        }

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {
            arduino.TurnOff();
            arduino.Close();
            displacement.Close();
            ilc.Close();
        }

        private void btnDisableRestriction_Click(object sender, EventArgs e) { TurnOn(); }
        private void btnEnableRestriction_Click(object sender, EventArgs e) { TurnOff(); }
        private void btnReadDisplacement_Click(object sender, EventArgs e) { ReadDisplacement(); }
        private void btnSetILCs_Click(object sender, EventArgs e) { SetILC((double)nudMaster.Value, (double)nudSlave.Value); }

        private void btnRunTest_Click(object sender, EventArgs e)
        {
            txtOperator.Enabled = false;
            nudMasterForce.Enabled = false;
            nudSlaveForce.Enabled = false;
            nudHoldTime.Enabled = false;
            txtNotes.Enabled = false;
            btnRunTest.Enabled = false;
            samples = new List<Sample>(1200);
            bgwTest.RunWorkerAsync();
        }

        private void bgwTest_DoWork(object sender, DoWorkEventArgs e)
        {
            double m = 0, s = 0, h = 0;
            InvokeIfRequired(() =>
            {
                m = (double)nudMasterForce.Value;
                s = (double)nudSlaveForce.Value;
                h = (double)nudHoldTime.Value;
            });
            TurnOn();
            SetILC(0, s);
            MessageBox.Show("Please position the block spacer. Once spacer is positioned click OK.", "Operation Action Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ReadDisplacement(true);
            SetILC(m, m + 100);
            AddSample();
            var iterations = h / 0.05;
            var i = 0;
            Stopwatch sw = new Stopwatch();
            
            for (i = 0; i < iterations; ++i)
            {
                sw.Restart();
                SetILC(m, m + 100);
                ReadDisplacement();
                AddSample();
                sw.Stop();
                int sleep = 50 - (int)sw.ElapsedMilliseconds;
                if (sleep < 0)
                    sleep = 0;
                Thread.Sleep(sleep);
            }
            i = 0;
            TurnOff();
            while (Math.Abs(lastDisplacement) < 28 && i < 1200)
            {
                sw.Restart();
                i++;
                SetILC(m, 0);
                ReadDisplacement();
                AddSample();
                sw.Stop();
                int sleep = 50 - (int)sw.ElapsedMilliseconds;
                if (sleep < 0)
                    sleep = 0;
                Thread.Sleep(sleep);
            }
        }

        private void bgwTest_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InvokeIfRequired(() =>
            {
                txtOperator.Enabled = true;
                nudMasterForce.Enabled = true;
                nudSlaveForce.Enabled = true;
                nudHoldTime.Enabled = true;
                txtNotes.Enabled = true;
                btnRunTest.Enabled = true;
            });
            if (sfdFiles.ShowDialog() == DialogResult.OK)
            {
                var file = sfdFiles.FileName;
                using (var writer = new StreamWriter(file))
                {
                    writer.WriteLine("Operation: " + txtOperator.Text);
                    writer.WriteLine("Master Force (N): " + nudMasterForce.Value.ToString());
                    writer.WriteLine("Slave Force (N): " + nudSlaveForce.Value.ToString());
                    writer.WriteLine("Hold Time (s): " + nudHoldTime.Value.ToString());
                    writer.WriteLine("Notes: " + txtNotes.Text);
                    writer.WriteLine("Timestamp,Restricting(T/F),Displacement(mm),MasterControl(N),SlaveControl(N),MasterSensor(N),SlaveSensor(N)");
                    foreach (var sample in samples)
                    {
                        writer.WriteLine(sample.ToString());
                    }
                }
            }
        }

        private void TurnOn()
        {
            arduino.TurnOn();
            lastSupplyState = false;
            InvokeIfRequired(() =>
            {
                txtRestrictorState.Text = "Disabled";
                lblRestrictorStateValue.Text = "Disabled";
            });
        }

        private void TurnOff()
        {
            arduino.TurnOff();
            lastSupplyState = true;
            InvokeIfRequired(() =>
            {
                txtRestrictorState.Text = "Enabled";
                lblRestrictorStateValue.Text = "Enabled";
            });
        }

        private void ReadDisplacement(bool setZero = false)
        {
            var value = displacement.Read();
            if (setZero)
            {
                zero = value;
            }
            value -= zero;
            lastDisplacement = value;
            txtDisplacement.Text = value.ToString("0.000");
            lblDisplacementValue.Text = value.ToString("0.000");
        }

        private void SetILC(double master, double slave)
        {
            var values = ilc.Update(master, slave);
            lastMasterControl = master;
            lastSlaveControl = slave;
            lastMasterSensor = values.Item1;
            lastSlaveSensor = values.Item2;
            InvokeIfRequired(() =>
            {
                txtMaster.Text = values.Item1.ToString("0.000");
                txtSlave.Text = values.Item2.ToString("0.000");
                lblMasterForceValue.Text = values.Item1.ToString("0.000");
                lblSlaveForceValue.Text = values.Item2.ToString("0.000");
            });
        }

        private void AddSample()
        {
            samples.Add(new Sample
            {
                Timestamp = DateTime.Now,
                RestrictorValve = lastSupplyState,
                Displacement = lastDisplacement,
                MasterControl = lastMasterControl,
                SlaveControl = lastSlaveControl,
                MasterSensor = lastMasterSensor,
                SlaveSensor = lastSlaveSensor
            });
        }

        private void InvokeIfRequired(Action x)
        {
            if (InvokeRequired)
            {
                Invoke(x);
            }
            x();
        }
    }
}