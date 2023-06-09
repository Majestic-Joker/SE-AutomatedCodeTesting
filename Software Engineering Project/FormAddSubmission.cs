﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Software_Engineering_Project
{
    public partial class FormAddSubmission : Form
    {
        public Submission submission { get; set; }

        private FileInfo codeInfo;
        private string noSpaceName;

        private bool hasName => submission.SubmissionName.Length > 0;
        private bool hasFile => codeInfo != null && codeInfo.Exists;
        private bool canSave => hasName && hasFile;

        private readonly Assignment assignment;

        public FormAddSubmission(Assignment assignment)
        {
            InitializeComponent();

            this.assignment = assignment;

            submission = new Submission();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private async void WriteFile(){
            var task = File.WriteAllTextAsync(submission.FilePath, GetCodeText(codeInfo));
            
            while(!task.IsCompleted)
                await System.Threading.Tasks.Task.Delay(50);
        }

        /// <summary>
        /// Save Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddSubmission_Click(object sender, EventArgs e)
        {
            if(canSave){
                CopyCodeInfo();
                submission.Result = new Result();
                WriteFile();
                DialogResult = DialogResult.OK;
                Close();
            }
            else{
                var result = MessageBox.Show("SubmissionName and CodeFile are required fields.\nPressing OK will discard any progress you have made on this form.\nPressing Cancel returns you to the form.","Unable to Save - Missing Requirements", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK){
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            codeInfo = GetFileInfo();
            if(codeInfo != null && codeInfo.Exists) { 
                textBoxCodePreview.Text = GetCodeText(codeInfo);
                labelFile.Text = codeInfo.Name;
            }
            else
                textBoxCodePreview.Text = "Unable to open file.";
        }

        private FileInfo GetFileInfo(){
            FileInfo info = null;

            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
                info = new FileInfo(dialog.FileName);

            return info;
        }

        private void CopyCodeInfo(){
            string codeName = new string(codeInfo.Name.Where(c => !char.IsWhiteSpace(c)).ToArray());
            string fileName = $"{assignment.Submissions.Count + 1}_{noSpaceName}_{codeName}";
            string path = Path.Combine(assignment.SubmissionsDirectory, fileName);
            submission.FilePath = path;
        }

        private string GetCodeText(FileInfo info){
            return new StreamReader(info.OpenRead()).ReadToEnd();
        }

        private void textBoxSubmissionName_TextChanged(object sender,EventArgs e)
        {
            if(textBoxSubmissionName.Text.Length > 0){
                submission.SubmissionName = textBoxSubmissionName.Text;
                noSpaceName = new string(submission.SubmissionName.Where(c => !char.IsWhiteSpace(c)).ToArray());
            }
        }
    }
}