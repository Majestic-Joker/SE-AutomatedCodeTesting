using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Project
{
    // Class for Assignments
    public class Assignment
    {
        public string AssignmentName { get; set; }
        public string RequiredInput { get; set; }
        public string ExpectedOutput { get; set; }
        public List<Submission> Submissions { get; set; }
        public object InputFilepath { get; internal set; }
        public object OutputFilepath { get; internal set; }
    }
}
