using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public class CppService
    {
        private float matchPercent = 0.0f;
        private string exeOut;

        private readonly string exePath = null;
        private readonly float matchTarget = 90.0f;

        public string ExePath => exePath;
        public string ExeOut => exeOut;
        public float MatchPercent => matchPercent;
        public bool DoesMatch => matchPercent > matchTarget;

        public CppService(Assignment assignment, Submission submission) {
            ExeRunner runner = null;
            submission.Result = new Result();
            matchTarget = assignment.MatchRequirement;

            exePath = Compile(submission);

            if(exePath.Length > 0){
                UpdateCompilationResults(submission.Result);
                runner = TryRunExe(assignment);
            }

            if(runner != null && runner.RunCompleted)
            {
                matchPercent = GetMatchPercentage(runner, assignment);
                UpdateRunResults(submission.Result);
            }
        }

        private void UpdateCompilationResults(Result subResult) {
            subResult.Compiled = true;
            subResult.ExeFilepath = ExePath;
        }

        private void UpdateRunResults(Result subResult){
            subResult.RunComplete = true;
            subResult.OutputMatchesExpected = DoesMatch;
            subResult.MatchPercentage = MatchPercent.ToString("n2");
            subResult.ExeOutput = ExeOut;
        }

        private string Compile(Submission submission){
            var info = new FileInfo(submission.FilePath);

            string batchPath = info.DirectoryName + "\\GPPcompile.bat";

            string noSpaceSubName = new string(submission.SubmissionName.Where(c => !char.IsWhiteSpace(c)).ToArray());

            string[] lines = {
                $"g++.exe {info.FullName} -o {noSpaceSubName}.exe",
                "exit"
            };

            using(StreamWriter writer = new StreamWriter(batchPath))
                foreach(string line in lines)
                    writer.WriteLine(line);

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = batchPath,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = info.DirectoryName
                }
            };

            process.Start();
            process.WaitForExit();

            string executePath = Path.Combine(info.DirectoryName, $"{noSpaceSubName}.exe");

            if(File.Exists(executePath))
                return executePath;

            return "";
        }

        private ExeRunner TryRunExe(Assignment assignment){
            ExeRunner runner = null;
            
            if(ExePath.Length > 0){
                runner = new ExeRunner{ ExeFilePath = ExePath, InputFilePath = assignment.InputFilepath};
                runner.RunExe();
                exeOut = runner.ExeOutput;
            }
            
            return runner;
        }

        private float GetMatchPercentage(ExeRunner runner, Assignment assignment){
            string expectedOutput = new StreamReader(assignment.OutputFilepath).ReadToEnd();

            string[] exeLines = GetLines(runner.ExeOutput);
            string[] assignmentLines = GetLines(expectedOutput);

            float count = 0f;
            for(int i = 0; i < assignmentLines.Length; i++){
                for(int j = 0; j < exeLines.Length; i++){
                    string left = new string(exeLines[j].Where(c => !char.IsWhiteSpace(c)).ToArray());
                    string right = new string(assignmentLines[i].Where(c => !char.IsWhiteSpace(c)).ToArray());

                    bool full = left.Equals(right);
                    bool half = left.Equals(right,  StringComparison.OrdinalIgnoreCase);
                        
                    if (full)
                        count += 0.5f;

                    if (half)
                        count += 0.5f;

                    if (full || half)
                        break;
                }
            }

            return (count / (float)assignmentLines.Length) * 100;
        }

        private string[] GetLines(string text){
            string[] locResult = Regex.Split(text, "[\r?\n]+");
            return locResult;
        }
    }
}