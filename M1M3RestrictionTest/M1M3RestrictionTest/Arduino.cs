using System.IO.Ports;

namespace M1M3RestrictionTest
{
    class Arduino
    {
        private SerialPort port;
        public Arduino(string portName)
        {
            this.port = new SerialPort(portName, 9600);
            
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

        public void TurnOn()
        {
            if (port.IsOpen)
            {
                port.Write("1");
            }
        }

        public void TurnOff()
        {
            if (port.IsOpen)
            {
                port.Write("0");
            }
        }
    }
}