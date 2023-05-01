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
        private bool hasName => assignment.AssignmentName != string.Empty;
        private bool hasInputFile => assignment.InputFilepath.Exists;
        private bool hasOutputFile => assignment.OutputFilepath.Exists;
        private bool canSave => hasName && hasOutputFile;

        public Assignment assignment { get; set; }

        private readonly DirectoryInfo programDirectory;

        public FormCreateAssignment(DirectoryInfo programDirectory)
        {
            InitializeComponent();
            EmptyTextBoxes();

            this.programDirectory = programDirectory;
            assignment = new Assignment();
            assignment.Submissions = new List<Submission>();
        }

        #region assignment functions

        /// <summary>
        /// Creates Assignments folder and json file
        /// </summary>
        public void CreateAssignment()
        {
            CreateAssignmentDirectory();
            CreateAssignmentFileInfo();

            if(assignment.AssignmentFile.Exists)
                WriteFile();
        }

        private bool CreateAssignmentDirectory(){
            assignment.AssignmentDirectory = programDirectory.CreateSubdirectory(assignment.AssignmentName);
            return assignment.AssignmentDirectory.Exists;
        }

        private bool CreateAssignmentFileInfo(){
            string temp = Path.Combine(assignment.AssignmentDirectory.FullName, $"{assignment.AssignmentName}.json");
            assignment.AssignmentFile = new FileInfo(temp);
            return assignment.AssignmentFile.Exists;
        }

        private void WriteFile(){
            string json = JsonSerializer.Serialize(assignment);
            File.WriteAllText(assignment.AssignmentFile.FullName, json);
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

        // TODO: set up input and output files in FormCreateAssignment.cs

        private FileInfo GetInfo()
        {
            FileInfo info = null;
            
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo ofdInfo = new FileInfo(dialog.FileName);

                var fileStream = dialog.OpenFile();
                var reader = new StreamReader(fileStream);
                string fileText = reader.ReadToEnd();

                string temp = Path.Combine(assignment.AssignmentDirectory.FullName, ofdInfo.Name);
                File.WriteAllText(temp, fileText);

                info = new FileInfo(temp);
            }

            return info;
        }
        #endregion

        private void buttonInput_Click(object sender, EventArgs e)
        {
            assignment.InputFilepath = GetInfo();
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            assignment.OutputFilepath = GetInfo();

            ButtonSaveAssignment.Enabled = assignment.OutputFilepath.Exists;
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

        private void textBoxAssignmentName_TextChanged(object sender,EventArgs e)
        {
            //TODO: Copy output and input files if exists
            if(assignment.AssignmentDirectory.Exists)
                assignment.AssignmentDirectory.Delete();
            
            CreateAssignmentDirectory();
            CreateAssignmentFileInfo();

            if(textBoxAssignmentName.Text.Length > 0)
                assignment.AssignmentName = textBoxAssignmentName.Text;

            buttonInput.Enabled = hasName;
            buttonOutput.Enabled = hasName;

            ButtonSaveAssignment.Enabled = canSave;                
        }
    }
}
