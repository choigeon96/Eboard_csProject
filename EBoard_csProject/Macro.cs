using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBoard_csProject
{
    class Macro
    {
        public string MacroName { get; set; }
        public string[] MacroStringData { get; set; }

        public Macro()
        {
            MacroStringData = new string[24];
        }
    }
}
