using CppAst;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Logging;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Software_Engineering_Project
{
    public class CppService
    {
        private BuildResult buildResult;
        private float matchPercent = 0.0f;
        private string exeOut;

        private readonly CppCompilation compilation;
        private readonly string exePath = null;
        private readonly float matchTarget = 90.0f;

        public BuildResult BuildResult => buildResult;
        public CppCompilation Compilation => compilation;
        public string ExePath => exePath;
        public string ExeOut => exeOut;
        public float MatchPercent => matchPercent;
        public bool IsBuilt => buildResult.OverallResult == BuildResultCode.Success;
        public bool DoesMatch => matchPercent > matchTarget;

        public CppService(Assignment assignment, Submission submission) {
            ExeRunner runner = null;
            submission.Result = new Result();

            compilation = CppParser.ParseFile(submission.FilePath);

            string projectPath = CreateProject(assignment.AssignmentDirectory.FullName, submission.FilePath, submission.StudentName);
            exePath = BuildExe(projectPath, submission.StudentName);

            if(IsBuilt){
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
            subResult.CppCompilation = Compilation;
            subResult.BuildResult = BuildResult;
            subResult.ExeFilepath = ExePath;
        }

        private void UpdateRunResults(Result subResult){
            subResult.RunComplete = true;
            subResult.OutputMatchesExpected = DoesMatch;
            subResult.MatchPercentage = MatchPercent.ToString("n2");
            subResult.ExeOutput = ExeOut;
        }

        private string CreateDirectory(string parentDirectory){
            string temp = Path.Combine(parentDirectory, "Projects");
            Directory.CreateDirectory(temp);
            return temp;
        }

        private string CreateProject(string filepath, string codePath, string projectName = "Test")
        { 
            var projectRootElement = ProjectRootElement.Create();
            projectRootElement.AddProperty("ProjectName", projectName);
            projectRootElement.AddProperty("Configuration", "Release");
            projectRootElement.AddProperty("Platform", "x64");
            projectRootElement.AddProperty("ProjectGuid", Guid.NewGuid().ToString());
            projectRootElement.AddProperty("Keyword", "Win32Proj");

            // Add a new item group for source files
            var itemGroupElement = projectRootElement.AddItemGroup();
            itemGroupElement.AddItem("ClCompile", codePath);

            string returnable = Path.Combine(filepath, "/project.vcxproj");

            // Save the project file
            projectRootElement.Save(returnable);

            return returnable;
        }

        public string BuildExe(string projectPath, string projectName = "Test")
        {
            // Load the project file
            var projectCollection = new ProjectCollection();
            var project = projectCollection.LoadProject(projectPath);

            // Build the project
            var buildParameters = new BuildParameters
            {
                Loggers = new[] { new ConsoleLogger() }
            };

            var buildRequestData = new BuildRequestData(project.CreateProjectInstance(), new[] { "Build" });
            buildResult = BuildManager.DefaultBuildManager.Build(buildParameters, buildRequestData);

            // Check if the build succeeded
            if (buildResult.OverallResult == BuildResultCode.Success)
            {
                var outputPath = project.GetPropertyValue("OutputPath");
                var outputDir = Path.Combine(project.DirectoryPath, outputPath);
                var exePath = Path.Combine(outputDir, $"{project.GetPropertyValue("ProjectName")}.exe");
            }

            return exePath;
        }

        private ExeRunner TryRunExe(Assignment assignment){
            ExeRunner runner = new ExeRunner{ ExeFilePath = ExePath, InputFilePath = assignment.InputFilepath.FullName};
            runner.RunExe();
            exeOut = runner.ExeOutput;
            return runner;
        }

        private float GetMatchPercentage(ExeRunner runner, Assignment assignment){
            string expectedOutput = new StreamReader(assignment.OutputFilepath.FullName).ReadToEnd();

            string[] exeLines = GetLines(runner.ExeOutput);
            string[] assignmentLines = GetLines(expectedOutput);

            float count = 0f;
            for(int i = 0; i < assignmentLines.Length; i++){
                for(int j = 0; j < exeLines.Length; i++){
                    bool full = exeLines[j].Equals(assignmentLines[i]);
                    bool half = exeLines[j].Equals(assignmentLines[i],  StringComparison.OrdinalIgnoreCase);
                        
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