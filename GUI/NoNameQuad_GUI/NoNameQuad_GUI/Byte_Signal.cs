using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
    static class Byte_Signal
    {
        public static byte[] moveServo(byte legNum, byte alpha,byte beta,byte gamma)
        {
            byte[] toSend = new byte[4];

            toSend[0] = legNum;
            toSend[1] = alpha;
            toSend[2] = beta;
            toSend[3] = gamma;

            return toSend;
        }

        public static byte[] moveLeg(byte legNum, byte x, byte y, byte z)
        {
            byte[] toSend = new byte[4];

            toSend[0] = legNum; //PLEASE REVISE!!!!!!!!!
            toSend[1] = x;
            toSend[2] = y;
            toSend[3] = z;

            return toSend;
        }

        //public static byte[] moverobot()
        //{
        //    TODO
        //}
    }
}
