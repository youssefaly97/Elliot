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
        public static string moveServo(string servonum_angle)
        {
            return servonum_angle;
        }

        public static string moveLeg(string legnum_x_y_z)
        {
            return legnum_x_y_z;
        }

        public static string moveRobot(string command)
        {
            return command;
        }
    }
}
