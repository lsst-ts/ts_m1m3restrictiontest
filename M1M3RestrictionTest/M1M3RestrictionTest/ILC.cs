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
                Read(buffer, buffer.Length);
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
                    Read(responseBuffer, 9);
                    var master = ToFloat(responseBuffer);
                    port.Write(slaveRequestBuffer, 0, slaveRequestBuffer.Length);
                    Thread.Sleep(10);
                    Read(responseBuffer, 9);
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

        public float SetForce(byte addr, float setpoint)
        {
            if (port.IsOpen)
            {
                try
                {

                    int output = (int)(setpoint * 1000.0);
                    byte[] buffer = new byte[8];
                    buffer[0] = addr;
                    buffer[1] = 75;
                    buffer[2] = 0;
                    buffer[3] = (byte)(output >> 16);
                    buffer[4] = (byte)(output >> 8); 
                    buffer[5] = (byte)output;
                    SetCRC(buffer);
                    port.Write(buffer, 0, buffer.Length);
                    Thread.Sleep(10);
                    byte[] response = new byte[9];
                    Read(response, 9);
                    var value = ToFloat(response);
                    return value;
                }
                catch (TimeoutException)
                {
                    return 9999;
                }
            }
            return (float)(rnd.NextDouble() * 8000.0 - 4000.0);
        }

        private void Read(byte[] buffer, int length)
        {
            int toRead = length;
            int read = 0;
            while(read != length)
            {
                int got = port.Read(buffer, read, toRead);
                read += got;
                toRead -= got;
            }
        }

        public Tuple<float, float> ReadPressure(byte addr)
        {
            if (port.IsOpen)
            {
                try
                {
                    byte[] buffer = new byte[4];
                    buffer[0] = addr;
                    buffer[1] = 119;
                    SetCRC(buffer);
                    port.Write(buffer, 0, buffer.Length);
                    Thread.Sleep(10);
                    buffer = new byte[20];
                    Read(buffer, 20);
                    byte[] tmp = new byte[4];
                    tmp[0] = buffer[5];
                    tmp[1] = buffer[4];
                    tmp[2] = buffer[3];
                    tmp[3] = buffer[2];
                    float p1 = BitConverter.ToSingle(tmp, 0);
                    tmp[0] = buffer[9];
                    tmp[1] = buffer[8];
                    tmp[2] = buffer[7];
                    tmp[3] = buffer[6];
                    float p2 = BitConverter.ToSingle(tmp, 0);
                    tmp[0] = buffer[13];
                    tmp[1] = buffer[12];
                    tmp[2] = buffer[11];
                    tmp[3] = buffer[10];
                    float p3 = BitConverter.ToSingle(tmp, 0);
                    tmp[0] = buffer[17];
                    tmp[1] = buffer[16];
                    tmp[2] = buffer[15];
                    tmp[3] = buffer[14];
                    float p4 = BitConverter.ToSingle(tmp, 0);
                    return new Tuple<float, float>(p1, p2);
                }
                catch (TimeoutException)
                {
                    return new Tuple<float, float>(9999, 9999);
                }

            }
            return new Tuple<float, float>((float)(rnd.NextDouble() * 120.0 - 60.0), (float)(rnd.NextDouble() * 120.0 - 60.0));
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
            Read(buffer, 4);
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
            Read(buffer, 6);
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