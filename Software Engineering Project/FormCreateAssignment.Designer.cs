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
            this.textBoxRequiredInput = new System.Windows.Forms.TextBox();
            this.textBoxExpectedOutput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonSaveAssignment = new System.Windows.Forms.Button();
            this.labelAssignmentName = new System.Windows.Forms.Label();
            this.labelRequiredInput = new System.Windows.Forms.Label();
            this.labelExpectedOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAssignmentName
            // 
            this.textBoxAssignmentName.Location = new System.Drawing.Point(166, 63);
            this.textBoxAssignmentName.Name = "textBoxAssignmentName";
            this.textBoxAssignmentName.Size = new System.Drawing.Size(100, 22);
            this.textBoxAssignmentName.TabIndex = 0;
            // 
            // textBoxRequiredInput
            // 
            this.textBoxRequiredInput.Location = new System.Drawing.Point(166, 108);
            this.textBoxRequiredInput.Name = "textBoxRequiredInput";
            this.textBoxRequiredInput.Size = new System.Drawing.Size(100, 22);
            this.textBoxRequiredInput.TabIndex = 1;
            // 
            // textBoxExpectedOutput
            // 
            this.textBoxExpectedOutput.Location = new System.Drawing.Point(166, 152);
            this.textBoxExpectedOutput.Name = "textBoxExpectedOutput";
            this.textBoxExpectedOutput.Size = new System.Drawing.Size(100, 22);
            this.textBoxExpectedOutput.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(43, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 164);
            this.listBox1.TabIndex = 3;
            // 
            // ButtonSaveAssignment
            // 
            this.ButtonSaveAssignment.Location = new System.Drawing.Point(190, 399);
            this.ButtonSaveAssignment.Name = "ButtonSaveAssignment";
            this.ButtonSaveAssignment.Size = new System.Drawing.Size(75, 23);
            this.ButtonSaveAssignment.TabIndex = 4;
            this.ButtonSaveAssignment.Text = "Save Assignment";
            this.ButtonSaveAssignment.UseVisualStyleBackColor = true;
            this.ButtonSaveAssignment.Click += new System.EventHandler(this.ButtonSaveAssignment_Click);
            // 
            // labelAssignmentName
            // 
            this.labelAssignmentName.AutoSize = true;
            this.labelAssignmentName.Location = new System.Drawing.Point(43, 63);
            this.labelAssignmentName.Name = "labelAssignmentName";
            this.labelAssignmentName.Size = new System.Drawing.Size(117, 16);
            this.labelAssignmentName.TabIndex = 5;
            this.labelAssignmentName.Text = "Assignment Name";
            // 
            // labelRequiredInput
            // 
            this.labelRequiredInput.AutoSize = true;
            this.labelRequiredInput.Location = new System.Drawing.Point(122, 108);
            this.labelRequiredInput.Name = "labelRequiredInput";
            this.labelRequiredInput.Size = new System.Drawing.Size(38, 16);
            this.labelRequiredInput.TabIndex = 6;
            this.labelRequiredInput.Text = "Input:";
            // 
            // labelExpectedOutput
            // 
            this.labelExpectedOutput.AutoSize = true;
            this.labelExpectedOutput.Location = new System.Drawing.Point(116, 155);
            this.labelExpectedOutput.Name = "labelExpectedOutput";
            this.labelExpectedOutput.Size = new System.Drawing.Size(48, 16);
            this.labelExpectedOutput.TabIndex = 7;
            this.labelExpectedOutput.Text = "Output:";
            // 
            // FormCreateAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.labelExpectedOutput);
            this.Controls.Add(this.labelRequiredInput);
            this.Controls.Add(this.labelAssignmentName);
            this.Controls.Add(this.ButtonSaveAssignment);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxExpectedOutput);
            this.Controls.Add(this.textBoxRequiredInput);
            this.Controls.Add(this.textBoxAssignmentName);
            this.Name = "FormCreateAssignment";
            this.Text = "Create Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAssignmentName;
        private System.Windows.Forms.TextBox textBoxRequiredInput;
        private System.Windows.Forms.TextBox textBoxExpectedOutput;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ButtonSaveAssignment;
        private System.Windows.Forms.Label labelAssignmentName;
        private System.Windows.Forms.Label labelRequiredInput;
        private System.Windows.Forms.Label labelExpectedOutput;
    }
}