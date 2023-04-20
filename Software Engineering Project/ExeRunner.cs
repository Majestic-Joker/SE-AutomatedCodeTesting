using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project.Compilation
{
    public class ExeRunner
    {
        //Properties
        public bool RunCompleted { get; set; }

        public string ExeOutput { get; set; }

        public string ExeFilePath { get; set; }

        public string InputFilePath { get; set; }   

        //Uses the two FilePath properties to get input and updates ExeOutput based on result
        public bool RunExe()
        {
            //create new process, this will allow the program to run an exe
            Process process = new Process();
            //Tell the program what file to run
            process.StartInfo.FileName = ExeFilePath;

            process.StartInfo.UseShellExecute = false;
            //allows the program to send the output where ever we want
            process.StartInfo.RedirectStandardOutput = true;

            //check to see if the program has an input file
            if (InputFilePath != null) { 
                process.StartInfo.Arguments = InputFilePath;
            }
            //start running the executable
            process.Start();
            //get output from exe
            string output = process.StandardOutput.ReadToEnd();
            //make sure program is done running
            process.WaitForExit();
            //update ExeOutput
            ExeOutput = output;
            //check to make sure exe has run correctly
            if(process.ExitCode != 0) { return false; }
            //STRETCH 
            //could determine what exit code is and display pertenent informant
            //Show that the program has run correctly
            return true;
        }
    }
}
