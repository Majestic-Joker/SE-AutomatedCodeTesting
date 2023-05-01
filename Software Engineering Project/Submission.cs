using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Project
{
    // Data model for Submission
    public class Submission
    {
        public string SubmissionName { get; set; }
        public int SubmissionID { get; set; }
        public string Content { get; set; }
        public string FilePath { get; set; }
        public Result Result { get; set; }

        public override string ToString()
        {
            string submissionAsString = string.Empty;

            submissionAsString += $"{SubmissionName}";

            return submissionAsString;
        }
    }
}
