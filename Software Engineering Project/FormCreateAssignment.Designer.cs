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
            textBoxAssignmentName = new System.Windows.Forms.TextBox();
            ButtonSaveAssignment = new System.Windows.Forms.Button();
            labelAssignmentName = new System.Windows.Forms.Label();
            panelAssignmentForm = new System.Windows.Forms.Panel();
            labelOutputFilePath = new System.Windows.Forms.Label();
            labelInputFilePath = new System.Windows.Forms.Label();
            textBoxAssignmentPreview = new System.Windows.Forms.TextBox();
            labelAssignmentPreview = new System.Windows.Forms.Label();
            labelFilePath = new System.Windows.Forms.Label();
            buttonOutput = new System.Windows.Forms.Button();
            buttonInput = new System.Windows.Forms.Button();
            labelInput = new System.Windows.Forms.Label();
            labelOutput = new System.Windows.Forms.Label();
            PanelMainControls = new System.Windows.Forms.Panel();
            PanelExit = new System.Windows.Forms.Panel();
            buttonClose = new System.Windows.Forms.Button();
            panelAssignmentForm.SuspendLayout();
            PanelMainControls.SuspendLayout();
            PanelExit.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxAssignmentName
            // 
            textBoxAssignmentName.Location = new System.Drawing.Point(293, 35);
            textBoxAssignmentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxAssignmentName.Name = "textBoxAssignmentName";
            textBoxAssignmentName.Size = new System.Drawing.Size(352, 27);
            textBoxAssignmentName.TabIndex = 0;
            textBoxAssignmentName.Text = "AssignmentNameHere";
            // 
            // ButtonSaveAssignment
            // 
            ButtonSaveAssignment.Location = new System.Drawing.Point(432, 15);
            ButtonSaveAssignment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonSaveAssignment.Name = "ButtonSaveAssignment";
            ButtonSaveAssignment.Size = new System.Drawing.Size(178, 111);
            ButtonSaveAssignment.TabIndex = 4;
            ButtonSaveAssignment.Text = "Save Assignment";
            ButtonSaveAssignment.UseVisualStyleBackColor = true;
            ButtonSaveAssignment.Click += ButtonSaveAssignment_Click;
            // 
            // labelAssignmentName
            // 
            labelAssignmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAssignmentName.Image = Properties.Resources.icons8_grades_32;
            labelAssignmentName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelAssignmentName.Location = new System.Drawing.Point(3, 19);
            labelAssignmentName.Name = "labelAssignmentName";
            labelAssignmentName.Size = new System.Drawing.Size(284, 55);
            labelAssignmentName.TabIndex = 5;
            labelAssignmentName.Text = "Assignment Name:";
            labelAssignmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAssignmentForm
            // 
            panelAssignmentForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panelAssignmentForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelAssignmentForm.Controls.Add(labelOutputFilePath);
            panelAssignmentForm.Controls.Add(labelInputFilePath);
            panelAssignmentForm.Controls.Add(textBoxAssignmentPreview);
            panelAssignmentForm.Controls.Add(labelAssignmentPreview);
            panelAssignmentForm.Controls.Add(labelFilePath);
            panelAssignmentForm.Controls.Add(buttonOutput);
            panelAssignmentForm.Controls.Add(labelAssignmentName);
            panelAssignmentForm.Controls.Add(buttonInput);
            panelAssignmentForm.Controls.Add(labelInput);
            panelAssignmentForm.Controls.Add(labelOutput);
            panelAssignmentForm.Controls.Add(PanelMainControls);
            panelAssignmentForm.Controls.Add(textBoxAssignmentName);
            panelAssignmentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelAssignmentForm.Location = new System.Drawing.Point(0, 0);
            panelAssignmentForm.Margin = new System.Windows.Forms.Padding(5);
            panelAssignmentForm.Name = "panelAssignmentForm";
            panelAssignmentForm.Size = new System.Drawing.Size(658, 720);
            panelAssignmentForm.TabIndex = 11;
            // 
            // labelOutputFilePath
            // 
            labelOutputFilePath.AutoSize = true;
            labelOutputFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelOutputFilePath.Location = new System.Drawing.Point(44, 254);
            labelOutputFilePath.Name = "labelOutputFilePath";
            labelOutputFilePath.Size = new System.Drawing.Size(143, 28);
            labelOutputFilePath.TabIndex = 17;
            labelOutputFilePath.Text = "OutputFilePath";
            // 
            // labelInputFilePath
            // 
            labelInputFilePath.AutoSize = true;
            labelInputFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelInputFilePath.Location = new System.Drawing.Point(44, 171);
            labelInputFilePath.Name = "labelInputFilePath";
            labelInputFilePath.Size = new System.Drawing.Size(126, 28);
            labelInputFilePath.TabIndex = 16;
            labelInputFilePath.Text = "InputFilePath";
            // 
            // textBoxAssignmentPreview
            // 
            textBoxAssignmentPreview.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxAssignmentPreview.Location = new System.Drawing.Point(11, 330);
            textBoxAssignmentPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxAssignmentPreview.Multiline = true;
            textBoxAssignmentPreview.Name = "textBoxAssignmentPreview";
            textBoxAssignmentPreview.ReadOnly = true;
            textBoxAssignmentPreview.Size = new System.Drawing.Size(634, 238);
            textBoxAssignmentPreview.TabIndex = 15;
            textBoxAssignmentPreview.TextChanged += textBoxAssignmentPreview_TextChanged;
            // 
            // labelAssignmentPreview
            // 
            labelAssignmentPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelAssignmentPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelAssignmentPreview.Location = new System.Drawing.Point(3, 282);
            labelAssignmentPreview.Name = "labelAssignmentPreview";
            labelAssignmentPreview.Size = new System.Drawing.Size(373, 55);
            labelAssignmentPreview.TabIndex = 14;
            labelAssignmentPreview.Text = "Assignment Preview:";
            labelAssignmentPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFilePath.Location = new System.Drawing.Point(27, 74);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new System.Drawing.Size(618, 28);
            labelFilePath.TabIndex = 13;
            labelFilePath.Text = "{C:/User/MyDocuments/2021-CodingAssignments/AssignmentName}";
            // 
            // buttonOutput
            // 
            buttonOutput.Location = new System.Drawing.Point(293, 213);
            buttonOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonOutput.Name = "buttonOutput";
            buttonOutput.Size = new System.Drawing.Size(352, 31);
            buttonOutput.TabIndex = 10;
            buttonOutput.Text = "Output";
            buttonOutput.UseVisualStyleBackColor = true;
            buttonOutput.Click += buttonOutput_Click;
            // 
            // buttonInput
            // 
            buttonInput.Location = new System.Drawing.Point(293, 130);
            buttonInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new System.Drawing.Size(352, 31);
            buttonInput.TabIndex = 9;
            buttonInput.Text = "Input";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonInput_Click;
            // 
            // labelInput
            // 
            labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelInput.Location = new System.Drawing.Point(-1, 116);
            labelInput.Name = "labelInput";
            labelInput.Size = new System.Drawing.Size(288, 55);
            labelInput.TabIndex = 7;
            labelInput.Text = "Input:";
            labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOutput
            // 
            labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelOutput.Location = new System.Drawing.Point(1, 199);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new System.Drawing.Size(286, 55);
            labelOutput.TabIndex = 6;
            labelOutput.Text = "Output:";
            labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelMainControls
            // 
            PanelMainControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            PanelMainControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelMainControls.Controls.Add(PanelExit);
            PanelMainControls.Controls.Add(ButtonSaveAssignment);
            PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelMainControls.Location = new System.Drawing.Point(0, 577);
            PanelMainControls.Margin = new System.Windows.Forms.Padding(5);
            PanelMainControls.Name = "PanelMainControls";
            PanelMainControls.Size = new System.Drawing.Size(656, 141);
            PanelMainControls.TabIndex = 12;
            // 
            // PanelExit
            // 
            PanelExit.BackColor = System.Drawing.SystemColors.Info;
            PanelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelExit.Controls.Add(buttonClose);
            PanelExit.Dock = System.Windows.Forms.DockStyle.Left;
            PanelExit.Location = new System.Drawing.Point(0, 0);
            PanelExit.Margin = new System.Windows.Forms.Padding(5);
            PanelExit.Name = "PanelExit";
            PanelExit.Size = new System.Drawing.Size(318, 139);
            PanelExit.TabIndex = 11;
            // 
            // buttonClose
            // 
            buttonClose.Location = new System.Drawing.Point(38, 13);
            buttonClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(178, 111);
            buttonClose.TabIndex = 8;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            // 
            // FormCreateAssignment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(658, 720);
            Controls.Add(panelAssignmentForm);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FormCreateAssignment";
            Text = "Create Assignment";
            panelAssignmentForm.ResumeLayout(false);
            panelAssignmentForm.PerformLayout();
            PanelMainControls.ResumeLayout(false);
            PanelExit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAssignmentName;
        private System.Windows.Forms.Button ButtonSaveAssignment;
        private System.Windows.Forms.Label labelAssignmentName;
        private System.Windows.Forms.Panel panelAssignmentForm;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel PanelMainControls;
        private System.Windows.Forms.Panel PanelExit;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label labelAssignmentPreview;
        private System.Windows.Forms.TextBox textBoxAssignmentPreview;
        private System.Windows.Forms.Label labelOutputFilePath;
        private System.Windows.Forms.Label labelInputFilePath;
    }
}