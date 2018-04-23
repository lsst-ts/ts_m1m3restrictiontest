namespace M1M3RestrictionTest
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDisableRestriction = new System.Windows.Forms.Button();
            this.btnEnableRestriction = new System.Windows.Forms.Button();
            this.btnReadDisplacement = new System.Windows.Forms.Button();
            this.txtDisplacement = new System.Windows.Forms.TextBox();
            this.txtRestrictorState = new System.Windows.Forms.TextBox();
            this.btnSetILCs = new System.Windows.Forms.Button();
            this.nudMaster = new System.Windows.Forms.NumericUpDown();
            this.nudSlave = new System.Windows.Forms.NumericUpDown();
            this.txtMaster = new System.Windows.Forms.TextBox();
            this.txtSlave = new System.Windows.Forms.TextBox();
            this.lblmm = new System.Windows.Forms.Label();
            this.lbln = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpMain = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSlaveForceValue = new System.Windows.Forms.Label();
            this.lblMasterForceValue = new System.Windows.Forms.Label();
            this.lblDisplacementValue = new System.Windows.Forms.Label();
            this.btnRunTest = new System.Windows.Forms.Button();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudMasterForce = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSlaveForce = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudHoldTime = new System.Windows.Forms.NumericUpDown();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRestrictorStateValue = new System.Windows.Forms.Label();
            this.tbpDebug = new System.Windows.Forms.TabPage();
            this.bgwTest = new System.ComponentModel.BackgroundWorker();
            this.sfdFiles = new System.Windows.Forms.SaveFileDialog();
            this.btnReadPressure = new System.Windows.Forms.Button();
            this.txtAxialPush1 = new System.Windows.Forms.TextBox();
            this.txtAxialPull1 = new System.Windows.Forms.TextBox();
            this.txtAxialPush2 = new System.Windows.Forms.TextBox();
            this.txtAxialPull2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlave)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.tbpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterForce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlaveForce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldTime)).BeginInit();
            this.tbpDebug.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisableRestriction
            // 
            this.btnDisableRestriction.Location = new System.Drawing.Point(9, 9);
            this.btnDisableRestriction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisableRestriction.Name = "btnDisableRestriction";
            this.btnDisableRestriction.Size = new System.Drawing.Size(192, 35);
            this.btnDisableRestriction.TabIndex = 0;
            this.btnDisableRestriction.Text = "Disable Restriction";
            this.btnDisableRestriction.UseVisualStyleBackColor = true;
            this.btnDisableRestriction.Click += new System.EventHandler(this.btnDisableRestriction_Click);
            // 
            // btnEnableRestriction
            // 
            this.btnEnableRestriction.Location = new System.Drawing.Point(9, 54);
            this.btnEnableRestriction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnableRestriction.Name = "btnEnableRestriction";
            this.btnEnableRestriction.Size = new System.Drawing.Size(192, 35);
            this.btnEnableRestriction.TabIndex = 1;
            this.btnEnableRestriction.Text = "Enable Restriction";
            this.btnEnableRestriction.UseVisualStyleBackColor = true;
            this.btnEnableRestriction.Click += new System.EventHandler(this.btnEnableRestriction_Click);
            // 
            // btnReadDisplacement
            // 
            this.btnReadDisplacement.Location = new System.Drawing.Point(9, 128);
            this.btnReadDisplacement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReadDisplacement.Name = "btnReadDisplacement";
            this.btnReadDisplacement.Size = new System.Drawing.Size(192, 35);
            this.btnReadDisplacement.TabIndex = 3;
            this.btnReadDisplacement.Text = "Read Displacement";
            this.btnReadDisplacement.UseVisualStyleBackColor = true;
            this.btnReadDisplacement.Click += new System.EventHandler(this.btnReadDisplacement_Click);
            // 
            // txtDisplacement
            // 
            this.txtDisplacement.Location = new System.Drawing.Point(210, 131);
            this.txtDisplacement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisplacement.Name = "txtDisplacement";
            this.txtDisplacement.ReadOnly = true;
            this.txtDisplacement.Size = new System.Drawing.Size(148, 26);
            this.txtDisplacement.TabIndex = 4;
            this.txtDisplacement.Text = "0.000";
            this.txtDisplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRestrictorState
            // 
            this.txtRestrictorState.Location = new System.Drawing.Point(210, 37);
            this.txtRestrictorState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRestrictorState.Name = "txtRestrictorState";
            this.txtRestrictorState.ReadOnly = true;
            this.txtRestrictorState.Size = new System.Drawing.Size(148, 26);
            this.txtRestrictorState.TabIndex = 2;
            this.txtRestrictorState.Text = "Disabled";
            this.txtRestrictorState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSetILCs
            // 
            this.btnSetILCs.Location = new System.Drawing.Point(9, 225);
            this.btnSetILCs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSetILCs.Name = "btnSetILCs";
            this.btnSetILCs.Size = new System.Drawing.Size(192, 35);
            this.btnSetILCs.TabIndex = 6;
            this.btnSetILCs.Text = "Set ILCs";
            this.btnSetILCs.UseVisualStyleBackColor = true;
            this.btnSetILCs.Click += new System.EventHandler(this.btnSetILCs_Click);
            // 
            // nudMaster
            // 
            this.nudMaster.DecimalPlaces = 3;
            this.nudMaster.Location = new System.Drawing.Point(219, 208);
            this.nudMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMaster.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudMaster.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudMaster.Name = "nudMaster";
            this.nudMaster.Size = new System.Drawing.Size(171, 26);
            this.nudMaster.TabIndex = 7;
            this.nudMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaster.ThousandsSeparator = true;
            // 
            // nudSlave
            // 
            this.nudSlave.DecimalPlaces = 3;
            this.nudSlave.Location = new System.Drawing.Point(436, 208);
            this.nudSlave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSlave.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSlave.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.nudSlave.Name = "nudSlave";
            this.nudSlave.Size = new System.Drawing.Size(171, 26);
            this.nudSlave.TabIndex = 8;
            this.nudSlave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSlave.ThousandsSeparator = true;
            // 
            // txtMaster
            // 
            this.txtMaster.Location = new System.Drawing.Point(219, 248);
            this.txtMaster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaster.Name = "txtMaster";
            this.txtMaster.ReadOnly = true;
            this.txtMaster.Size = new System.Drawing.Size(148, 26);
            this.txtMaster.TabIndex = 9;
            this.txtMaster.Text = "0.000";
            this.txtMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSlave
            // 
            this.txtSlave.Location = new System.Drawing.Point(436, 248);
            this.txtSlave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSlave.Name = "txtSlave";
            this.txtSlave.ReadOnly = true;
            this.txtSlave.Size = new System.Drawing.Size(148, 26);
            this.txtSlave.TabIndex = 10;
            this.txtSlave.Text = "0.000";
            this.txtSlave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblmm
            // 
            this.lblmm.AutoSize = true;
            this.lblmm.Location = new System.Drawing.Point(369, 135);
            this.lblmm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmm.Name = "lblmm";
            this.lblmm.Size = new System.Drawing.Size(35, 20);
            this.lblmm.TabIndex = 5;
            this.lblmm.Text = "mm";
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(616, 211);
            this.lbln.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(20, 20);
            this.lbln.TabIndex = 7;
            this.lbln.Text = "N";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "N";
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpMain);
            this.tbcMain.Controls.Add(this.tbpDebug);
            this.tbcMain.Location = new System.Drawing.Point(18, 18);
            this.tbcMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(933, 840);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpMain
            // 
            this.tbpMain.Controls.Add(this.tableLayoutPanel1);
            this.tbpMain.Location = new System.Drawing.Point(4, 29);
            this.tbpMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpMain.Size = new System.Drawing.Size(925, 807);
            this.tbpMain.TabIndex = 1;
            this.tbpMain.Text = "Main";
            this.tbpMain.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.04636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.95364F));
            this.tableLayoutPanel1.Controls.Add(this.lblSlaveForceValue, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblMasterForceValue, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblDisplacementValue, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnRunTest, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtOperator, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudMasterForce, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudSlaveForce, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudHoldTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNotes, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblRestrictorStateValue, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 786);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblSlaveForceValue
            // 
            this.lblSlaveForceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSlaveForceValue.AutoSize = true;
            this.lblSlaveForceValue.Location = new System.Drawing.Point(166, 742);
            this.lblSlaveForceValue.Name = "lblSlaveForceValue";
            this.lblSlaveForceValue.Size = new System.Drawing.Size(14, 20);
            this.lblSlaveForceValue.TabIndex = 18;
            this.lblSlaveForceValue.Text = "-";
            // 
            // lblMasterForceValue
            // 
            this.lblMasterForceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMasterForceValue.AutoSize = true;
            this.lblMasterForceValue.Location = new System.Drawing.Point(166, 680);
            this.lblMasterForceValue.Name = "lblMasterForceValue";
            this.lblMasterForceValue.Size = new System.Drawing.Size(14, 20);
            this.lblMasterForceValue.TabIndex = 17;
            this.lblMasterForceValue.Text = "-";
            // 
            // lblDisplacementValue
            // 
            this.lblDisplacementValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDisplacementValue.AutoSize = true;
            this.lblDisplacementValue.Location = new System.Drawing.Point(166, 618);
            this.lblDisplacementValue.Name = "lblDisplacementValue";
            this.lblDisplacementValue.Size = new System.Drawing.Size(14, 20);
            this.lblDisplacementValue.TabIndex = 16;
            this.lblDisplacementValue.Text = "-";
            // 
            // btnRunTest
            // 
            this.btnRunTest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRunTest.Location = new System.Drawing.Point(167, 486);
            this.btnRunTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRunTest.Name = "btnRunTest";
            this.btnRunTest.Size = new System.Drawing.Size(192, 35);
            this.btnRunTest.TabIndex = 5;
            this.btnRunTest.Text = "Run Test";
            this.btnRunTest.UseVisualStyleBackColor = true;
            this.btnRunTest.Click += new System.EventHandler(this.btnRunTest_Click);
            // 
            // txtOperator
            // 
            this.txtOperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOperator.Location = new System.Drawing.Point(167, 18);
            this.txtOperator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(320, 26);
            this.txtOperator.TabIndex = 0;
            this.txtOperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Notes";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Operator";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Master Force (N)";
            // 
            // nudMasterForce
            // 
            this.nudMasterForce.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudMasterForce.DecimalPlaces = 3;
            this.nudMasterForce.Location = new System.Drawing.Point(167, 80);
            this.nudMasterForce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMasterForce.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudMasterForce.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            -2147483648});
            this.nudMasterForce.Name = "nudMasterForce";
            this.nudMasterForce.Size = new System.Drawing.Size(180, 26);
            this.nudMasterForce.TabIndex = 1;
            this.nudMasterForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Slave Force (N)";
            // 
            // nudSlaveForce
            // 
            this.nudSlaveForce.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudSlaveForce.DecimalPlaces = 3;
            this.nudSlaveForce.Location = new System.Drawing.Point(167, 142);
            this.nudSlaveForce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSlaveForce.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudSlaveForce.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            -2147483648});
            this.nudSlaveForce.Name = "nudSlaveForce";
            this.nudSlaveForce.Size = new System.Drawing.Size(180, 26);
            this.nudSlaveForce.TabIndex = 2;
            this.nudSlaveForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hold Time (s)";
            // 
            // nudHoldTime
            // 
            this.nudHoldTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudHoldTime.DecimalPlaces = 3;
            this.nudHoldTime.Location = new System.Drawing.Point(167, 204);
            this.nudHoldTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHoldTime.Name = "nudHoldTime";
            this.nudHoldTime.Size = new System.Drawing.Size(180, 26);
            this.nudHoldTime.TabIndex = 3;
            this.nudHoldTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(167, 253);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(522, 213);
            this.txtNotes.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Restrictor";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Displacement (mm)";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 680);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Master Force (N)";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 742);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Slave Force (N)";
            // 
            // lblRestrictorStateValue
            // 
            this.lblRestrictorStateValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRestrictorStateValue.AutoSize = true;
            this.lblRestrictorStateValue.Location = new System.Drawing.Point(166, 556);
            this.lblRestrictorStateValue.Name = "lblRestrictorStateValue";
            this.lblRestrictorStateValue.Size = new System.Drawing.Size(14, 20);
            this.lblRestrictorStateValue.TabIndex = 14;
            this.lblRestrictorStateValue.Text = "-";
            // 
            // tbpDebug
            // 
            this.tbpDebug.Controls.Add(this.btnDisableRestriction);
            this.tbpDebug.Controls.Add(this.label1);
            this.tbpDebug.Controls.Add(this.btnEnableRestriction);
            this.tbpDebug.Controls.Add(this.label3);
            this.tbpDebug.Controls.Add(this.txtRestrictorState);
            this.tbpDebug.Controls.Add(this.label2);
            this.tbpDebug.Controls.Add(this.btnReadDisplacement);
            this.tbpDebug.Controls.Add(this.lbln);
            this.tbpDebug.Controls.Add(this.txtDisplacement);
            this.tbpDebug.Controls.Add(this.nudSlave);
            this.tbpDebug.Controls.Add(this.lblmm);
            this.tbpDebug.Controls.Add(this.nudMaster);
            this.tbpDebug.Controls.Add(this.btnReadPressure);
            this.tbpDebug.Controls.Add(this.btnSetILCs);
            this.tbpDebug.Controls.Add(this.txtAxialPull2);
            this.tbpDebug.Controls.Add(this.txtAxialPull1);
            this.tbpDebug.Controls.Add(this.txtSlave);
            this.tbpDebug.Controls.Add(this.txtAxialPush2);
            this.tbpDebug.Controls.Add(this.txtAxialPush1);
            this.tbpDebug.Controls.Add(this.txtMaster);
            this.tbpDebug.Location = new System.Drawing.Point(4, 29);
            this.tbpDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpDebug.Name = "tbpDebug";
            this.tbpDebug.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbpDebug.Size = new System.Drawing.Size(925, 807);
            this.tbpDebug.TabIndex = 0;
            this.tbpDebug.Text = "Debug";
            this.tbpDebug.UseVisualStyleBackColor = true;
            // 
            // bgwTest
            // 
            this.bgwTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTest_DoWork);
            this.bgwTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTest_RunWorkerCompleted);
            // 
            // sfdFiles
            // 
            this.sfdFiles.Filter = "CSV Files (*.csv)|*.csv";
            this.sfdFiles.Title = "Save Log File";
            // 
            // btnReadPressure
            // 
            this.btnReadPressure.Location = new System.Drawing.Point(9, 381);
            this.btnReadPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReadPressure.Name = "btnReadPressure";
            this.btnReadPressure.Size = new System.Drawing.Size(192, 35);
            this.btnReadPressure.TabIndex = 6;
            this.btnReadPressure.Text = "Read Pressure";
            this.btnReadPressure.UseVisualStyleBackColor = true;
            this.btnReadPressure.Click += new System.EventHandler(this.btnReadPressure_Click);
            // 
            // txtAxialPush1
            // 
            this.txtAxialPush1.Location = new System.Drawing.Point(219, 385);
            this.txtAxialPush1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAxialPush1.Name = "txtAxialPush1";
            this.txtAxialPush1.ReadOnly = true;
            this.txtAxialPush1.Size = new System.Drawing.Size(148, 26);
            this.txtAxialPush1.TabIndex = 9;
            this.txtAxialPush1.Text = "0.000";
            this.txtAxialPush1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAxialPull1
            // 
            this.txtAxialPull1.Location = new System.Drawing.Point(436, 385);
            this.txtAxialPull1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAxialPull1.Name = "txtAxialPull1";
            this.txtAxialPull1.ReadOnly = true;
            this.txtAxialPull1.Size = new System.Drawing.Size(148, 26);
            this.txtAxialPull1.TabIndex = 10;
            this.txtAxialPull1.Text = "0.000";
            this.txtAxialPull1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAxialPush2
            // 
            this.txtAxialPush2.Location = new System.Drawing.Point(219, 421);
            this.txtAxialPush2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAxialPush2.Name = "txtAxialPush2";
            this.txtAxialPush2.ReadOnly = true;
            this.txtAxialPush2.Size = new System.Drawing.Size(148, 26);
            this.txtAxialPush2.TabIndex = 9;
            this.txtAxialPush2.Text = "0.000";
            this.txtAxialPush2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAxialPull2
            // 
            this.txtAxialPull2.Location = new System.Drawing.Point(436, 421);
            this.txtAxialPull2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAxialPull2.Name = "txtAxialPull2";
            this.txtAxialPull2.ReadOnly = true;
            this.txtAxialPull2.Size = new System.Drawing.Size(148, 26);
            this.txtAxialPull2.TabIndex = 10;
            this.txtAxialPull2.Text = "0.000";
            this.txtAxialPull2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 871);
            this.Controls.Add(this.tbcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M1M3 Restriction Test Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlave)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.tbpMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasterForce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlaveForce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoldTime)).EndInit();
            this.tbpDebug.ResumeLayout(false);
            this.tbpDebug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisableRestriction;
        private System.Windows.Forms.Button btnEnableRestriction;
        private System.Windows.Forms.Button btnReadDisplacement;
        private System.Windows.Forms.TextBox txtDisplacement;
        private System.Windows.Forms.TextBox txtRestrictorState;
        private System.Windows.Forms.Button btnSetILCs;
        private System.Windows.Forms.NumericUpDown nudMaster;
        private System.Windows.Forms.NumericUpDown nudSlave;
        private System.Windows.Forms.TextBox txtMaster;
        private System.Windows.Forms.TextBox txtSlave;
        private System.Windows.Forms.Label lblmm;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSlaveForceValue;
        private System.Windows.Forms.Label lblMasterForceValue;
        private System.Windows.Forms.Label lblDisplacementValue;
        private System.Windows.Forms.Button btnRunTest;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudMasterForce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudSlaveForce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudHoldTime;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRestrictorStateValue;
        private System.Windows.Forms.TabPage tbpDebug;
        private System.ComponentModel.BackgroundWorker bgwTest;
        private System.Windows.Forms.SaveFileDialog sfdFiles;
        private System.Windows.Forms.Button btnReadPressure;
        private System.Windows.Forms.TextBox txtAxialPull1;
        private System.Windows.Forms.TextBox txtAxialPush1;
        private System.Windows.Forms.TextBox txtAxialPull2;
        private System.Windows.Forms.TextBox txtAxialPush2;
    }
}

