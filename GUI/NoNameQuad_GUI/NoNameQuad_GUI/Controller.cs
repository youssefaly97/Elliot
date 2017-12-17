using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
    class Controller
    {
        Byte_Transmitter byteTrans = null;
        String_Transmitter stringTrans = null;
        //Transmitter myTransmitter = null;
        char mode;

        public Controller(char mode)
        {
            this.mode = mode;
            switch (mode)
            {
                case 'b': byteTrans = new Byte_Transmitter("COM5", 9600); break;

                case 's': stringTrans = new String_Transmitter("COM5", 9600); break;

                default: throw new System.InvalidOperationException("Invalid mode");

            }

        }


        public void moveLeg(byte l,byte x,byte y,byte z)
        {
            if (this.mode == 'b')
            {
                byte[] sentData = new byte[4];
                sentData = Byte_Signal.moveLeg(l, x, y, z);
                byteTrans.SendByteArray(sentData);
            }
            else
            {
                string sentDataString = String_Signal.moveLeg("C10L" + l + 'x' + x + 'y' + y + 'z' + z);
                stringTrans.SendString(sentDataString);
            }

        }

        public void moveServo(byte l, byte alpha, byte beta, byte gamma)
        {
            if (this.mode == 'b')
            {
                byte[] sentData = new byte[4];
                sentData = Byte_Signal.moveServo(l, alpha, beta, gamma);
                byteTrans.SendByteArray(sentData);
            }
            else
            {
                string sentDataString = String_Signal.moveServo("C11L" + l + 'c' + alpha + 'f' + beta + 't' + gamma);
                stringTrans.SendString(sentDataString);
            }

        }

        //TODO moverobot
    }
}
