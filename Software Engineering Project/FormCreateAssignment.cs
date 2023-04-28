using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class FormCreateAssignment : Form
    {
        private bool hasName => textBoxAssignmentName.Text != string.Empty;
        private bool hasInputFile => labelInputFilePath.Text != string.Empty;
        private bool hasOutputFile => labelOutputFilePath.Text != string.Empty;
        private bool canSave => hasName && hasOutputFile;

        string assignmentFilepath = "";
        private readonly string programDirectory;

        public Assignment assignment { get; set; }

        public FormCreateAssignment(string programDirectory)
        {
            InitializeComponent();
            EmptyTextBoxes();

            this.programDirectory = programDirectory;

            assignment = new Assignment();
        }

        #region assignment functions

        /// <summary>
        /// Creates Assignments folder and json file
        /// </summary>
        public void CreateAssignment()
        {
            string assignmentName = textBoxAssignmentName.Text;

            // assignment
            Assignment newAssignment = new Assignment
            {
                AssignmentName = assignmentName,
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

        private string CreateDirectory(){

            string temp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "AutomatedCodeTester");
            Directory.CreateDirectory(temp);
            return temp;
        }

        private void WriteFile(string fileText){
            File.WriteAllText(assignment.AssignmentDirectory, fileText);
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
            DialogResult = DialogResult.Cancel; 
            Close();
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
