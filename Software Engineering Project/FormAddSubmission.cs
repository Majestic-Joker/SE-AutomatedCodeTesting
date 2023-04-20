using System;
using System.Windows.Forms;
using System.IO;

namespace Software_Engineering_Project
{
    public partial class FormAddSubmission : Form
    {
        public Submission submission { get; set; }
        private string codeFilepath;
        private string codeText;
        private string assignmentDirectory;
        private string submissionDirectory;

        private bool hasName => textBoxSubmissionName.Text != string.Empty;
        private bool hasFile => textBoxCodePreview.Text != string.Empty;
        private bool canSave => hasName && hasFile;

        public FormAddSubmission(string directory)
        {
            InitializeComponent();
            EmptyTextBoxes();

            submission = new Submission();
            assignmentDirectory = directory;
            submissionDirectory = CreateDirectory();
        }
        
        private void EmptyTextBoxes(){
            textBoxSubmissionName.Text = string.Empty;

            textBoxCodePreview.Text = string.Empty;

            labelFile.Text = string.Empty;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private string CreateDirectory(){
            string temp = Path.Combine(assignmentDirectory, "Submissions");
            Directory.CreateDirectory(temp);
            return temp;
        }

        private void WriteFile(){
            File.WriteAllText(codeFilepath, codeText);
        }

        /// <summary>
        /// Save Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddSubmission_Click(object sender, EventArgs e)
        {
            WriteFile();

            submission.StudentName = textBoxSubmissionName.Text;
            submission.FilePath = codeFilepath;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(dialog.FileName);

                codeText = new StreamReader(dialog.OpenFile()).ReadToEnd();

                codeFilepath = Path.Combine(submissionDirectory, info.Name);

                textBoxCodePreview.Text = codeText;
                buttonAddSubmission.Enabled = canSave;
            }
        }

        private void textBoxSubmissionName_TextChanged(object sender,EventArgs e)
        {
            buttonAddSubmission.Enabled = canSave;
        }
    }
}
