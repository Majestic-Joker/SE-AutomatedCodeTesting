using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Reflection;
using System.Drawing.Text;
using System.IO;

namespace Software_Engineering_Project
{
    public partial class FormAddSubmissions : Form
    {
        public Submission submission { get; set; }
        private string filePath;
        private string assignmentDirectory;

        public FormAddSubmissions(string directory)
        {
            InitializeComponent();

            assignmentDirectory = directory;

            //FormClosing += FormAddSubmissions_FormClosing;
        }

        #region Exit buttons
        private void FormAddSubmissions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;//cancel close if user requested
            PropertyInfo pi = typeof(Form).GetProperty("CloseReason", BindingFlags.NonPublic | BindingFlags.Instance);
            pi.SetValue(this, CloseReason.None, null);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            //e.Cancel = true;//cancel close if user requested
            PropertyInfo pi = typeof(Form).GetProperty("CloseReason", BindingFlags.NonPublic | BindingFlags.Instance);
            pi.SetValue(this, CloseReason.None, null);
        }
        #endregion

        /// <summary>
        /// Save Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddSubmissions_Click(object sender, EventArgs e)
        {
            Submission temp = new Submission();
            temp.StudentName = textBoxSubmissionName.Text;
            temp.FilePath = filePath;
            submission = temp;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {

                FileInfo info = new FileInfo(dialog.FileName);

                var fileStream = dialog.OpenFile();
                var reader = new StreamReader(fileStream);
                string code = reader.ReadToEnd();
                string temp = Path.Combine(assignmentDirectory, "submissions");
                Directory.CreateDirectory(temp);
                temp = Path.Combine(temp, info.Name);
                File.WriteAllText(temp, code);
                filePath = temp;
            }
        }
    }
}
