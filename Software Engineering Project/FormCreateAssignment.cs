using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class FormCreateAssignment : Form
    {
        private bool hasName => textBoxAssignmentName.Text != string.Empty;
        private bool hasInputFile => labelInputFilePath.Text != string.Empty;
        private bool hasOutputFile => labelOutputFilePath.Text != string.Empty;
        private bool canSave => hasName && hasInputFile && hasOutputFile;
        private string codeText;

        string assignmentFilepath = "";

        public Assignment? assignment { get; set; }

        public FormCreateAssignment()
        {
            InitializeComponent();
            EmptyTextBoxes();

            assignment = new Assignment();


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


            //listBoxAssignments.Items.Add(assignmentFilepath);
            labelFilePath.Text = assignmentFilepath;

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

        // TODO: set up input and output files

        private string GetInfo(string assignmentDirectory)
        {
            string filePath = "";
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                FileInfo info = new FileInfo(dialog.FileName);

                var fileStream = dialog.OpenFile();
                var reader = new StreamReader(fileStream);
                string code = reader.ReadToEnd();
                string temp = assignmentDirectory;
                Directory.CreateDirectory(temp);
                temp = Path.Combine(temp, info.Name);
                File.WriteAllText(temp, code);
                filePath = temp;
                codeText = new StreamReader(dialog.OpenFile()).ReadToEnd();
                textBoxAssignmentPreview.Text = codeText;
                ButtonSaveAssignment.Enabled = canSave;
            }
            return filePath;
        }
        #endregion

        private void buttonInput_Click(object sender, EventArgs e)
        {
            string input = GetInfo(assignment.AssignmentDirectory);
            assignment.InputFilepath = input;
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            string output = GetInfo(assignment.AssignmentDirectory);
            assignment.OutputFilepath = output;
        }

        private void EmptyTextBoxes()
        {
            textBoxAssignmentName.Text = string.Empty;

            labelInputFilePath.Text = string.Empty;

            labelOutputFilePath.Text = string.Empty;
        }

        private void textBoxAssignmentPreview_TextChanged(object sender, EventArgs e)
        {
            ButtonSaveAssignment.Enabled = canSave;
        }
    }
}
