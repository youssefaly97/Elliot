using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
    class Byte_Transmitter : Transmitter
    {
        public Byte_Transmitter(string portName, int baud) : base(portName, baud)
        {

        }

        public void SendByte(byte x)
        {
            if (!serialPort.IsOpen)
            {
                try
                {

                    byte[] buffer = new byte[1];
                    buffer[0] = x;
                    serialPort.Open();
                    serialPort.Write(buffer, 0, 1);
                    serialPort.Close();

                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }

        }

        public void SendByteArray(byte[] x)
        {
            MessageBox.Show("INOS");
            if (!serialPort.IsOpen)
            {
                try
                {

                    serialPort.Open();
                    serialPort.Write(x, 0, x.Count());
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
