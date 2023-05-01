using System;
using System.Windows.Forms;
using System.IO;

namespace Software_Engineering_Project
{
    public partial class FormAddSubmission : Form
    {
        public Submission submission { get; set; }

        private FileInfo codeInfo;

        private bool hasName => submission.SubmissionName.Length > 0;
        private bool hasFile => codeInfo.Exists;
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


        private void WriteFile(){
            File.WriteAllText(submission.FilePath.FullName, GetCodeText(submission.FilePath));
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
            if(codeInfo.Exists)
                textBoxCodePreview.Text = GetCodeText(codeInfo);
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
            string fileName = $"{assignment.Submissions.Count + 1} - {codeInfo.Name}";
            string path = Path.Combine(assignment.SubmissionsDirectory.FullName, fileName);
            submission.FilePath = new FileInfo(path);
        }

        private string GetCodeText(FileInfo info){
            return new StreamReader(info.OpenRead()).ReadToEnd();
        }

        private void textBoxSubmissionName_TextChanged(object sender,EventArgs e)
        {
            if(textBoxSubmissionName.Text.Length > 0)
                submission.SubmissionName = textBoxSubmissionName.Text;
        }
    }
}
