using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Project
{
    // Class for Submissions
    public class Submission
    {
        public string StudentName { get; set; }
        public int SubmissionID { get; set; }
        public string Content { get; set; }
        public string FilePath { get; set; }
        public Result result;
    }
}
