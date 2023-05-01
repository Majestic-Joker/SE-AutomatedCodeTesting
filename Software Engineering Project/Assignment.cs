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
        public DirectoryInfo AssignmentDirectory { get; set; }
        public DirectoryInfo SubmissionsDirectory { get; set; }
        public FileInfo AssignmentFile { get; set; }
        public List<Submission> Submissions { get; set; }
        public FileInfo InputFilepath { get; set; }
        public FileInfo OutputFilepath { get; set; }
        public float MatchRequirement { get; set; }
    }
}
