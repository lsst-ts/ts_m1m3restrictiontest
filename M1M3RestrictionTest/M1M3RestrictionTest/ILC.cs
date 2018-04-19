using System;
using System.IO.Ports;

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

        public ILC(string portName)
        {
            port = new SerialPort(portName, 921600);
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
                port.Write(masterRequestBuffer, 0, masterRequestBuffer.Length);
                port.Write(slaveRequestBuffer, 0, slaveRequestBuffer.Length);
                port.Read(responseBuffer, 0, 9);
                var master = BitConverter.ToSingle(responseBuffer, 3);
                port.Read(responseBuffer, 0, 9);
                var slave = BitConverter.ToSingle(responseBuffer, 3);
                return new Tuple<float, float>(master, slave);
            }
            return new Tuple<float, float>((float)(rnd.NextDouble() * 8000.0 - 4000.0), (float)(rnd.NextDouble() * 8000.0 - 4000.0));
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
    }
}