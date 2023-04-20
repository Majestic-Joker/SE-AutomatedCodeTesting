using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Project
{
    // Class for Results
    public class Result
    {
        public int ResultID { get; set; }
        public bool Compiled { get; set; }
        public bool RunComplete { get; set; }
        public bool OutputMatchesExpected { get; set; }
        public string ExeFilepath { get; set; }
        public string ExeOutput { get; set; }
    }
}
