namespace Software_Engineering_Project
{
    partial class FormCreateAssignment
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
            this.textBoxAssignmentName = new System.Windows.Forms.TextBox();
            this.ButtonSaveAssignment = new System.Windows.Forms.Button();
            this.labelAssignmentName = new System.Windows.Forms.Label();
            this.panelAssignmentForm = new System.Windows.Forms.Panel();
            this.labelOutputFilePath = new System.Windows.Forms.Label();
            this.labelInputFilePath = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.PanelMainControls = new System.Windows.Forms.Panel();
            this.PanelExit = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelAssignmentForm.SuspendLayout();
            this.PanelMainControls.SuspendLayout();
            this.PanelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAssignmentName
            // 
            this.textBoxAssignmentName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAssignmentName.Location = new System.Drawing.Point(197, 19);
            this.textBoxAssignmentName.Name = "textBoxAssignmentName";
            this.textBoxAssignmentName.Size = new System.Drawing.Size(259, 26);
            this.textBoxAssignmentName.TabIndex = 0;
            this.textBoxAssignmentName.Text = "{Assignment Name}";
            // 
            // ButtonSaveAssignment
            // 
            this.ButtonSaveAssignment.Enabled = false;
            this.ButtonSaveAssignment.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSaveAssignment.Location = new System.Drawing.Point(271, 11);
            this.ButtonSaveAssignment.Name = "ButtonSaveAssignment";
            this.ButtonSaveAssignment.Size = new System.Drawing.Size(156, 83);
            this.ButtonSaveAssignment.TabIndex = 4;
            this.ButtonSaveAssignment.Text = "Save Assignment";
            this.ButtonSaveAssignment.UseVisualStyleBackColor = true;
            // 
            // labelAssignmentName
            // 
            this.labelAssignmentName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAssignmentName.Image = global::Software_Engineering_Project.Properties.Resources.icons8_grades_32;
            this.labelAssignmentName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAssignmentName.Location = new System.Drawing.Point(9, 8);
            this.labelAssignmentName.Name = "labelAssignmentName";
            this.labelAssignmentName.Size = new System.Drawing.Size(182, 47);
            this.labelAssignmentName.TabIndex = 5;
            this.labelAssignmentName.Text = "Assignment Name:";
            this.labelAssignmentName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelAssignmentForm
            // 
            this.panelAssignmentForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAssignmentForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAssignmentForm.Controls.Add(this.textBox1);
            this.panelAssignmentForm.Controls.Add(this.labelOutputFilePath);
            this.panelAssignmentForm.Controls.Add(this.labelInputFilePath);
            this.panelAssignmentForm.Controls.Add(this.buttonOutput);
            this.panelAssignmentForm.Controls.Add(this.labelAssignmentName);
            this.panelAssignmentForm.Controls.Add(this.buttonInput);
            this.panelAssignmentForm.Controls.Add(this.labelInput);
            this.panelAssignmentForm.Controls.Add(this.labelOutput);
            this.panelAssignmentForm.Controls.Add(this.PanelMainControls);
            this.panelAssignmentForm.Controls.Add(this.textBoxAssignmentName);
            this.panelAssignmentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssignmentForm.Location = new System.Drawing.Point(0, 0);
            this.panelAssignmentForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelAssignmentForm.Name = "panelAssignmentForm";
            this.panelAssignmentForm.Size = new System.Drawing.Size(469, 355);
            this.panelAssignmentForm.TabIndex = 11;
            // 
            // labelOutputFilePath
            // 
            this.labelOutputFilePath.AutoEllipsis = true;
            this.labelOutputFilePath.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutputFilePath.Location = new System.Drawing.Point(79, 94);
            this.labelOutputFilePath.Name = "labelOutputFilePath";
            this.labelOutputFilePath.Size = new System.Drawing.Size(375, 18);
            this.labelOutputFilePath.TabIndex = 17;
            this.labelOutputFilePath.Text = "No file selected";
            // 
            // labelInputFilePath
            // 
            this.labelInputFilePath.AutoEllipsis = true;
            this.labelInputFilePath.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInputFilePath.Location = new System.Drawing.Point(79, 64);
            this.labelInputFilePath.Name = "labelInputFilePath";
            this.labelInputFilePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelInputFilePath.Size = new System.Drawing.Size(375, 18);
            this.labelInputFilePath.TabIndex = 16;
            this.labelInputFilePath.Text = "No file selected";
            this.labelInputFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOutput.Location = new System.Drawing.Point(272, 126);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(156, 31);
            this.buttonOutput.TabIndex = 10;
            this.buttonOutput.Text = "Select Output File";
            this.buttonOutput.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInput.Location = new System.Drawing.Point(35, 126);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(156, 31);
            this.buttonInput.TabIndex = 9;
            this.buttonInput.Text = "Select Input File";
            this.buttonInput.UseVisualStyleBackColor = true;
            // 
            // PanelMainControls
            // 
            this.PanelMainControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PanelMainControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMainControls.Controls.Add(this.PanelExit);
            this.PanelMainControls.Controls.Add(this.ButtonSaveAssignment);
            this.PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMainControls.Location = new System.Drawing.Point(0, 247);
            this.PanelMainControls.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMainControls.Name = "PanelMainControls";
            this.PanelMainControls.Size = new System.Drawing.Size(467, 106);
            this.PanelMainControls.TabIndex = 12;
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
            this.PanelExit.Size = new System.Drawing.Size(232, 104);
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
            // labelOutput
            // 
            this.labelOutput.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOutput.Location = new System.Drawing.Point(9, 94);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(64, 18);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Output:";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInput
            // 
            this.labelInput.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInput.Location = new System.Drawing.Point(11, 64);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(54, 18);
            this.labelInput.TabIndex = 7;
            this.labelInput.Text = "Input:";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 18;
            // 
            // FormCreateAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 355);
            this.Controls.Add(this.panelAssignmentForm);
            this.Name = "FormCreateAssignment";
            this.Text = "Create Assignment";
            this.panelAssignmentForm.ResumeLayout(false);
            this.panelAssignmentForm.PerformLayout();
            this.PanelMainControls.ResumeLayout(false);
            this.PanelExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAssignmentName;
        private System.Windows.Forms.Button ButtonSaveAssignment;
        private System.Windows.Forms.Label labelAssignmentName;
        private System.Windows.Forms.Panel panelAssignmentForm;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel PanelMainControls;
        private System.Windows.Forms.Panel PanelExit;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Label labelOutputFilePath;
        private System.Windows.Forms.Label labelInputFilePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
    }
}