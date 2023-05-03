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
        public BuildResult BuildResult { get; set; }
        public CppCompilation CppCompilation { get; set; }

        public override string ToString()
        {
            string resultAsString = string.Empty;

            resultAsString += $"Compiled:\t\t\tTrue\n";
            resultAsString += $"Did .exe run:\t\t\tTrue\n";
            resultAsString += $"Output matches:\t\tFalse\n";
            resultAsString += $"Output Match Percentage:\t0.5%\n";
            resultAsString += $"Output from .exe:\n\tHello World\n";

            if(CppCompilation != null && CppCompilation.HasErrors){
                resultAsString += $"\nCompilation Errors:\n";
                foreach(var message in CppCompilation.Diagnostics.Messages)
                    resultAsString += $"\t{message.ToString()}\n";
            }

            if(BuildResult != null && BuildResult.OverallResult != BuildResultCode.Success){
                resultAsString += "\nBuild Error:\n";
                resultAsString += $"\t{BuildResult.Exception.ToString()}\n";
            }

            return resultAsString;
        }
    }
}
