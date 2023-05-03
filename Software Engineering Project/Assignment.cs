using System.Collections.Generic;
using System.Text.Json;

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

        public override string ToString()    
        {
            string assignmentString = string.Empty;

            assignmentString += $"Assignment Name: {AssignmentName}\n";
            assignmentString += $"JSON:\n";
            assignmentString += JsonSerializer.Serialize(this, new JsonSerializerOptions{ WriteIndented = true });

            return assignmentString;
        }
    }
}
