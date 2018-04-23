using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace M1M3RestrictionTest
{
    class ILC
    {
        private SerialPort port;
        private byte[] broadcastBuffer;
        private byte[] masterRequestBuffer;
        private byte[] slaveRequestBuffer;
        private byte[] responseBuffer;
        private Random rnd = new Random();
        private Stopwatch sw = new Stopwatch();

        public ILC(string portName)
        {
            port = new SerialPort(portName, 921600);
            port.ReadTimeout = 1000;
            broadcastBuffer = new byte[246];
            broadcastBuffer[0] = 249;
            broadcastBuffer[1] = 75;
            masterRequestBuffer = new byte[4];
            masterRequestBuffer[0] = 1;
            masterRequestBuffer[1] = 76;
            SetCRC(masterRequestBuffer);
            slaveRequestBuffer = new byte[4];
            slaveRequestBuffer[0] = 2;
            slaveRequestBuffer[1] = 76;
            SetCRC(slaveRequestBuffer);
            responseBuffer = new byte[9];
        }

        public void Open()
        {
            if (!port.IsOpen)
            {
                port.Open();
                byte[] buffer = new byte[port.BytesToRead];
                port.Read(buffer, 0, buffer.Length);
                Reset(1);
                StateChange(1, 1);
                StateChange(1, 2);
                Reset(2);
                StateChange(2, 1);
                StateChange(2, 2);
            }
        }

        public void Close()
        {
            if (port.IsOpen)
            {
                port.Close();
            }
        }
        
        public Tuple<float, float> Update(double m, double s)
        {
            if (port.IsOpen)
            {
                try
                {
                    int mOutput = (int)(m * 1000.0);
                    int sOutput = (int)(s * 1000.0);
                    broadcastBuffer[4] = (byte)(mOutput >> 16);
                    broadcastBuffer[5] = (byte)(mOutput >> 8);
                    broadcastBuffer[6] = (byte)mOutput;
                    broadcastBuffer[7] = (byte)(sOutput >> 16);
                    broadcastBuffer[8] = (byte)(sOutput >> 8);
                    broadcastBuffer[9] = (byte)sOutput;
                    SetCRC(broadcastBuffer);
                    port.Write(broadcastBuffer, 0, broadcastBuffer.Length);
                    Thread.Sleep(10);
                    port.Write(masterRequestBuffer, 0, masterRequestBuffer.Length);
                    Thread.Sleep(10);
                    port.Read(responseBuffer, 0, 9);
                    var master = ToFloat(responseBuffer);
                    port.Write(slaveRequestBuffer, 0, slaveRequestBuffer.Length);
                    Thread.Sleep(10);
                    port.Read(responseBuffer, 0, 9);
                    var slave = ToFloat(responseBuffer);
                    return new Tuple<float, float>(master, slave);
                }
                catch (TimeoutException)
                {
                    return new Tuple<float, float>(9999, 9999);
                }
            }
            return new Tuple<float, float>((float)(rnd.NextDouble() * 8000.0 - 4000.0), (float)(rnd.NextDouble() * 8000.0 - 4000.0));
        }

        private void Reset(byte addr)
        {
            byte[] buffer = new byte[4];
            buffer[0] = addr;
            buffer[1] = 107;
            SetCRC(buffer);
            port.Write(buffer, 0, buffer.Length);
            Thread.Sleep(800);
            buffer = new byte[4];
            port.Read(buffer, 0, 4);
            //MessageBox.Show("Reset: " + buffer[1].ToString());
        }

        private void StateChange(byte addr, byte code)
        {
            byte[] buffer = new byte[6];
            buffer[0] = addr;
            buffer[1] = 65;
            buffer[2] = 0;
            buffer[3] = code;
            SetCRC(buffer);
            port.Write(buffer, 0, buffer.Length);
            Thread.Sleep(250);
            buffer = new byte[6];
            port.Read(buffer, 0, 6);
            //MessageBox.Show("State: " + buffer[1].ToString());
        }

        private float ToFloat(byte[] buffer)
        {
            byte[] tmp = new byte[4];
            tmp[0] = buffer[6];
            tmp[1] = buffer[5];
            tmp[2] = buffer[4];
            tmp[3] = buffer[3];
            return BitConverter.ToSingle(tmp, 0);
        }

        public void SetCRC(byte[] buffer)
        {
            ushort crc = 0xFFFF;
            for (int i = 0; i < buffer.Length - 2; i++)
            {
                crc = (ushort)(crc ^ ((ushort)buffer[i]));
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc = (ushort)(crc >> 1);
                        crc = (ushort)(crc ^ 0xA001);
                    }
                    else
                    {
                        crc = (ushort)(crc >> 1);
                    }
                }
            }
            buffer[buffer.Length - 2] = (byte)crc;
            buffer[buffer.Length - 1] = (byte)(crc >> 8);
        }

        private void Sleep(double ms)
        {
            sw.Reset();
            sw.Start();
            while(sw.Elapsed.TotalMilliseconds < ms)
            {
                Thread.Sleep(0);
            }
            sw.Stop();
        }
    }
}