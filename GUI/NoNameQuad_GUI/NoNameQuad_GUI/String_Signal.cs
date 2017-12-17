using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
    static class String_Signal
    {
        public static string intializeRobot(int fr,int fl ,int br, int bl)
        {

            return "C13" + "fr" + fr + "fl" + fl + "br" + br + "bl" + bl;

        }
        public static string moveServo(int l ,int alpha,int beta,int gamma)
        {
            return "C11L" + l + 'c' + alpha + 'f' + beta + 't' + gamma;
        }

        public static string moveLeg(int l, int x, int y, int z)
        {
            return "C10L" + l + 'x' + x + 'y' + y + 'z' + z;
        }

        public static string moveRobot(string command)
        {
            switch (command)
            {
                case "FORWARD":
                    return "C12f";
                    
                case "BACKWARD":
                    return "C12b" + 1;
                    

                case "LEFT":
                    return "C12l" + 2;
                    

                case "RIGHT":
                    return "C12r" + 3;
                    


            }
            return "C12";
        }
        public static string rotateRobot(string command)
        {
            switch (command)
            {
                case "CW":
                    return "C14c";

                case "CCW":
                    return "C14w";

            }
            return "C14";
        }

    }
}
