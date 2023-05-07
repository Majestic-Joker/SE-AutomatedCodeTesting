using CppAst;
using Microsoft.Build.Execution;

namespace Software_Engineering_Project
{
    // Class for Results
    public class Result
    {
        public bool Compiled { get; set; }
        public bool RunComplete { get; set; }
        public bool OutputMatchesExpected { get; set; }
        public string MatchPercentage { get; set; } 
        public string ExeFilepath { get; set; }
        public string ExeOutput { get; set; }

        public override string ToString()
        {
            string resultAsString = string.Empty;

            resultAsString += $"Compiled:\t\t\t{Compiled}\n";
            resultAsString += $"Did .exe run:\t\t\t{RunComplete}\n";
            resultAsString += $"Output matches:\t\t{OutputMatchesExpected}\n";
            resultAsString += $"Output Match Percentage:\t{MatchPercentage}%\n";
            resultAsString += $"Output from .exe:\n\t{ExeOutput}\n";

            return resultAsString;
        }
    }
}
