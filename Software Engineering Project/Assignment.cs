using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Project
{
    // Class for Assignments
    public class Assignment
    {
        public string AssignmentName { get; set; }
        public string AssignmentDirectory { get; set; }
        public string SubmissionsDirectory { get; set; }
        public string AssignmentFile { get; set; }
        public List<Submission> Submissions { get; set; }
        public string InputFilepath { get; set; }
        public string OutputFilepath { get; set; }
        public float MatchRequirement { get; set; }
    }
}
