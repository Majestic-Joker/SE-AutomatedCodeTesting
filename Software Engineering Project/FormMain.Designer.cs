namespace Software_Engineering_Project
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            labelTitlecard = new System.Windows.Forms.Label();
            buttonAbout = new System.Windows.Forms.Button();
            buttonHelp = new System.Windows.Forms.Button();
            PanelMainControls = new System.Windows.Forms.Panel();
            PanelExit = new System.Windows.Forms.Panel();
            ButtonExit = new System.Windows.Forms.Button();
            buttonView = new ClassCustomButton();
            buttonRun = new ClassCustomButton();
            panelSideMenuPanel = new System.Windows.Forms.Panel();
            panelSubMenuHelp = new System.Windows.Forms.Panel();
            panelSubMenuEdit = new System.Windows.Forms.Panel();
            buttonDarkTheme = new System.Windows.Forms.Button();
            buttonLightTheme = new System.Windows.Forms.Button();
            buttonEdit = new System.Windows.Forms.Button();
            SubmissionDockpanel = new System.Windows.Forms.Panel();
            buttonCreateSubmission = new System.Windows.Forms.Button();
            buttonSubmission = new System.Windows.Forms.Button();
            panelSubMenuFile = new System.Windows.Forms.Panel();
            buttonCreateAssignment = new System.Windows.Forms.Button();
            buttonOpenAssignment = new System.Windows.Forms.Button();
            buttonAssignments = new System.Windows.Forms.Button();
            toolTipFile = new System.Windows.Forms.ToolTip(components);
            listBoxProjectOpener = new System.Windows.Forms.ListBox();
            panelMain = new System.Windows.Forms.Panel();
            textBoxResult = new System.Windows.Forms.TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            PanelMainControls.SuspendLayout();
            PanelExit.SuspendLayout();
            panelSideMenuPanel.SuspendLayout();
            panelSubMenuHelp.SuspendLayout();
            panelSubMenuEdit.SuspendLayout();
            SubmissionDockpanel.SuspendLayout();
            panelSubMenuFile.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitlecard
            // 
            labelTitlecard.BackColor = System.Drawing.SystemColors.Info;
            labelTitlecard.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitlecard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            labelTitlecard.ForeColor = System.Drawing.SystemColors.WindowText;
            labelTitlecard.Location = new System.Drawing.Point(0, 0);
            labelTitlecard.Name = "labelTitlecard";
            labelTitlecard.Size = new System.Drawing.Size(243, 92);
            labelTitlecard.TabIndex = 1;
            labelTitlecard.Text = "PROGRAM GRADER";
            // 
            // buttonAbout
            // 
            buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            buttonAbout.FlatAppearance.BorderSize = 0;
            buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAbout.ForeColor = System.Drawing.SystemColors.InfoText;
            buttonAbout.Image = Properties.Resources.icons8_info_32;
            buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAbout.Location = new System.Drawing.Point(0, 0);
            buttonAbout.Margin = new System.Windows.Forms.Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            buttonAbout.Size = new System.Drawing.Size(243, 85);
            buttonAbout.TabIndex = 6;
            buttonAbout.Tag = "https://icons8.com/icons/set/website";
            buttonAbout.Text = "About";
            buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += ButtonAbout_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonHelp.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonHelp.Image = Properties.Resources.icons8_help_30;
            buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonHelp.Location = new System.Drawing.Point(0, 773);
            buttonHelp.Margin = new System.Windows.Forms.Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            buttonHelp.Size = new System.Drawing.Size(243, 85);
            buttonHelp.TabIndex = 10;
            buttonHelp.Tag = "https://icons8.com/icons/set/website";
            buttonHelp.Text = "Help";
            buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // PanelMainControls
            // 
            PanelMainControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            PanelMainControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelMainControls.Controls.Add(PanelExit);
            PanelMainControls.Controls.Add(buttonView);
            PanelMainControls.Controls.Add(buttonRun);
            PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelMainControls.Location = new System.Drawing.Point(0, 484);
            PanelMainControls.Margin = new System.Windows.Forms.Padding(5);
            PanelMainControls.Name = "PanelMainControls";
            PanelMainControls.Size = new System.Drawing.Size(1075, 167);
            PanelMainControls.TabIndex = 11;
            // 
            // PanelExit
            // 
            PanelExit.BackColor = System.Drawing.SystemColors.Info;
            PanelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelExit.Controls.Add(ButtonExit);
            PanelExit.Dock = System.Windows.Forms.DockStyle.Left;
            PanelExit.Location = new System.Drawing.Point(0, 0);
            PanelExit.Margin = new System.Windows.Forms.Padding(5);
            PanelExit.Name = "PanelExit";
            PanelExit.Size = new System.Drawing.Size(266, 165);
            PanelExit.TabIndex = 10;
            // 
            // ButtonExit
            // 
            ButtonExit.Image = Properties.Resources.icons8_exit_48;
            ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ButtonExit.Location = new System.Drawing.Point(13, 39);
            ButtonExit.Margin = new System.Windows.Forms.Padding(5);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new System.Drawing.Size(221, 93);
            ButtonExit.TabIndex = 0;
            ButtonExit.Tag = "https://icons8.com/icons/set/website";
            ButtonExit.Text = "&Exit";
            ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // buttonView
            // 
            buttonView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonView.Location = new System.Drawing.Point(689, 40);
            buttonView.Margin = new System.Windows.Forms.Padding(5);
            buttonView.Name = "buttonView";
            buttonView.Size = new System.Drawing.Size(371, 93);
            buttonView.TabIndex = 8;
            buttonView.Text = "Print";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += ButtonPrint_Click;
            // 
            // buttonRun
            // 
            buttonRun.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRun.Location = new System.Drawing.Point(277, 40);
            buttonRun.Margin = new System.Windows.Forms.Padding(5);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new System.Drawing.Size(371, 93);
            buttonRun.TabIndex = 9;
            buttonRun.Text = "Execute";
            buttonRun.Click += ButtonRun_Click;
            // 
            // panelSideMenuPanel
            // 
            panelSideMenuPanel.AutoScroll = true;
            panelSideMenuPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            panelSideMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSideMenuPanel.Controls.Add(panelSubMenuHelp);
            panelSideMenuPanel.Controls.Add(buttonHelp);
            panelSideMenuPanel.Controls.Add(panelSubMenuEdit);
            panelSideMenuPanel.Controls.Add(buttonEdit);
            panelSideMenuPanel.Controls.Add(SubmissionDockpanel);
            panelSideMenuPanel.Controls.Add(buttonSubmission);
            panelSideMenuPanel.Controls.Add(panelSubMenuFile);
            panelSideMenuPanel.Controls.Add(buttonAssignments);
            panelSideMenuPanel.Controls.Add(labelTitlecard);
            panelSideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            panelSideMenuPanel.Location = new System.Drawing.Point(0, 0);
            panelSideMenuPanel.Margin = new System.Windows.Forms.Padding(5);
            panelSideMenuPanel.Name = "panelSideMenuPanel";
            panelSideMenuPanel.Size = new System.Drawing.Size(266, 484);
            panelSideMenuPanel.TabIndex = 12;
            // 
            // panelSubMenuHelp
            // 
            panelSubMenuHelp.BackColor = System.Drawing.SystemColors.Info;
            panelSubMenuHelp.Controls.Add(buttonAbout);
            panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuHelp.Location = new System.Drawing.Point(0, 858);
            panelSubMenuHelp.Margin = new System.Windows.Forms.Padding(5);
            panelSubMenuHelp.Name = "panelSubMenuHelp";
            panelSubMenuHelp.Size = new System.Drawing.Size(243, 171);
            panelSubMenuHelp.TabIndex = 9;
            // 
            // panelSubMenuEdit
            // 
            panelSubMenuEdit.BackColor = System.Drawing.SystemColors.Info;
            panelSubMenuEdit.Controls.Add(buttonDarkTheme);
            panelSubMenuEdit.Controls.Add(buttonLightTheme);
            panelSubMenuEdit.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuEdit.Location = new System.Drawing.Point(0, 602);
            panelSubMenuEdit.Margin = new System.Windows.Forms.Padding(5);
            panelSubMenuEdit.Name = "panelSubMenuEdit";
            panelSubMenuEdit.Size = new System.Drawing.Size(243, 171);
            panelSubMenuEdit.TabIndex = 8;
            // 
            // buttonDarkTheme
            // 
            buttonDarkTheme.Dock = System.Windows.Forms.DockStyle.Top;
            buttonDarkTheme.FlatAppearance.BorderSize = 0;
            buttonDarkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDarkTheme.ForeColor = System.Drawing.SystemColors.InfoText;
            buttonDarkTheme.Image = Properties.Resources.icons8_layout_32__1_;
            buttonDarkTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDarkTheme.Location = new System.Drawing.Point(0, 85);
            buttonDarkTheme.Margin = new System.Windows.Forms.Padding(5);
            buttonDarkTheme.Name = "buttonDarkTheme";
            buttonDarkTheme.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            buttonDarkTheme.Size = new System.Drawing.Size(243, 85);
            buttonDarkTheme.TabIndex = 6;
            buttonDarkTheme.Text = "Dark Theme";
            buttonDarkTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDarkTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonDarkTheme.UseVisualStyleBackColor = true;
            buttonDarkTheme.Click += ButtonDarkTheme_Click;
            // 
            // buttonLightTheme
            // 
            buttonLightTheme.Dock = System.Windows.Forms.DockStyle.Top;
            buttonLightTheme.FlatAppearance.BorderSize = 0;
            buttonLightTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLightTheme.ForeColor = System.Drawing.SystemColors.InfoText;
            buttonLightTheme.Image = Properties.Resources.icons8_layout_32;
            buttonLightTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLightTheme.Location = new System.Drawing.Point(0, 0);
            buttonLightTheme.Margin = new System.Windows.Forms.Padding(5);
            buttonLightTheme.Name = "buttonLightTheme";
            buttonLightTheme.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            buttonLightTheme.Size = new System.Drawing.Size(243, 85);
            buttonLightTheme.TabIndex = 5;
            buttonLightTheme.Text = "Light Theme";
            buttonLightTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLightTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonLightTheme.UseVisualStyleBackColor = true;
            buttonLightTheme.Click += ButtonLightTheme_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonEdit.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonEdit.Image = Properties.Resources.icons8_settings_32;
            buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.Location = new System.Drawing.Point(0, 517);
            buttonEdit.Margin = new System.Windows.Forms.Padding(5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            buttonEdit.Size = new System.Drawing.Size(243, 85);
            buttonEdit.TabIndex = 7;
            buttonEdit.Tag = "https://icons8.com/icons/set/website";
            buttonEdit.Text = "Edit";
            buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // SubmissionDockpanel
            // 
            SubmissionDockpanel.BackColor = System.Drawing.SystemColors.Info;
            SubmissionDockpanel.Controls.Add(buttonCreateSubmission);
            SubmissionDockpanel.Dock = System.Windows.Forms.DockStyle.Top;
            SubmissionDockpanel.Location = new System.Drawing.Point(0, 435);
            SubmissionDockpanel.Margin = new System.Windows.Forms.Padding(5);
            SubmissionDockpanel.Name = "SubmissionDockpanel";
            SubmissionDockpanel.Size = new System.Drawing.Size(243, 82);
            SubmissionDockpanel.TabIndex = 9;
            // 
            // buttonCreateSubmission
            // 
            buttonCreateSubmission.Dock = System.Windows.Forms.DockStyle.Top;
            buttonCreateSubmission.FlatAppearance.BorderSize = 0;
            buttonCreateSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCreateSubmission.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonCreateSubmission.Image = Properties.Resources.icons8_add_file_32;
            buttonCreateSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCreateSubmission.Location = new System.Drawing.Point(0, 0);
            buttonCreateSubmission.Margin = new System.Windows.Forms.Padding(5);
            buttonCreateSubmission.Name = "buttonCreateSubmission";
            buttonCreateSubmission.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            buttonCreateSubmission.Size = new System.Drawing.Size(243, 85);
            buttonCreateSubmission.TabIndex = 6;
            buttonCreateSubmission.Tag = "https://icons8.com/icons/set/website";
            buttonCreateSubmission.Text = "&Create Submissions";
            buttonCreateSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCreateSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonCreateSubmission.UseVisualStyleBackColor = true;
            buttonCreateSubmission.Click += ButtonCreateSubmission_Click;
            // 
            // buttonSubmission
            // 
            buttonSubmission.Dock = System.Windows.Forms.DockStyle.Top;
            buttonSubmission.FlatAppearance.BorderSize = 0;
            buttonSubmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSubmission.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonSubmission.Image = Properties.Resources.icons8_file_32;
            buttonSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSubmission.Location = new System.Drawing.Point(0, 350);
            buttonSubmission.Margin = new System.Windows.Forms.Padding(5);
            buttonSubmission.Name = "buttonSubmission";
            buttonSubmission.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            buttonSubmission.Size = new System.Drawing.Size(243, 85);
            buttonSubmission.TabIndex = 7;
            buttonSubmission.Tag = "https://icons8.com/icons/set/website";
            buttonSubmission.Text = "Submissions";
            buttonSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonSubmission.UseVisualStyleBackColor = true;
            buttonSubmission.Click += buttonSubmission_Click;
            // 
            // panelSubMenuFile
            // 
            panelSubMenuFile.BackColor = System.Drawing.SystemColors.Info;
            panelSubMenuFile.Controls.Add(buttonCreateAssignment);
            panelSubMenuFile.Controls.Add(buttonOpenAssignment);
            panelSubMenuFile.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuFile.Location = new System.Drawing.Point(0, 177);
            panelSubMenuFile.Margin = new System.Windows.Forms.Padding(5);
            panelSubMenuFile.Name = "panelSubMenuFile";
            panelSubMenuFile.Size = new System.Drawing.Size(243, 173);
            panelSubMenuFile.TabIndex = 6;
            // 
            // buttonCreateAssignment
            // 
            buttonCreateAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            buttonCreateAssignment.FlatAppearance.BorderSize = 0;
            buttonCreateAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCreateAssignment.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonCreateAssignment.Image = Properties.Resources.icons8_add_file_32;
            buttonCreateAssignment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCreateAssignment.Location = new System.Drawing.Point(0, 85);
            buttonCreateAssignment.Margin = new System.Windows.Forms.Padding(5);
            buttonCreateAssignment.Name = "buttonCreateAssignment";
            buttonCreateAssignment.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            buttonCreateAssignment.Size = new System.Drawing.Size(243, 85);
            buttonCreateAssignment.TabIndex = 5;
            buttonCreateAssignment.Tag = "https://icons8.com/icons/set/website";
            buttonCreateAssignment.Text = "&Create Assignment";
            buttonCreateAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCreateAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonCreateAssignment.UseVisualStyleBackColor = true;
            buttonCreateAssignment.Click += ButtonCreateAssignment_Click;
            // 
            // buttonOpenAssignment
            // 
            buttonOpenAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            buttonOpenAssignment.FlatAppearance.BorderSize = 0;
            buttonOpenAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOpenAssignment.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonOpenAssignment.Image = Properties.Resources.icons8_add_file_32;
            buttonOpenAssignment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOpenAssignment.Location = new System.Drawing.Point(0, 0);
            buttonOpenAssignment.Margin = new System.Windows.Forms.Padding(5);
            buttonOpenAssignment.Name = "buttonOpenAssignment";
            buttonOpenAssignment.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            buttonOpenAssignment.Size = new System.Drawing.Size(243, 85);
            buttonOpenAssignment.TabIndex = 4;
            buttonOpenAssignment.Tag = "https://icons8.com/icons/set/website";
            buttonOpenAssignment.Text = "&Open Assignment";
            buttonOpenAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOpenAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonOpenAssignment.UseVisualStyleBackColor = true;
            buttonOpenAssignment.Click += ButtonOpenFile_Click;
            // 
            // buttonAssignments
            // 
            buttonAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            buttonAssignments.FlatAppearance.BorderSize = 0;
            buttonAssignments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            buttonAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAssignments.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonAssignments.Image = Properties.Resources.icons8_file_32;
            buttonAssignments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAssignments.Location = new System.Drawing.Point(0, 92);
            buttonAssignments.Margin = new System.Windows.Forms.Padding(5);
            buttonAssignments.Name = "buttonAssignments";
            buttonAssignments.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            buttonAssignments.Size = new System.Drawing.Size(243, 85);
            buttonAssignments.TabIndex = 2;
            buttonAssignments.Tag = "https://icons8.com/icons/set/website";
            buttonAssignments.Text = "Assignments";
            buttonAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAssignments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonAssignments.UseVisualStyleBackColor = true;
            buttonAssignments.Click += buttonAssignments_Click;
            // 
            // listBoxProjectOpener
            // 
            listBoxProjectOpener.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listBoxProjectOpener.ItemHeight = 20;
            listBoxProjectOpener.Location = new System.Drawing.Point(277, 15);
            listBoxProjectOpener.Margin = new System.Windows.Forms.Padding(5);
            listBoxProjectOpener.Name = "listBoxProjectOpener";
            listBoxProjectOpener.Size = new System.Drawing.Size(369, 444);
            listBoxProjectOpener.TabIndex = 10;
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelMain.Controls.Add(textBoxResult);
            panelMain.Controls.Add(listBoxProjectOpener);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Margin = new System.Windows.Forms.Padding(5);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1075, 651);
            panelMain.TabIndex = 10;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new System.Drawing.Point(689, 15);
            textBoxResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.PlaceholderText = "Compiled submission results are shown here.";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new System.Drawing.Size(371, 444);
            textBoxResult.TabIndex = 12;
            textBoxResult.TabStop = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += PrintResults;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowText;
            ClientSize = new System.Drawing.Size(1075, 651);
            Controls.Add(panelSideMenuPanel);
            Controls.Add(PanelMainControls);
            Controls.Add(panelMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Home";
            PanelMainControls.ResumeLayout(false);
            PanelExit.ResumeLayout(false);
            panelSideMenuPanel.ResumeLayout(false);
            panelSubMenuHelp.ResumeLayout(false);
            panelSubMenuEdit.ResumeLayout(false);
            SubmissionDockpanel.ResumeLayout(false);
            panelSubMenuFile.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label labelTitlecard;
        private ClassCustomButton buttonRun;
        private ClassCustomButton buttonView;
        private System.Windows.Forms.Panel PanelMainControls;
        private System.Windows.Forms.Panel panelSideMenuPanel;
        private System.Windows.Forms.Panel panelSubMenuFile;
        private System.Windows.Forms.Button buttonOpenAssignment;
        private System.Windows.Forms.Button buttonAssignments;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel panelSubMenuEdit;
        private System.Windows.Forms.Button buttonDarkTheme;
        private System.Windows.Forms.Button buttonLightTheme;
        private System.Windows.Forms.Panel PanelExit;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ToolTip toolTipFile;
        private System.Windows.Forms.Button buttonCreateAssignment;
        private System.Windows.Forms.Panel panelSubMenuHelp;
        private System.Windows.Forms.Panel SubmissionDockpanel;
        private System.Windows.Forms.Button buttonCreateSubmission;
        private System.Windows.Forms.Button buttonSubmission;
        private System.Windows.Forms.ListBox listBoxProjectOpener;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

