using System;
using System.IO.Ports;

namespace M1M3RestrictionTest
{
    class Displacement
    {
        private SerialPort port;
        private Random rnd = new Random();

        public Displacement(string portName)
        {
            port = new SerialPort(portName, 38400);
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

        public double Read()
        {
            if (port.IsOpen)
            {
                port.Write("M0\r\n");
                var line = port.ReadLine();
                var startIndex = line.IndexOf(',') + 1;
                var stopIndex = line.IndexOf('\r') - startIndex;
                return double.Parse(line.Substring(startIndex, stopIndex - startIndex));
            }
            return (rnd.NextDouble() * 60.0) - 30.0;
        }
    }
}