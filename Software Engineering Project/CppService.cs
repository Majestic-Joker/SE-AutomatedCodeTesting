using CppAst;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Logging;
using System;
using System.IO;

namespace Software_Engineering_Project
{
    public class CppService
    {
        private readonly BuildResult buildResult;
        private readonly CppCompilation compilation;
        private readonly string exePath = null;

        public BuildResult BuildResult => buildResult;
        public CppCompilation Compilation => compilation;
        public string ExePath => exePath;
        public bool IsBuilt => buildResult.OverallResult == BuildResultCode.Success;

        public CppService(string filepath, string codePath) {
            compilation = CppParser.ParseFile(codePath);
            string projectPath = CreateProject(filepath, codePath);
            exePath = BuildExe(projectPath);
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
            var buildResult = BuildManager.DefaultBuildManager.Build(buildParameters, buildRequestData);

            // Check if the build succeeded
            if (buildResult.OverallResult == BuildResultCode.Success)
            {
                Console.WriteLine("Build succeeded!");

                var outputPath = project.GetPropertyValue("OutputPath");
                var outputDir = Path.Combine(project.DirectoryPath, outputPath);
                var exePath = Path.Combine(outputDir, $"{project.GetPropertyValue("ProjectName")}.exe");
            }
            else
            {
                Console.WriteLine("Build failed!");
            }

            return exePath;
        }
    }
}