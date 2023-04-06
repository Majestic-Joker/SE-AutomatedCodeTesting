using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            public int resultID { get; set; }
            public bool compiled { get; set; }
            public bool runComplete { get; set; }
            public bool outputMatchesExpected { get; set; }
            public string exeFilepath { get; set; }
            public string exeOutput { get; set; }
        }

        // Class for Assignments
        class Assignment
        {
            public string assignmentName { get; set; }
            public string requiredInput { get; set; }
            public string expectedOutput { get; set; }
            public List<Submission> Submissions { get; set; }

            public Assignment()
            {
                Submissions = new List<Submission>();
            }
        }

        // Class for Submissions
        class Submission
        {
            public string studentName { get; set; }
            public int submissionID { get; set; }
            public string Content { get; set; }
            public string filePath { get; set; }
            public Result result;


            public Submission(string name, string content)
            {
                studentName = name;
                Content = content;
            }
        }

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        // create a new assignment
        //        Assignment assignment = new Assignment();

        //        // add some submissions to the assignment
        //        assignment.Submissions.Add(new Submission("Paxton", "This is my submission"));
        //        assignment.Submissions.Add(new Submission("Aodhan", "This is another submission"));
        //    }
        //}

        private void ButtonSaveAssignment_Click(object sender, EventArgs e)
        {
            // Add Filename into ListBox
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in saveFileDialog1.FileNames)
                {
                    
                }
            }
        }
    }
}
