namespace Software_Engineering_Project
{
    partial class FormAddSubmission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSubmissionsForm = new System.Windows.Forms.Panel();
            this.labelFile = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelCodePreview = new System.Windows.Forms.Label();
            this.labelSubmissionsName = new System.Windows.Forms.Label();
            this.textBoxCodePreview = new System.Windows.Forms.TextBox();
            this.PanelSubmissionsControls = new System.Windows.Forms.Panel();
            this.PanelExit = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddSubmission = new System.Windows.Forms.Button();
            this.textBoxSubmissionName = new System.Windows.Forms.TextBox();
            this.panelSubmissionsForm.SuspendLayout();
            this.PanelSubmissionsControls.SuspendLayout();
            this.PanelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubmissionsForm
            // 
            this.panelSubmissionsForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSubmissionsForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmissionsForm.Controls.Add(this.labelCodePreview);
            this.panelSubmissionsForm.Controls.Add(this.labelFile);
            this.panelSubmissionsForm.Controls.Add(this.buttonOpenFile);
            this.panelSubmissionsForm.Controls.Add(this.labelSubmissionsName);
            this.panelSubmissionsForm.Controls.Add(this.textBoxCodePreview);
            this.panelSubmissionsForm.Controls.Add(this.PanelSubmissionsControls);
            this.panelSubmissionsForm.Controls.Add(this.textBoxSubmissionName);
            this.panelSubmissionsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubmissionsForm.Location = new System.Drawing.Point(0, 0);
            this.panelSubmissionsForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelSubmissionsForm.Name = "panelSubmissionsForm";
            this.panelSubmissionsForm.Size = new System.Drawing.Size(469, 540);
            this.panelSubmissionsForm.TabIndex = 12;
            // 
            // labelFile
            // 
            this.labelFile.AutoEllipsis = true;
            this.labelFile.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFile.Location = new System.Drawing.Point(11, 65);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(445, 27);
            this.labelFile.TabIndex = 17;
            this.labelFile.Text = "{C:/User/MyDocuments/2021-CodingAssignments/Assignment1/Code/codefile.txt}";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOpenFile.Location = new System.Drawing.Point(11, 95);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(107, 31);
            this.buttonOpenFile.TabIndex = 16;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // labelCodePreview
            // 
            this.labelCodePreview.BackColor = System.Drawing.Color.Transparent;
            this.labelCodePreview.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCodePreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCodePreview.Location = new System.Drawing.Point(11, 129);
            this.labelCodePreview.Name = "labelCodePreview";
            this.labelCodePreview.Size = new System.Drawing.Size(107, 21);
            this.labelCodePreview.TabIndex = 8;
            this.labelCodePreview.Text = "CodePreview:";
            this.labelCodePreview.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labelSubmissionsName
            // 
            this.labelSubmissionsName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubmissionsName.Image = global::Software_Engineering_Project.Properties.Resources.icons8_grades_32;
            this.labelSubmissionsName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubmissionsName.Location = new System.Drawing.Point(11, 8);
            this.labelSubmissionsName.Name = "labelSubmissionsName";
            this.labelSubmissionsName.Size = new System.Drawing.Size(172, 47);
            this.labelSubmissionsName.TabIndex = 5;
            this.labelSubmissionsName.Text = "Submission Name:";
            this.labelSubmissionsName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCodePreview
            // 
            this.textBoxCodePreview.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCodePreview.Location = new System.Drawing.Point(11, 153);
            this.textBoxCodePreview.Multiline = true;
            this.textBoxCodePreview.Name = "textBoxCodePreview";
            this.textBoxCodePreview.Size = new System.Drawing.Size(445, 273);
            this.textBoxCodePreview.TabIndex = 13;
            this.textBoxCodePreview.Text = "{Code from the opened file is printed here. Lorem ipsum, la dee da dee da}";
            // 
            // PanelSubmissionsControls
            // 
            this.PanelSubmissionsControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PanelSubmissionsControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSubmissionsControls.Controls.Add(this.PanelExit);
            this.PanelSubmissionsControls.Controls.Add(this.buttonAddSubmission);
            this.PanelSubmissionsControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSubmissionsControls.Location = new System.Drawing.Point(0, 432);
            this.PanelSubmissionsControls.Margin = new System.Windows.Forms.Padding(4);
            this.PanelSubmissionsControls.Name = "PanelSubmissionsControls";
            this.PanelSubmissionsControls.Size = new System.Drawing.Size(467, 106);
            this.PanelSubmissionsControls.TabIndex = 12;
            // 
            // PanelExit
            // 
            this.PanelExit.BackColor = System.Drawing.SystemColors.Info;
            this.PanelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelExit.Controls.Add(this.buttonClose);
            this.PanelExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelExit.Location = new System.Drawing.Point(0, 0);
            this.PanelExit.Margin = new System.Windows.Forms.Padding(4);
            this.PanelExit.Name = "PanelExit";
            this.PanelExit.Size = new System.Drawing.Size(233, 104);
            this.PanelExit.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.Location = new System.Drawing.Point(33, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(156, 83);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // buttonAddSubmission
            // 
            this.buttonAddSubmission.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSubmission.Location = new System.Drawing.Point(271, 11);
            this.buttonAddSubmission.Name = "buttonAddSubmission";
            this.buttonAddSubmission.Size = new System.Drawing.Size(156, 83);
            this.buttonAddSubmission.TabIndex = 4;
            this.buttonAddSubmission.Text = "Save Submission";
            this.buttonAddSubmission.UseVisualStyleBackColor = true;
            this.buttonAddSubmission.Click += new System.EventHandler(this.ButtonAddSubmission_Click);
            // 
            // textBoxSubmissionName
            // 
            this.textBoxSubmissionName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubmissionName.Location = new System.Drawing.Point(189, 19);
            this.textBoxSubmissionName.Name = "textBoxSubmissionName";
            this.textBoxSubmissionName.Size = new System.Drawing.Size(267, 26);
            this.textBoxSubmissionName.TabIndex = 0;
            this.textBoxSubmissionName.Text = "{CodeSubmissionName}";
            // 
            // FormAddSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 540);
            this.Controls.Add(this.panelSubmissionsForm);
            this.Name = "FormAddSubmission";
            this.Text = "Add Submission";
            this.panelSubmissionsForm.ResumeLayout(false);
            this.panelSubmissionsForm.PerformLayout();
            this.PanelSubmissionsControls.ResumeLayout(false);
            this.PanelExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSubmissionsForm;
        private System.Windows.Forms.Label labelCodePreview;
        private System.Windows.Forms.Label labelSubmissionsName;
        private System.Windows.Forms.TextBox textBoxCodePreview;
        private System.Windows.Forms.Panel PanelSubmissionsControls;
        private System.Windows.Forms.Panel PanelExit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddSubmission;
        private System.Windows.Forms.TextBox textBoxSubmissionName;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}