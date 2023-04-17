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
            this.listBoxAssignments = new System.Windows.Forms.ListBox();
            this.ButtonSaveAssignment = new System.Windows.Forms.Button();
            this.labelAssignmentName = new System.Windows.Forms.Label();
            this.panelAssignmentForm = new System.Windows.Forms.Panel();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.PanelMainControls = new System.Windows.Forms.Panel();
            this.PanelExit = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAssignmentForm.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.PanelMainControls.SuspendLayout();
            this.PanelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAssignmentName
            // 
            this.textBoxAssignmentName.Location = new System.Drawing.Point(273, 29);
            this.textBoxAssignmentName.Name = "textBoxAssignmentName";
            this.textBoxAssignmentName.Size = new System.Drawing.Size(258, 22);
            this.textBoxAssignmentName.TabIndex = 0;
            // 
            // textBoxRequiredInput
            // 
            this.textBoxRequiredInput.Location = new System.Drawing.Point(273, 64);
            this.textBoxRequiredInput.Multiline = true;
            this.textBoxRequiredInput.Name = "textBoxRequiredInput";
            this.textBoxRequiredInput.Size = new System.Drawing.Size(258, 39);
            this.textBoxRequiredInput.TabIndex = 1;
            // 
            // textBoxExpectedOutput
            // 
            this.textBoxExpectedOutput.Location = new System.Drawing.Point(273, 109);
            this.textBoxExpectedOutput.Multiline = true;
            this.textBoxExpectedOutput.Name = "textBoxExpectedOutput";
            this.textBoxExpectedOutput.Size = new System.Drawing.Size(258, 40);
            this.textBoxExpectedOutput.TabIndex = 2;
            // 
            // listBoxAssignments
            // 
            this.listBoxAssignments.FormattingEnabled = true;
            this.listBoxAssignments.ItemHeight = 16;
            this.listBoxAssignments.Location = new System.Drawing.Point(10, 209);
            this.listBoxAssignments.Name = "listBoxAssignments";
            this.listBoxAssignments.Size = new System.Drawing.Size(247, 244);
            this.listBoxAssignments.TabIndex = 3;
            // 
            // ButtonSaveAssignment
            // 
            this.ButtonSaveAssignment.Location = new System.Drawing.Point(310, 12);
            this.ButtonSaveAssignment.Name = "ButtonSaveAssignment";
            this.ButtonSaveAssignment.Size = new System.Drawing.Size(178, 89);
            this.ButtonSaveAssignment.TabIndex = 4;
            this.ButtonSaveAssignment.Text = "Save Assignment";
            this.ButtonSaveAssignment.UseVisualStyleBackColor = true;
            this.ButtonSaveAssignment.Click += new System.EventHandler(this.ButtonSaveAssignment_Click);
            // 
            // labelAssignmentName
            // 
            this.labelAssignmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignmentName.Image = global::Software_Engineering_Project.Properties.Resources.icons8_grades_32;
            this.labelAssignmentName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAssignmentName.Location = new System.Drawing.Point(3, 14);
            this.labelAssignmentName.Name = "labelAssignmentName";
            this.labelAssignmentName.Size = new System.Drawing.Size(259, 44);
            this.labelAssignmentName.TabIndex = 5;
            this.labelAssignmentName.Text = "Assignment Name:";
            this.labelAssignmentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAssignmentForm
            // 
            this.panelAssignmentForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelAssignmentForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAssignmentForm.Controls.Add(this.panelLabels);
            this.panelAssignmentForm.Controls.Add(this.textBoxDescription);
            this.panelAssignmentForm.Controls.Add(this.PanelMainControls);
            this.panelAssignmentForm.Controls.Add(this.textBoxAssignmentName);
            this.panelAssignmentForm.Controls.Add(this.textBoxRequiredInput);
            this.panelAssignmentForm.Controls.Add(this.textBoxExpectedOutput);
            this.panelAssignmentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssignmentForm.Location = new System.Drawing.Point(0, 0);
            this.panelAssignmentForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelAssignmentForm.Name = "panelAssignmentForm";
            this.panelAssignmentForm.Size = new System.Drawing.Size(536, 576);
            this.panelAssignmentForm.TabIndex = 11;
            // 
            // panelLabels
            // 
            this.panelLabels.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLabels.Controls.Add(this.label3);
            this.panelLabels.Controls.Add(this.labelInput);
            this.panelLabels.Controls.Add(this.label1);
            this.panelLabels.Controls.Add(this.listBoxAssignments);
            this.panelLabels.Controls.Add(this.labelAssignmentName);
            this.panelLabels.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLabels.Location = new System.Drawing.Point(0, 0);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(267, 461);
            this.panelLabels.TabIndex = 15;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(273, 163);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(258, 291);
            this.textBoxDescription.TabIndex = 13;
            // 
            // PanelMainControls
            // 
            this.PanelMainControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PanelMainControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMainControls.Controls.Add(this.PanelExit);
            this.PanelMainControls.Controls.Add(this.ButtonSaveAssignment);
            this.PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMainControls.Location = new System.Drawing.Point(0, 461);
            this.PanelMainControls.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMainControls.Name = "PanelMainControls";
            this.PanelMainControls.Size = new System.Drawing.Size(534, 113);
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
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInput
            // 
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelInput.Location = new System.Drawing.Point(3, 58);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(259, 44);
            this.labelInput.TabIndex = 7;
            this.labelInput.Text = "Input:";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(2, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreateAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 576);
            this.Controls.Add(this.panelAssignmentForm);
            this.Name = "FormCreateAssignment";
            this.Text = "Create Assignment";
            this.panelAssignmentForm.ResumeLayout(false);
            this.panelAssignmentForm.PerformLayout();
            this.panelLabels.ResumeLayout(false);
            this.PanelMainControls.ResumeLayout(false);
            this.PanelExit.ResumeLayout(false);
            this.ResumeLayout(false);

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