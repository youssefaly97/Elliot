using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
    class String_Transmitter : Transmitter
    {

        public String_Transmitter(string portName, int baud) : base(portName, baud)
        {

        }

        public void SendString(string x)
        {
            MessageBox.Show("String Send");
            if (!serialPort.IsOpen)
            {
                try
                {

                    serialPort.Open();
                    serialPort.Write(x);
                    serialPort.Close();

                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }

        }


    }
}
