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
    }
}
