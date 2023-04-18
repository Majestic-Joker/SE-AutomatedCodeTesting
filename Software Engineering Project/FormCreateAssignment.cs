using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class FormCreateAssignment : Form
    {
        string assignmentFilepath = "";

        public FormCreateAssignment()
        {
            InitializeComponent();
        }

        #region Classes

        // Class for Results
        class Result
        {
            public int ResultID { get; set; }
            public bool Compiled { get; set; }
            public bool RunComplete { get; set; }
            public bool OutputMatchesExpected { get; set; }
            public string ExeFilepath { get; set; }
            public string ExeOutput { get; set; }
        }

        // Class for Assignments
        public class Assignment
        {
            public string AssignmentName { get; set; }
            public string RequiredInput { get; set; }
            public string ExpectedOutput { get; set; }
            public List<Submission> Submissions { get; set; }
            public object InputFilepath { get; internal set; }
            public object OutputFilepath { get; internal set; }
        }

        // Class for Submissions
        public class Submission
        {
            public string StudentName { get; set; }
            public int SubmissionID { get; set; }
            public string Content { get; set; }
            public string FilePath { get; set; }
            //public Result result;
        }
        #endregion

        #region assignment functions
        /// <summary>
        /// Creates Assignments folder and json file
        /// </summary>
        public void CreateAssignment()
        {
            string assignmentName = "Assignment";

            // creates a folder called CppGrader
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CppGrader");

            object inputFilepath = "Input.txt";
            object outputFilepath = "Output.txt";

            // assignment
            Assignment newAssignment = new Assignment
            {
                AssignmentName = textBoxAssignmentName.Text,
                RequiredInput = textBoxRequiredInput.Text,
                ExpectedOutput = textBoxExpectedOutput.Text,
                InputFilepath = inputFilepath,
                OutputFilepath = outputFilepath,
            };
            // serialize
            string json = JsonSerializer.Serialize(newAssignment);

            // folderpath created
            folderPath = Path.Combine(folderPath, assignmentName);
            Directory.CreateDirectory(folderPath);


            string temp = Path.Combine(folderPath, $"{assignmentName}.json");

            // written user info to json
            File.WriteAllText(temp, json);

            // save filepath
            assignmentFilepath = folderPath;
        }
        #endregion

        #region button events

        /// <summary>
        /// creates assignment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveAssignment_Click(object sender, EventArgs e)
        {
            CreateAssignment();
        }

        /// <summary>
        /// gives the user a chance to create,edit, or save assignment before exiting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with Yes and No buttons
            DialogResult closeResult = MessageBox.Show("Are You Sure you Want to Exit This Window?",
                "Make sure to Save Assignment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Check which button the user clicked
            if (closeResult == DialogResult.Yes)
            {
                Hide();
            }
        }

        #endregion
    }
}
