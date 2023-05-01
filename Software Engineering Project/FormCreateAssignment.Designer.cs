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
            this.Nud_MatchReqSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOutputFilePath = new System.Windows.Forms.Label();
            this.labelInputFilePath = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.PanelMainControls = new System.Windows.Forms.Panel();
            this.PanelExit = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelAssignmentForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_MatchReqSelector)).BeginInit();
            this.PanelMainControls.SuspendLayout();
            this.PanelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAssignmentName
            // 
            this.textBoxAssignmentName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAssignmentName.Location = new System.Drawing.Point(197, 19);
            this.textBoxAssignmentName.Name = "textBoxAssignmentName";
            this.textBoxAssignmentName.PlaceholderText = "Enter a name for this assignment";
            this.textBoxAssignmentName.Size = new System.Drawing.Size(259, 26);
            this.textBoxAssignmentName.TabIndex = 0;
            this.textBoxAssignmentName.TextChanged += new System.EventHandler(this.textBoxAssignmentName_TextChanged);
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
            this.panelAssignmentForm.Controls.Add(this.Nud_MatchReqSelector);
            this.panelAssignmentForm.Controls.Add(this.label1);
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
            // Nud_MatchReqSelector
            // 
            this.Nud_MatchReqSelector.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nud_MatchReqSelector.Location = new System.Drawing.Point(308, 193);
            this.Nud_MatchReqSelector.Name = "Nud_MatchReqSelector";
            this.Nud_MatchReqSelector.Size = new System.Drawing.Size(120, 26);
            this.Nud_MatchReqSelector.TabIndex = 20;
            this.Nud_MatchReqSelector.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.Nud_MatchReqSelector.ValueChanged += new System.EventHandler(this.Nud_MatchReqSelector_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Output Match Requirement:";
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
            this.buttonOutput.Location = new System.Drawing.Point(272, 139);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(156, 31);
            this.buttonOutput.TabIndex = 10;
            this.buttonOutput.Text = "Select Output File";
            this.buttonOutput.UseVisualStyleBackColor = true;
            // 
            // buttonInput
            // 
            this.buttonInput.Enabled = false;
            this.buttonInput.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInput.Location = new System.Drawing.Point(35, 139);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(156, 31);
            this.buttonInput.TabIndex = 9;
            this.buttonInput.Text = "Select Input File";
            this.buttonInput.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.Nud_MatchReqSelector)).EndInit();
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
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.NumericUpDown Nud_MatchReqSelector;
        private System.Windows.Forms.Label label1;
    }
}