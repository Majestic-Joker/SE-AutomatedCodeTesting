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

        // create save file so we can pull files from our desktop to run
        readonly SaveFileDialog saveFileDialog1 = new SaveFileDialog
        {
            //Multiselect = true,
            InitialDirectory = @"D:\",
            Title = "Browse Text Files",

            CheckFileExists = true,
            CheckPathExists = true,

            DefaultExt = "txt",
            Filter = "txt files (*.txt)|*.txt",
            FilterIndex = 2,
            RestoreDirectory = true,

            //ReadOnlyChecked = true,
            //ShowReadOnly = true,
        };

        public FormCreateAssignment()
        {
            InitializeComponent();
        }

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
        class Assignment
        {
            public string AssignmentName { get; set; }
            public string RequiredInput { get; set; }
            public string ExpectedOutput { get; set; }
            public List<Submission> Submissions { get; set; }
            public object InputFilepath { get; internal set; }
            public object OutputFilepath { get; internal set; }

            public Assignment()
            {
                Submissions = new List<Submission>();
            }
        }

        // Class for Submissions
        class Submission
        {
            public string StudentName { get; set; }
            public int SubmissionID { get; set; }
            public string Content { get; set; }
            public string FilePath { get; set; }
            public Result result;


            public Submission(string name, string content)
            {
                StudentName = name;
                Content = content;
            }
        }

        private void ButtonSaveAssignment_Click(object sender, EventArgs e)
        {
            string assignmentName = "Assignment";
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CppGrader");
            object inputFilepath = 1;
            object outputFilepath = 1;
            string assignmentFilepath = "s";
            object AssignmentFilepath = 1;

            //Assignment newAssignment = new Assignment
            //{
            //    AssignmentName = textBoxAssignmentName.Text,
            //    InputFilepath = inputFilepath,
            //    OutputFilepath = outputFilepath,
            //    AssignmentFilepath,
            //    assignmentFilepath
            //};
            folderPath = Path.Combine(folderPath, assignmentName);
            Directory.CreateDirectory(folderPath);
            // string json = JsonSerializer.Serialize(newAssignment);
            string temp = Path.Combine(assignmentFilepath, "assignmentName.json");
            // File.WriteAllText(assignmentFilepath, json);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are You Sure you Want to Exit This Window?",
                "Make sure to Save Assignment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(closeResult == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
