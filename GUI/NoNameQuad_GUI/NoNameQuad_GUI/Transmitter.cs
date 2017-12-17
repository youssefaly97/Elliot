using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
     class Transmitter
    {
        protected SerialPort serialPort;
        protected string portName;
        protected int baud;


        
        public Transmitter(string portName, int baud)
        {
            try
            {
                serialPort = new SerialPort(portName, baud);
                this.portName = portName;
                this.baud = baud;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public override string ToString()
        {
            return portName + " " + baud.ToString();

        }

    }
}
