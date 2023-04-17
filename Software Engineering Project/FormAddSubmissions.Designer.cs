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
            this.panelSubmissionsForm = new System.Windows.Forms.Panel();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.listBoxSubmissions = new System.Windows.Forms.ListBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.PanelSubmissionsControls = new System.Windows.Forms.Panel();
            this.PanelExit = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.ButtonAddSubmissions = new System.Windows.Forms.Button();
            this.textBoxSubmissionName = new System.Windows.Forms.TextBox();
            this.labelSubmissionsName = new System.Windows.Forms.Label();
            this.panelSubmissionsForm.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.PanelSubmissionsControls.SuspendLayout();
            this.PanelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubmissionsForm
            // 
            this.panelSubmissionsForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSubmissionsForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSubmissionsForm.Controls.Add(this.panelLabels);
            this.panelSubmissionsForm.Controls.Add(this.textBoxDescription);
            this.panelSubmissionsForm.Controls.Add(this.PanelSubmissionsControls);
            this.panelSubmissionsForm.Controls.Add(this.textBoxSubmissionName);
            this.panelSubmissionsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubmissionsForm.Location = new System.Drawing.Point(0, 0);
            this.panelSubmissionsForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelSubmissionsForm.Name = "panelSubmissionsForm";
            this.panelSubmissionsForm.Size = new System.Drawing.Size(536, 576);
            this.panelSubmissionsForm.TabIndex = 12;
            // 
            // panelLabels
            // 
            this.panelLabels.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLabels.Controls.Add(this.labelDescription);
            this.panelLabels.Controls.Add(this.listBoxSubmissions);
            this.panelLabels.Controls.Add(this.labelSubmissionsName);
            this.panelLabels.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLabels.Location = new System.Drawing.Point(0, 0);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(267, 461);
            this.panelLabels.TabIndex = 15;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDescription.Location = new System.Drawing.Point(2, 148);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(259, 44);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description:";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxSubmissions
            // 
            this.listBoxSubmissions.FormattingEnabled = true;
            this.listBoxSubmissions.ItemHeight = 16;
            this.listBoxSubmissions.Location = new System.Drawing.Point(10, 209);
            this.listBoxSubmissions.Name = "listBoxSubmissions";
            this.listBoxSubmissions.Size = new System.Drawing.Size(247, 244);
            this.listBoxSubmissions.TabIndex = 3;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(273, 163);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(258, 291);
            this.textBoxDescription.TabIndex = 13;
            // 
            // PanelSubmissionsControls
            // 
            this.PanelSubmissionsControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PanelSubmissionsControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSubmissionsControls.Controls.Add(this.PanelExit);
            this.PanelSubmissionsControls.Controls.Add(this.ButtonAddSubmissions);
            this.PanelSubmissionsControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSubmissionsControls.Location = new System.Drawing.Point(0, 461);
            this.PanelSubmissionsControls.Margin = new System.Windows.Forms.Padding(4);
            this.PanelSubmissionsControls.Name = "PanelSubmissionsControls";
            this.PanelSubmissionsControls.Size = new System.Drawing.Size(534, 113);
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
            this.PanelExit.Size = new System.Drawing.Size(266, 111);
            this.PanelExit.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(38, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(178, 89);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // ButtonAddSubmissions
            // 
            this.ButtonAddSubmissions.Location = new System.Drawing.Point(310, 12);
            this.ButtonAddSubmissions.Name = "ButtonAddSubmissions";
            this.ButtonAddSubmissions.Size = new System.Drawing.Size(178, 89);
            this.ButtonAddSubmissions.TabIndex = 4;
            this.ButtonAddSubmissions.Text = "Save Assignment";
            this.ButtonAddSubmissions.UseVisualStyleBackColor = true;
            // 
            // textBoxSubmissionName
            // 
            this.textBoxSubmissionName.Location = new System.Drawing.Point(273, 29);
            this.textBoxSubmissionName.Name = "textBoxSubmissionName";
            this.textBoxSubmissionName.Size = new System.Drawing.Size(258, 22);
            this.textBoxSubmissionName.TabIndex = 0;
            // 
            // labelSubmissionsName
            // 
            this.labelSubmissionsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubmissionsName.Image = global::Software_Engineering_Project.Properties.Resources.icons8_grades_32;
            this.labelSubmissionsName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSubmissionsName.Location = new System.Drawing.Point(3, 14);
            this.labelSubmissionsName.Name = "labelSubmissionsName";
            this.labelSubmissionsName.Size = new System.Drawing.Size(259, 44);
            this.labelSubmissionsName.TabIndex = 5;
            this.labelSubmissionsName.Text = "Submissions Name:";
            this.labelSubmissionsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddSubmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 576);
            this.Controls.Add(this.panelSubmissionsForm);
            this.Name = "FormAddSubmissions";
            this.Text = "Add Submissions";
            this.panelSubmissionsForm.ResumeLayout(false);
            this.panelSubmissionsForm.PerformLayout();
            this.panelLabels.ResumeLayout(false);
            this.PanelSubmissionsControls.ResumeLayout(false);
            this.PanelExit.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}