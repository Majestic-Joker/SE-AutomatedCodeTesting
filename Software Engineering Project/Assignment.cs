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
        public string AssignmentDirectory { get; set; }
        public List<Submission> Submissions { get; set; }
        public string InputFilepath { get; set; }
        public string OutputFilepath { get; set; }

        //public Assignment()
        //{

        //}

        //public Assignment(Assignment other)
        //{
        //    AssignmentName = other.AssignmentName;
        //    RequiredInput = other.RequiredInput;
        //    ExpectedOutput = other.ExpectedOutput;
        //    AssignmentDirectory = other.AssignmentDirectory;
        //    InputFilepath = other.InputFilepath;
        //    OutputFilepath = other.OutputFilepath;

        //    foreach(var submission in other.Submissions)
        //    {
        //        Submissions.Add(submission);
        //    }
        //}
    }
}
