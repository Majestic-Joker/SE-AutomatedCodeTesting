using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class FormCreateAssignment : Form
    {
        string assignmentFilepath = "";

        public Assignment? assignment { get; set; }

        public FormCreateAssignment()
        {
            InitializeComponent();

            //FormClosing += FormCreateAssignment_FormClosing;
        }

        #region assignment functions

        /// <summary>
        /// Creates Assignments folder and json file
        /// </summary>
        public void CreateAssignment()
        {
            string assignmentName = textBoxAssignmentName.Text;

            // creates a folder called CppGrader
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CppGrader");

            string inputFilepath = "Input.txt";
            string outputFilepath = "Output.txt";

            // assignment
            Assignment newAssignment = new Assignment
            {
                AssignmentName = assignmentName,
                RequiredInput = textBoxRequiredInput.Text,
                ExpectedOutput = textBoxExpectedOutput.Text,
                InputFilepath = inputFilepath,
                OutputFilepath = outputFilepath,
                Submissions = new List<Submission>()
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
            newAssignment.AssignmentDirectory = folderPath;
            //assignmentFilepath = folderPath;
            assignment = newAssignment;

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


            listBoxAssignments.Items.Add(assignmentFilepath);

            DialogResult = DialogResult.OK;

            Close();
        }

        /// <summary>
        /// gives the user a chance to create,edit, or save assignment before exiting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            PropertyInfo pi = typeof(Form).GetProperty("CloseReason", BindingFlags.NonPublic | BindingFlags.Instance);
            pi.SetValue(this, CloseReason.None, null);
        }

        //private void FormCreateAssignment_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Visible = false;
        //    e.Cancel = true;//cancel close if user requested
        //    PropertyInfo pi = typeof(Form).GetProperty("CloseReason", BindingFlags.NonPublic | BindingFlags.Instance);
        //    pi.SetValue(this, CloseReason.None, null);
        //}
        #endregion
    }
}
