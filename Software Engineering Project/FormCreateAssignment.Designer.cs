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
            textBoxRequiredInput = new System.Windows.Forms.TextBox();
            textBoxExpectedOutput = new System.Windows.Forms.TextBox();
            listBoxAssignments = new System.Windows.Forms.ListBox();
            ButtonSaveAssignment = new System.Windows.Forms.Button();
            labelAssignmentName = new System.Windows.Forms.Label();
            panelAssignmentForm = new System.Windows.Forms.Panel();
            panelLabels = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            labelInput = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            PanelMainControls = new System.Windows.Forms.Panel();
            PanelExit = new System.Windows.Forms.Panel();
            buttonClose = new System.Windows.Forms.Button();
            panelAssignmentForm.SuspendLayout();
            panelLabels.SuspendLayout();
            PanelMainControls.SuspendLayout();
            PanelExit.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxAssignmentName
            // 
            textBoxAssignmentName.Location = new System.Drawing.Point(387, 35);
            textBoxAssignmentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxAssignmentName.Name = "textBoxAssignmentName";
            textBoxAssignmentName.Size = new System.Drawing.Size(258, 27);
            textBoxAssignmentName.TabIndex = 0;
            // 
            // textBoxRequiredInput
            // 
            textBoxRequiredInput.Location = new System.Drawing.Point(387, 80);
            textBoxRequiredInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxRequiredInput.Multiline = true;
            textBoxRequiredInput.Name = "textBoxRequiredInput";
            textBoxRequiredInput.Size = new System.Drawing.Size(258, 48);
            textBoxRequiredInput.TabIndex = 1;
            // 
            // textBoxExpectedOutput
            // 
            textBoxExpectedOutput.Location = new System.Drawing.Point(387, 136);
            textBoxExpectedOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxExpectedOutput.Multiline = true;
            textBoxExpectedOutput.Name = "textBoxExpectedOutput";
            textBoxExpectedOutput.Size = new System.Drawing.Size(258, 49);
            textBoxExpectedOutput.TabIndex = 2;
            // 
            // listBoxAssignments
            // 
            listBoxAssignments.FormattingEnabled = true;
            listBoxAssignments.ItemHeight = 20;
            listBoxAssignments.Location = new System.Drawing.Point(10, 261);
            listBoxAssignments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            listBoxAssignments.Name = "listBoxAssignments";
            listBoxAssignments.Size = new System.Drawing.Size(366, 304);
            listBoxAssignments.TabIndex = 3;
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
            labelAssignmentName.Location = new System.Drawing.Point(3, 18);
            labelAssignmentName.Name = "labelAssignmentName";
            labelAssignmentName.Size = new System.Drawing.Size(373, 55);
            labelAssignmentName.TabIndex = 5;
            labelAssignmentName.Text = "Assignment Name:";
            labelAssignmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAssignmentForm
            // 
            panelAssignmentForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panelAssignmentForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelAssignmentForm.Controls.Add(panelLabels);
            panelAssignmentForm.Controls.Add(textBoxDescription);
            panelAssignmentForm.Controls.Add(PanelMainControls);
            panelAssignmentForm.Controls.Add(textBoxAssignmentName);
            panelAssignmentForm.Controls.Add(textBoxRequiredInput);
            panelAssignmentForm.Controls.Add(textBoxExpectedOutput);
            panelAssignmentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelAssignmentForm.Location = new System.Drawing.Point(0, 0);
            panelAssignmentForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panelAssignmentForm.Name = "panelAssignmentForm";
            panelAssignmentForm.Size = new System.Drawing.Size(658, 720);
            panelAssignmentForm.TabIndex = 11;
            // 
            // panelLabels
            // 
            panelLabels.BackColor = System.Drawing.SystemColors.MenuBar;
            panelLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelLabels.Controls.Add(label3);
            panelLabels.Controls.Add(labelInput);
            panelLabels.Controls.Add(label1);
            panelLabels.Controls.Add(listBoxAssignments);
            panelLabels.Controls.Add(labelAssignmentName);
            panelLabels.Dock = System.Windows.Forms.DockStyle.Left;
            panelLabels.Location = new System.Drawing.Point(0, 0);
            panelLabels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelLabels.Name = "panelLabels";
            panelLabels.Size = new System.Drawing.Size(381, 577);
            panelLabels.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label3.Location = new System.Drawing.Point(2, 185);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(374, 55);
            label3.TabIndex = 8;
            label3.Text = "Description:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInput
            // 
            labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelInput.Location = new System.Drawing.Point(3, 72);
            labelInput.Name = "labelInput";
            labelInput.Size = new System.Drawing.Size(373, 55);
            labelInput.TabIndex = 7;
            labelInput.Text = "Input:";
            labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label1.Location = new System.Drawing.Point(3, 128);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(373, 55);
            label1.TabIndex = 6;
            label1.Text = "Output:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new System.Drawing.Point(387, 205);
            textBoxDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(258, 363);
            textBoxDescription.TabIndex = 13;
            // 
            // PanelMainControls
            // 
            PanelMainControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            PanelMainControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelMainControls.Controls.Add(PanelExit);
            PanelMainControls.Controls.Add(ButtonSaveAssignment);
            PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelMainControls.Location = new System.Drawing.Point(0, 577);
            PanelMainControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            PanelExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            PanelExit.Name = "PanelExit";
            PanelExit.Size = new System.Drawing.Size(380, 139);
            PanelExit.TabIndex = 11;
            // 
            // buttonClose
            // 
            buttonClose.Location = new System.Drawing.Point(38, 14);
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
            panelLabels.ResumeLayout(false);
            PanelMainControls.ResumeLayout(false);
            PanelExit.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAssignmentName;
        private System.Windows.Forms.TextBox textBoxRequiredInput;
        private System.Windows.Forms.TextBox textBoxExpectedOutput;
        private System.Windows.Forms.ListBox listBoxAssignments;
        private System.Windows.Forms.Button ButtonSaveAssignment;
        private System.Windows.Forms.Label labelAssignmentName;
        private System.Windows.Forms.Panel panelAssignmentForm;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel PanelMainControls;
        private System.Windows.Forms.Panel PanelExit;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label label1;
    }
}