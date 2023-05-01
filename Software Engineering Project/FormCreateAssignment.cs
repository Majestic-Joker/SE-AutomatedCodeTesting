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
        private FileInfo inputTemp;
        private FileInfo outputTemp;

        private bool hasName => assignment.AssignmentName.Length > 0;
        private bool hasOutputFile => outputTemp.Exists;
        private bool canSave => hasName && hasOutputFile;

        public Assignment assignment { get; set; }

        private readonly DirectoryInfo programDirectory;

        public FormCreateAssignment(DirectoryInfo programDirectory)
        {
            InitializeComponent();

            this.programDirectory = programDirectory;

            assignment = new Assignment{
                Submissions = new List<Submission>(),
                MatchRequirement = (float)Nud_MatchReqSelector.Value
            };
        }

        #region File Manipulation Functions
        /// <summary>
        /// Creates Assignments folder and json file
        /// </summary>
        public void CreateAssignment()
        {
            CreateAssignmentDirectory();
            CreateAssignmentFileInfo();

            if(assignment.AssignmentFile.Exists)
                WriteFile(assignment.AssignmentFile, JsonSerializer.Serialize(assignment));

            if(inputTemp.Exists){
                assignment.InputFilepath = CopyFileInfo(inputTemp);
                WriteFile(assignment.InputFilepath, GetFileText(assignment.InputFilepath));
            }

            if(outputTemp.Exists){
                assignment.OutputFilepath = CopyFileInfo(outputTemp);
                WriteFile(assignment.OutputFilepath, GetFileText(assignment.OutputFilepath));
            }
        }

        /// <summary>
        /// Method creates a subdirectory in programDirectory of assignmentName
        /// </summary>
        /// <returns></returns>
        private bool CreateAssignmentDirectory(){
            assignment.AssignmentDirectory = programDirectory.CreateSubdirectory(assignment.AssignmentName);
            return assignment.AssignmentDirectory.Exists;
        }

        /// <summary>
        /// Method creates a fileInfo for the assignmentFile.json and sets it on the assignment
        /// </summary>
        /// <returns></returns>
        private bool CreateAssignmentFileInfo(){
            string temp = Path.Combine(assignment.AssignmentDirectory.FullName, $"{assignment.AssignmentName}.json");
            assignment.AssignmentFile = new FileInfo(temp);
            return assignment.AssignmentFile.Exists;
        }

        /// <summary>
        /// Method writes fileText to the location of fileInfo
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="fileText"></param>
        private void WriteFile(FileInfo fileInfo, string fileText){
            File.WriteAllText(fileInfo.FullName, fileText);
        }

        /// <summary>
        /// Method launches the OpenFileDialog and returns a FileInfo created by the opened file.
        /// </summary>
        /// <returns></returns>
        private FileInfo GetFileInfo()
        {
            FileInfo info = null;
            
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                info = new FileInfo(dialog.FileName);

            return info;
        }

        /// <summary>
        /// Method intended to copy the temporary input/output fileInfos to the assignment directory on saving.
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        private FileInfo CopyFileInfo(FileInfo info){
            FileInfo returnable = null;

            string path = Path.Combine(assignment.AssignmentDirectory.FullName, info.Name);
            returnable = new FileInfo(path);

            return returnable;
        }

        /// <summary>
        /// Method opens a FileInfo and returns the text of the file.
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        private string GetFileText(FileInfo info){
            var filestream = info.OpenRead();
            var reader = new StreamReader(filestream);
            string fileText = reader.ReadToEnd();

            return fileText;
        }
        #endregion

        #region Form Object Events
        /// <summary>
        /// creates assignment and returns the dialog with result OK if canSave, otherwise it warns the user
        /// and returns dialog with result Cancel if they proceed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveAssignment_Click(object sender, EventArgs e)
        {
            if (canSave){
                CreateAssignment();
                DialogResult = DialogResult.OK;
                Close();
            } else
            {
                var result = MessageBox.Show("AssignmentName and OutputFile are required fields.\nPressing OK will discard any progress you have made on this form.\nPressing Cancel returns you to the form.","Unable to Save - Missing Requirements", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK){
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
        }

        /// <summary>
        /// Returns to calling form with result of Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }

        /// <summary>
        /// Event gets a FileInfo from OpenFileDialog and stores it in inputTemp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInput_Click(object sender, EventArgs e)
        {
            inputTemp = GetFileInfo();
        }

        /// <summary>
        /// Event gets a FileInfo from OpenFileDialog and stores it in outputTemp. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOutput_Click(object sender, EventArgs e)
        {
            outputTemp = GetFileInfo();
        }

        /// <summary>
        /// Event updates assignmentName with textbox.Text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAssignmentName_TextChanged(object sender,EventArgs e)
        {
            if(textBoxAssignmentName.Text.Length > 0)
                assignment.AssignmentName = textBoxAssignmentName.Text;            
        }

        /// <summary>
        /// Event updates assignment.MatchRequirement with numericUpDown.Value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nud_MatchReqSelector_ValueChanged(object sender,EventArgs e)
        {
            var nud = sender as NumericUpDown;

            if(nud != null)
                assignment.MatchRequirement = (float)nud.Value;
        }
        #endregion
    }
}