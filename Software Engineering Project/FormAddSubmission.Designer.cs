namespace Software_Engineering_Project
{
    partial class FormAddSubmissions
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
            panelSubmissionsForm = new System.Windows.Forms.Panel();
            labelFile = new System.Windows.Forms.Label();
            buttonOpenFile = new System.Windows.Forms.Button();
            panelLabels = new System.Windows.Forms.Panel();
            labelDescription = new System.Windows.Forms.Label();
            listBoxSubmissions = new System.Windows.Forms.ListBox();
            labelSubmissionsName = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            PanelSubmissionsControls = new System.Windows.Forms.Panel();
            PanelExit = new System.Windows.Forms.Panel();
            buttonClose = new System.Windows.Forms.Button();
            ButtonAddSubmissions = new System.Windows.Forms.Button();
            textBoxSubmissionName = new System.Windows.Forms.TextBox();
            panelSubmissionsForm.SuspendLayout();
            panelLabels.SuspendLayout();
            PanelSubmissionsControls.SuspendLayout();
            PanelExit.SuspendLayout();
            SuspendLayout();
            // 
            // panelSubmissionsForm
            // 
            panelSubmissionsForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panelSubmissionsForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSubmissionsForm.Controls.Add(labelFile);
            panelSubmissionsForm.Controls.Add(buttonOpenFile);
            panelSubmissionsForm.Controls.Add(panelLabels);
            panelSubmissionsForm.Controls.Add(textBoxDescription);
            panelSubmissionsForm.Controls.Add(PanelSubmissionsControls);
            panelSubmissionsForm.Controls.Add(textBoxSubmissionName);
            panelSubmissionsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelSubmissionsForm.Location = new System.Drawing.Point(0, 0);
            panelSubmissionsForm.Margin = new System.Windows.Forms.Padding(4);
            panelSubmissionsForm.Name = "panelSubmissionsForm";
            panelSubmissionsForm.Size = new System.Drawing.Size(469, 540);
            panelSubmissionsForm.TabIndex = 12;
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Location = new System.Drawing.Point(257, 88);
            labelFile.Name = "labelFile";
            labelFile.Size = new System.Drawing.Size(38, 15);
            labelFile.TabIndex = 17;
            labelFile.Text = "label1";
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new System.Drawing.Point(381, 83);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            buttonOpenFile.TabIndex = 16;
            buttonOpenFile.Text = "button1";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // panelLabels
            // 
            panelLabels.BackColor = System.Drawing.SystemColors.MenuBar;
            panelLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelLabels.Controls.Add(labelDescription);
            panelLabels.Controls.Add(listBoxSubmissions);
            panelLabels.Controls.Add(labelSubmissionsName);
            panelLabels.Dock = System.Windows.Forms.DockStyle.Left;
            panelLabels.Location = new System.Drawing.Point(0, 0);
            panelLabels.Name = "panelLabels";
            panelLabels.Size = new System.Drawing.Size(234, 432);
            panelLabels.TabIndex = 15;
            // 
            // labelDescription
            // 
            labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelDescription.Location = new System.Drawing.Point(2, 139);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(227, 41);
            labelDescription.TabIndex = 8;
            labelDescription.Text = "Description:";
            labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxSubmissions
            // 
            listBoxSubmissions.FormattingEnabled = true;
            listBoxSubmissions.ItemHeight = 15;
            listBoxSubmissions.Location = new System.Drawing.Point(9, 196);
            listBoxSubmissions.Name = "listBoxSubmissions";
            listBoxSubmissions.Size = new System.Drawing.Size(217, 229);
            listBoxSubmissions.TabIndex = 3;
            // 
            // labelSubmissionsName
            // 
            labelSubmissionsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelSubmissionsName.Image = Properties.Resources.icons8_grades_32;
            labelSubmissionsName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelSubmissionsName.Location = new System.Drawing.Point(3, 13);
            labelSubmissionsName.Name = "labelSubmissionsName";
            labelSubmissionsName.Size = new System.Drawing.Size(227, 41);
            labelSubmissionsName.TabIndex = 5;
            labelSubmissionsName.Text = "Submissions Name:";
            labelSubmissionsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(239, 153);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(226, 273);
            textBoxDescription.TabIndex = 13;
            // 
            // PanelSubmissionsControls
            // 
            PanelSubmissionsControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            PanelSubmissionsControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelSubmissionsControls.Controls.Add(PanelExit);
            PanelSubmissionsControls.Controls.Add(ButtonAddSubmissions);
            PanelSubmissionsControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelSubmissionsControls.Location = new System.Drawing.Point(0, 432);
            PanelSubmissionsControls.Margin = new System.Windows.Forms.Padding(4);
            PanelSubmissionsControls.Name = "PanelSubmissionsControls";
            PanelSubmissionsControls.Size = new System.Drawing.Size(467, 106);
            PanelSubmissionsControls.TabIndex = 12;
            // 
            // PanelExit
            // 
            PanelExit.BackColor = System.Drawing.SystemColors.Info;
            PanelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelExit.Controls.Add(buttonClose);
            PanelExit.Dock = System.Windows.Forms.DockStyle.Left;
            PanelExit.Location = new System.Drawing.Point(0, 0);
            PanelExit.Margin = new System.Windows.Forms.Padding(4);
            PanelExit.Name = "PanelExit";
            PanelExit.Size = new System.Drawing.Size(233, 104);
            PanelExit.TabIndex = 11;
            // 
            // buttonClose
            // 
            buttonClose.Location = new System.Drawing.Point(33, 10);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(156, 83);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // ButtonAddSubmissions
            // 
            ButtonAddSubmissions.Location = new System.Drawing.Point(271, 11);
            ButtonAddSubmissions.Name = "ButtonAddSubmissions";
            ButtonAddSubmissions.Size = new System.Drawing.Size(156, 83);
            ButtonAddSubmissions.TabIndex = 4;
            ButtonAddSubmissions.Text = "Save Submissions";
            ButtonAddSubmissions.UseVisualStyleBackColor = true;
            ButtonAddSubmissions.Click += ButtonAddSubmissions_Click;
            // 
            // textBoxSubmissionName
            // 
            textBoxSubmissionName.Location = new System.Drawing.Point(239, 27);
            textBoxSubmissionName.Name = "textBoxSubmissionName";
            textBoxSubmissionName.Size = new System.Drawing.Size(226, 23);
            textBoxSubmissionName.TabIndex = 0;
            // 
            // FormAddSubmissions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(469, 540);
            Controls.Add(panelSubmissionsForm);
            Name = "FormAddSubmissions";
            Text = "Add Submissions";
            panelSubmissionsForm.ResumeLayout(false);
            panelSubmissionsForm.PerformLayout();
            panelLabels.ResumeLayout(false);
            PanelSubmissionsControls.ResumeLayout(false);
            PanelExit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSubmissionsForm;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.ListBox listBoxSubmissions;
        private System.Windows.Forms.Label labelSubmissionsName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Panel PanelSubmissionsControls;
        private System.Windows.Forms.Panel PanelExit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button ButtonAddSubmissions;
        private System.Windows.Forms.TextBox textBoxSubmissionName;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}