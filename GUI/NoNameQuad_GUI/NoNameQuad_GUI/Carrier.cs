using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
    class Carrier
    {
        List<string> Data = new List<string>();

        public void Write(string param)
        {
            Data.Add(param);
        }

        public List<string> Read()
        {
            return Data;
        }



    }
}
