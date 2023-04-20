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
            listBoxProjectOpener = new System.Windows.Forms.ListBox();
            listBoxOutput = new System.Windows.Forms.ListBox();
            panelMain = new System.Windows.Forms.Panel();
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
            buttonOpenSubmission = new System.Windows.Forms.Button();
            buttonSubmission = new System.Windows.Forms.Button();
            panelSubMenuFile = new System.Windows.Forms.Panel();
            buttonCreateAssignment = new System.Windows.Forms.Button();
            buttonOpenAssignment = new System.Windows.Forms.Button();
            buttonAssignments = new System.Windows.Forms.Button();
            toolTipFile = new System.Windows.Forms.ToolTip(components);
            label1 = new System.Windows.Forms.Label();
            panelMain.SuspendLayout();
            PanelMainControls.SuspendLayout();
            PanelExit.SuspendLayout();
            panelSideMenuPanel.SuspendLayout();
            panelSubMenuHelp.SuspendLayout();
            panelSubMenuEdit.SuspendLayout();
            SubmissionDockpanel.SuspendLayout();
            panelSubMenuFile.SuspendLayout();
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
            labelTitlecard.Size = new System.Drawing.Size(214, 69);
            labelTitlecard.TabIndex = 1;
            labelTitlecard.Text = "PROGRAM GRADER";
            // 
            // listBoxProjectOpener
            // 
            listBoxProjectOpener.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listBoxProjectOpener.ItemHeight = 15;
            listBoxProjectOpener.Location = new System.Drawing.Point(242, 11);
            listBoxProjectOpener.Margin = new System.Windows.Forms.Padding(4);
            listBoxProjectOpener.Name = "listBoxProjectOpener";
            listBoxProjectOpener.Size = new System.Drawing.Size(323, 304);
            listBoxProjectOpener.TabIndex = 10;
            // 
            // listBoxOutput
            // 
            listBoxOutput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.ItemHeight = 15;
            listBoxOutput.Location = new System.Drawing.Point(595, 11);
            listBoxOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new System.Drawing.Size(323, 304);
            listBoxOutput.TabIndex = 3;
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(listBoxOutput);
            panelMain.Controls.Add(listBoxProjectOpener);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Margin = new System.Windows.Forms.Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(941, 488);
            panelMain.TabIndex = 10;
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
            buttonAbout.Margin = new System.Windows.Forms.Padding(4);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            buttonAbout.Size = new System.Drawing.Size(214, 64);
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
            buttonHelp.Location = new System.Drawing.Point(0, 647);
            buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            buttonHelp.Size = new System.Drawing.Size(214, 64);
            buttonHelp.TabIndex = 10;
            buttonHelp.Tag = "https://icons8.com/icons/set/website";
            buttonHelp.Text = "Help";
            buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += ButtonHelp_Click;
            // 
            // PanelMainControls
            // 
            PanelMainControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            PanelMainControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelMainControls.Controls.Add(PanelExit);
            PanelMainControls.Controls.Add(buttonView);
            PanelMainControls.Controls.Add(buttonRun);
            PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelMainControls.Location = new System.Drawing.Point(0, 362);
            PanelMainControls.Margin = new System.Windows.Forms.Padding(4);
            PanelMainControls.Name = "PanelMainControls";
            PanelMainControls.Size = new System.Drawing.Size(941, 126);
            PanelMainControls.TabIndex = 11;
            // 
            // PanelExit
            // 
            PanelExit.BackColor = System.Drawing.SystemColors.Info;
            PanelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelExit.Controls.Add(ButtonExit);
            PanelExit.Dock = System.Windows.Forms.DockStyle.Left;
            PanelExit.Location = new System.Drawing.Point(0, 0);
            PanelExit.Margin = new System.Windows.Forms.Padding(4);
            PanelExit.Name = "PanelExit";
            PanelExit.Size = new System.Drawing.Size(233, 124);
            PanelExit.TabIndex = 10;
            // 
            // ButtonExit
            // 
            ButtonExit.Image = Properties.Resources.icons8_exit_48;
            ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ButtonExit.Location = new System.Drawing.Point(11, 29);
            ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new System.Drawing.Size(193, 70);
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
            buttonView.Location = new System.Drawing.Point(594, 30);
            buttonView.Margin = new System.Windows.Forms.Padding(4);
            buttonView.Name = "buttonView";
            buttonView.Size = new System.Drawing.Size(325, 70);
            buttonView.TabIndex = 8;
            buttonView.Text = "View";
            buttonView.UseVisualStyleBackColor = true;
            buttonView.Click += ButtonView_Click;
            // 
            // buttonRun
            // 
            buttonRun.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonRun.Location = new System.Drawing.Point(242, 30);
            buttonRun.Margin = new System.Windows.Forms.Padding(4);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new System.Drawing.Size(325, 70);
            buttonRun.TabIndex = 9;
            buttonRun.Text = "Run";
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
            panelSideMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            panelSideMenuPanel.Name = "panelSideMenuPanel";
            panelSideMenuPanel.Size = new System.Drawing.Size(233, 362);
            panelSideMenuPanel.TabIndex = 12;
            // 
            // panelSubMenuHelp
            // 
            panelSubMenuHelp.BackColor = System.Drawing.SystemColors.Info;
            panelSubMenuHelp.Controls.Add(buttonAbout);
            panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuHelp.Location = new System.Drawing.Point(0, 711);
            panelSubMenuHelp.Margin = new System.Windows.Forms.Padding(4);
            panelSubMenuHelp.Name = "panelSubMenuHelp";
            panelSubMenuHelp.Size = new System.Drawing.Size(214, 128);
            panelSubMenuHelp.TabIndex = 9;
            // 
            // panelSubMenuEdit
            // 
            panelSubMenuEdit.BackColor = System.Drawing.SystemColors.Info;
            panelSubMenuEdit.Controls.Add(buttonDarkTheme);
            panelSubMenuEdit.Controls.Add(buttonLightTheme);
            panelSubMenuEdit.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuEdit.Location = new System.Drawing.Point(0, 519);
            panelSubMenuEdit.Margin = new System.Windows.Forms.Padding(4);
            panelSubMenuEdit.Name = "panelSubMenuEdit";
            panelSubMenuEdit.Size = new System.Drawing.Size(214, 128);
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
            buttonDarkTheme.Location = new System.Drawing.Point(0, 64);
            buttonDarkTheme.Margin = new System.Windows.Forms.Padding(4);
            buttonDarkTheme.Name = "buttonDarkTheme";
            buttonDarkTheme.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            buttonDarkTheme.Size = new System.Drawing.Size(214, 64);
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
            buttonLightTheme.Margin = new System.Windows.Forms.Padding(4);
            buttonLightTheme.Name = "buttonLightTheme";
            buttonLightTheme.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            buttonLightTheme.Size = new System.Drawing.Size(214, 64);
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
            buttonEdit.Location = new System.Drawing.Point(0, 455);
            buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            buttonEdit.Size = new System.Drawing.Size(214, 64);
            buttonEdit.TabIndex = 7;
            buttonEdit.Tag = "https://icons8.com/icons/set/website";
            buttonEdit.Text = "Edit";
            buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += ButtonEdit_Click;
            // 
            // SubmissionDockpanel
            // 
            SubmissionDockpanel.BackColor = System.Drawing.SystemColors.Info;
            SubmissionDockpanel.Controls.Add(buttonCreateSubmission);
            SubmissionDockpanel.Controls.Add(buttonOpenSubmission);
            SubmissionDockpanel.Dock = System.Windows.Forms.DockStyle.Top;
            SubmissionDockpanel.Location = new System.Drawing.Point(0, 327);
            SubmissionDockpanel.Margin = new System.Windows.Forms.Padding(4);
            SubmissionDockpanel.Name = "SubmissionDockpanel";
            SubmissionDockpanel.Size = new System.Drawing.Size(214, 128);
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
            buttonCreateSubmission.Location = new System.Drawing.Point(0, 64);
            buttonCreateSubmission.Margin = new System.Windows.Forms.Padding(4);
            buttonCreateSubmission.Name = "buttonCreateSubmission";
            buttonCreateSubmission.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            buttonCreateSubmission.Size = new System.Drawing.Size(214, 64);
            buttonCreateSubmission.TabIndex = 6;
            buttonCreateSubmission.Tag = "https://icons8.com/icons/set/website";
            buttonCreateSubmission.Text = "&Create Submissions";
            buttonCreateSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCreateSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonCreateSubmission.UseVisualStyleBackColor = true;
            buttonCreateSubmission.Click += ButtonCreateSubmission_Click;
            // 
            // buttonOpenSubmission
            // 
            buttonOpenSubmission.Dock = System.Windows.Forms.DockStyle.Top;
            buttonOpenSubmission.FlatAppearance.BorderSize = 0;
            buttonOpenSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOpenSubmission.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonOpenSubmission.Image = Properties.Resources.icons8_add_file_32;
            buttonOpenSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOpenSubmission.Location = new System.Drawing.Point(0, 0);
            buttonOpenSubmission.Margin = new System.Windows.Forms.Padding(4);
            buttonOpenSubmission.Name = "buttonOpenSubmission";
            buttonOpenSubmission.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            buttonOpenSubmission.Size = new System.Drawing.Size(214, 64);
            buttonOpenSubmission.TabIndex = 5;
            buttonOpenSubmission.Tag = "https://icons8.com/icons/set/website";
            buttonOpenSubmission.Text = "&Open Submissions";
            buttonOpenSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOpenSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonOpenSubmission.UseVisualStyleBackColor = true;
            buttonOpenSubmission.Click += ButtonOpenSubmission_Click;
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
            buttonSubmission.Location = new System.Drawing.Point(0, 263);
            buttonSubmission.Margin = new System.Windows.Forms.Padding(4);
            buttonSubmission.Name = "buttonSubmission";
            buttonSubmission.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            buttonSubmission.Size = new System.Drawing.Size(214, 64);
            buttonSubmission.TabIndex = 7;
            buttonSubmission.Tag = "https://icons8.com/icons/set/website";
            buttonSubmission.Text = "Submissions";
            buttonSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonSubmission.UseVisualStyleBackColor = true;
            buttonSubmission.Click += Buttonsubmission_Click;
            // 
            // panelSubMenuFile
            // 
            panelSubMenuFile.BackColor = System.Drawing.SystemColors.Info;
            panelSubMenuFile.Controls.Add(buttonCreateAssignment);
            panelSubMenuFile.Controls.Add(buttonOpenAssignment);
            panelSubMenuFile.Dock = System.Windows.Forms.DockStyle.Top;
            panelSubMenuFile.Location = new System.Drawing.Point(0, 133);
            panelSubMenuFile.Margin = new System.Windows.Forms.Padding(4);
            panelSubMenuFile.Name = "panelSubMenuFile";
            panelSubMenuFile.Size = new System.Drawing.Size(214, 130);
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
            buttonCreateAssignment.Location = new System.Drawing.Point(0, 64);
            buttonCreateAssignment.Margin = new System.Windows.Forms.Padding(4);
            buttonCreateAssignment.Name = "buttonCreateAssignment";
            buttonCreateAssignment.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            buttonCreateAssignment.Size = new System.Drawing.Size(214, 64);
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
            buttonOpenAssignment.Margin = new System.Windows.Forms.Padding(4);
            buttonOpenAssignment.Name = "buttonOpenAssignment";
            buttonOpenAssignment.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            buttonOpenAssignment.Size = new System.Drawing.Size(214, 64);
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
            buttonAssignments.Location = new System.Drawing.Point(0, 69);
            buttonAssignments.Margin = new System.Windows.Forms.Padding(4);
            buttonAssignments.Name = "buttonAssignments";
            buttonAssignments.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            buttonAssignments.Size = new System.Drawing.Size(214, 64);
            buttonAssignments.TabIndex = 2;
            buttonAssignments.Tag = "https://icons8.com/icons/set/website";
            buttonAssignments.Text = "Assignments";
            buttonAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAssignments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonAssignments.UseVisualStyleBackColor = true;
            buttonAssignments.Click += ButtonFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(297, 330);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowText;
            ClientSize = new System.Drawing.Size(941, 488);
            Controls.Add(panelSideMenuPanel);
            Controls.Add(PanelMainControls);
            Controls.Add(panelMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Home";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            PanelMainControls.ResumeLayout(false);
            PanelExit.ResumeLayout(false);
            panelSideMenuPanel.ResumeLayout(false);
            panelSubMenuHelp.ResumeLayout(false);
            panelSubMenuEdit.ResumeLayout(false);
            SubmissionDockpanel.ResumeLayout(false);
            panelSubMenuFile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label labelTitlecard;
        private System.Windows.Forms.ListBox listBoxProjectOpener;
        private System.Windows.Forms.ListBox listBoxOutput;
        private ClassCustomButton buttonRun;
        private ClassCustomButton buttonView;
        private System.Windows.Forms.Panel panelMain;
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
        private System.Windows.Forms.Button buttonOpenSubmission;
        private System.Windows.Forms.Button buttonSubmission;
        private System.Windows.Forms.Label label1;
    }
}

