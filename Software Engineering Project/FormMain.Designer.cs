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
            buttonPrint = new ClassCustomButton();
            buttonExecute = new ClassCustomButton();
            panelSideMenuPanel = new System.Windows.Forms.Panel();
            Pnl_HelpControls = new System.Windows.Forms.Panel();
            Pnl_ThemeControls = new System.Windows.Forms.Panel();
            buttonDarkTheme = new System.Windows.Forms.Button();
            buttonLightTheme = new System.Windows.Forms.Button();
            buttonEdit = new System.Windows.Forms.Button();
            Pnl_SubmissionControls = new System.Windows.Forms.Panel();
            buttonCreateSubmission = new System.Windows.Forms.Button();
            buttonSubmission = new System.Windows.Forms.Button();
            Pnl_AssignmentControls = new System.Windows.Forms.Panel();
            buttonCreateAssignment = new System.Windows.Forms.Button();
            buttonOpenAssignment = new System.Windows.Forms.Button();
            buttonAssignments = new System.Windows.Forms.Button();
            toolTipFile = new System.Windows.Forms.ToolTip(components);
            listboxSubmissions = new System.Windows.Forms.ListBox();
            panelMain = new System.Windows.Forms.Panel();
            Rtb_Results = new System.Windows.Forms.RichTextBox();
            Lbl_ResultsLabel = new System.Windows.Forms.Label();
            Lbl_SubmissionsTitle = new System.Windows.Forms.Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            PanelMainControls.SuspendLayout();
            PanelExit.SuspendLayout();
            panelSideMenuPanel.SuspendLayout();
            Pnl_HelpControls.SuspendLayout();
            Pnl_ThemeControls.SuspendLayout();
            Pnl_SubmissionControls.SuspendLayout();
            Pnl_AssignmentControls.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitlecard
            // 
            labelTitlecard.BackColor = System.Drawing.SystemColors.Info;
            labelTitlecard.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitlecard.Font = new System.Drawing.Font("Middle Ages",18F,System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic,System.Drawing.GraphicsUnit.Point);
            labelTitlecard.ForeColor = System.Drawing.SystemColors.WindowText;
            labelTitlecard.Location = new System.Drawing.Point(0,0);
            labelTitlecard.Name = "labelTitlecard";
            labelTitlecard.Size = new System.Drawing.Size(214,69);
            labelTitlecard.TabIndex = 1;
            labelTitlecard.Text = "AUTOMATED CODE METRICS";
            labelTitlecard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTitlecard.Click += labelTitlecard_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            buttonAbout.FlatAppearance.BorderSize = 0;
            buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAbout.ForeColor = System.Drawing.SystemColors.InfoText;
            buttonAbout.Image = Properties.Resources.icons8_info_32;
            buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAbout.Location = new System.Drawing.Point(0,0);
            buttonAbout.Margin = new System.Windows.Forms.Padding(4);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Padding = new System.Windows.Forms.Padding(41,0,0,0);
            buttonAbout.Size = new System.Drawing.Size(214,64);
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
            buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64,64,64);
            buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonHelp.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonHelp.Image = Properties.Resources.icons8_help_30;
            buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonHelp.Location = new System.Drawing.Point(0,581);
            buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Padding = new System.Windows.Forms.Padding(18,0,0,0);
            buttonHelp.Size = new System.Drawing.Size(214,64);
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
            PanelMainControls.Controls.Add(buttonPrint);
            PanelMainControls.Controls.Add(buttonExecute);
            PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            PanelMainControls.Location = new System.Drawing.Point(0,426);
            PanelMainControls.Margin = new System.Windows.Forms.Padding(4);
            PanelMainControls.Name = "PanelMainControls";
            PanelMainControls.Size = new System.Drawing.Size(941,62);
            PanelMainControls.TabIndex = 11;
            // 
            // PanelExit
            // 
            PanelExit.BackColor = System.Drawing.SystemColors.Info;
            PanelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelExit.Controls.Add(ButtonExit);
            PanelExit.Dock = System.Windows.Forms.DockStyle.Left;
            PanelExit.Location = new System.Drawing.Point(0,0);
            PanelExit.Margin = new System.Windows.Forms.Padding(4);
            PanelExit.Name = "PanelExit";
            PanelExit.Size = new System.Drawing.Size(233,60);
            PanelExit.TabIndex = 10;
            // 
            // ButtonExit
            // 
            ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            ButtonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            ButtonExit.Location = new System.Drawing.Point(21,6);
            ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new System.Drawing.Size(188,46);
            ButtonExit.TabIndex = 0;
            ButtonExit.Tag = "https://icons8.com/icons/set/website";
            ButtonExit.Text = "&Exit";
            ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            buttonPrint.Location = new System.Drawing.Point(590,6);
            buttonPrint.Margin = new System.Windows.Forms.Padding(4);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new System.Drawing.Size(338,48);
            buttonPrint.TabIndex = 8;
            buttonPrint.Text = "Print";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += ButtonPrint_Click;
            // 
            // buttonExecute
            // 
            buttonExecute.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            buttonExecute.Font = new System.Drawing.Font("Microsoft Sans Serif",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            buttonExecute.Location = new System.Drawing.Point(240,7);
            buttonExecute.Margin = new System.Windows.Forms.Padding(4);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new System.Drawing.Size(338,48);
            buttonExecute.TabIndex = 9;
            buttonExecute.Text = "Execute";
            buttonExecute.Click += ButtonExecute_Click;
            // 
            // panelSideMenuPanel
            // 
            panelSideMenuPanel.AutoScroll = true;
            panelSideMenuPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            panelSideMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSideMenuPanel.Controls.Add(Pnl_HelpControls);
            panelSideMenuPanel.Controls.Add(buttonHelp);
            panelSideMenuPanel.Controls.Add(Pnl_ThemeControls);
            panelSideMenuPanel.Controls.Add(buttonEdit);
            panelSideMenuPanel.Controls.Add(Pnl_SubmissionControls);
            panelSideMenuPanel.Controls.Add(buttonSubmission);
            panelSideMenuPanel.Controls.Add(Pnl_AssignmentControls);
            panelSideMenuPanel.Controls.Add(buttonAssignments);
            panelSideMenuPanel.Controls.Add(labelTitlecard);
            panelSideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            panelSideMenuPanel.Location = new System.Drawing.Point(0,0);
            panelSideMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            panelSideMenuPanel.Name = "panelSideMenuPanel";
            panelSideMenuPanel.Size = new System.Drawing.Size(233,426);
            panelSideMenuPanel.TabIndex = 12;
            // 
            // Pnl_HelpControls
            // 
            Pnl_HelpControls.AutoSize = true;
            Pnl_HelpControls.BackColor = System.Drawing.SystemColors.Info;
            Pnl_HelpControls.Controls.Add(buttonAbout);
            Pnl_HelpControls.Dock = System.Windows.Forms.DockStyle.Top;
            Pnl_HelpControls.Location = new System.Drawing.Point(0,645);
            Pnl_HelpControls.Margin = new System.Windows.Forms.Padding(4);
            Pnl_HelpControls.Name = "Pnl_HelpControls";
            Pnl_HelpControls.Size = new System.Drawing.Size(214,64);
            Pnl_HelpControls.TabIndex = 9;
            Pnl_HelpControls.Visible = false;
            // 
            // Pnl_ThemeControls
            // 
            Pnl_ThemeControls.BackColor = System.Drawing.SystemColors.Info;
            Pnl_ThemeControls.Controls.Add(buttonDarkTheme);
            Pnl_ThemeControls.Controls.Add(buttonLightTheme);
            Pnl_ThemeControls.Dock = System.Windows.Forms.DockStyle.Top;
            Pnl_ThemeControls.Location = new System.Drawing.Point(0,453);
            Pnl_ThemeControls.Margin = new System.Windows.Forms.Padding(4);
            Pnl_ThemeControls.Name = "Pnl_ThemeControls";
            Pnl_ThemeControls.Size = new System.Drawing.Size(214,128);
            Pnl_ThemeControls.TabIndex = 8;
            Pnl_ThemeControls.Visible = false;
            // 
            // buttonDarkTheme
            // 
            buttonDarkTheme.Dock = System.Windows.Forms.DockStyle.Top;
            buttonDarkTheme.FlatAppearance.BorderSize = 0;
            buttonDarkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDarkTheme.ForeColor = System.Drawing.SystemColors.InfoText;
            buttonDarkTheme.Image = Properties.Resources.icons8_layout_32__1_;
            buttonDarkTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDarkTheme.Location = new System.Drawing.Point(0,64);
            buttonDarkTheme.Margin = new System.Windows.Forms.Padding(4);
            buttonDarkTheme.Name = "buttonDarkTheme";
            buttonDarkTheme.Padding = new System.Windows.Forms.Padding(41,0,0,0);
            buttonDarkTheme.Size = new System.Drawing.Size(214,64);
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
            buttonLightTheme.Location = new System.Drawing.Point(0,0);
            buttonLightTheme.Margin = new System.Windows.Forms.Padding(4);
            buttonLightTheme.Name = "buttonLightTheme";
            buttonLightTheme.Padding = new System.Windows.Forms.Padding(41,0,0,0);
            buttonLightTheme.Size = new System.Drawing.Size(214,64);
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
            buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64,64,64);
            buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonEdit.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonEdit.Image = Properties.Resources.icons8_settings_32;
            buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.Location = new System.Drawing.Point(0,389);
            buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new System.Windows.Forms.Padding(18,0,0,0);
            buttonEdit.Size = new System.Drawing.Size(214,64);
            buttonEdit.TabIndex = 7;
            buttonEdit.Tag = "https://icons8.com/icons/set/website";
            buttonEdit.Text = "Theme Settings";
            buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Pnl_SubmissionControls
            // 
            Pnl_SubmissionControls.BackColor = System.Drawing.SystemColors.Info;
            Pnl_SubmissionControls.Controls.Add(buttonCreateSubmission);
            Pnl_SubmissionControls.Dock = System.Windows.Forms.DockStyle.Top;
            Pnl_SubmissionControls.Location = new System.Drawing.Point(0,327);
            Pnl_SubmissionControls.Margin = new System.Windows.Forms.Padding(4);
            Pnl_SubmissionControls.Name = "Pnl_SubmissionControls";
            Pnl_SubmissionControls.Size = new System.Drawing.Size(214,62);
            Pnl_SubmissionControls.TabIndex = 9;
            Pnl_SubmissionControls.Visible = false;
            // 
            // buttonCreateSubmission
            // 
            buttonCreateSubmission.Dock = System.Windows.Forms.DockStyle.Top;
            buttonCreateSubmission.FlatAppearance.BorderSize = 0;
            buttonCreateSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCreateSubmission.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonCreateSubmission.Image = Properties.Resources.icons8_add_file_32;
            buttonCreateSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCreateSubmission.Location = new System.Drawing.Point(0,0);
            buttonCreateSubmission.Margin = new System.Windows.Forms.Padding(4);
            buttonCreateSubmission.Name = "buttonCreateSubmission";
            buttonCreateSubmission.Padding = new System.Windows.Forms.Padding(41,0,0,0);
            buttonCreateSubmission.Size = new System.Drawing.Size(214,64);
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
            buttonSubmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64,64,64);
            buttonSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSubmission.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonSubmission.Image = Properties.Resources.icons8_file_32;
            buttonSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSubmission.Location = new System.Drawing.Point(0,263);
            buttonSubmission.Margin = new System.Windows.Forms.Padding(4);
            buttonSubmission.Name = "buttonSubmission";
            buttonSubmission.Padding = new System.Windows.Forms.Padding(18,0,0,0);
            buttonSubmission.Size = new System.Drawing.Size(214,64);
            buttonSubmission.TabIndex = 7;
            buttonSubmission.Tag = "https://icons8.com/icons/set/website";
            buttonSubmission.Text = "Submission";
            buttonSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonSubmission.UseVisualStyleBackColor = true;
            buttonSubmission.Click += buttonSubmission_Click;
            // 
            // Pnl_AssignmentControls
            // 
            Pnl_AssignmentControls.BackColor = System.Drawing.SystemColors.Info;
            Pnl_AssignmentControls.Controls.Add(buttonCreateAssignment);
            Pnl_AssignmentControls.Controls.Add(buttonOpenAssignment);
            Pnl_AssignmentControls.Dock = System.Windows.Forms.DockStyle.Top;
            Pnl_AssignmentControls.Location = new System.Drawing.Point(0,133);
            Pnl_AssignmentControls.Margin = new System.Windows.Forms.Padding(4);
            Pnl_AssignmentControls.Name = "Pnl_AssignmentControls";
            Pnl_AssignmentControls.Size = new System.Drawing.Size(214,130);
            Pnl_AssignmentControls.TabIndex = 6;
            Pnl_AssignmentControls.Visible = false;
            // 
            // buttonCreateAssignment
            // 
            buttonCreateAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            buttonCreateAssignment.FlatAppearance.BorderSize = 0;
            buttonCreateAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCreateAssignment.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonCreateAssignment.Image = Properties.Resources.icons8_add_file_32;
            buttonCreateAssignment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonCreateAssignment.Location = new System.Drawing.Point(0,64);
            buttonCreateAssignment.Margin = new System.Windows.Forms.Padding(4);
            buttonCreateAssignment.Name = "buttonCreateAssignment";
            buttonCreateAssignment.Padding = new System.Windows.Forms.Padding(41,0,0,0);
            buttonCreateAssignment.Size = new System.Drawing.Size(214,64);
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
            buttonOpenAssignment.Location = new System.Drawing.Point(0,0);
            buttonOpenAssignment.Margin = new System.Windows.Forms.Padding(4);
            buttonOpenAssignment.Name = "buttonOpenAssignment";
            buttonOpenAssignment.Padding = new System.Windows.Forms.Padding(41,0,0,0);
            buttonOpenAssignment.Size = new System.Drawing.Size(214,64);
            buttonOpenAssignment.TabIndex = 4;
            buttonOpenAssignment.Tag = "https://icons8.com/icons/set/website";
            buttonOpenAssignment.Text = "&Open Assignment";
            buttonOpenAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOpenAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonOpenAssignment.UseVisualStyleBackColor = true;
            buttonOpenAssignment.Click += ButtonOpenAssignment_Click;
            // 
            // buttonAssignments
            // 
            buttonAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            buttonAssignments.FlatAppearance.BorderSize = 0;
            buttonAssignments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(64,64,64);
            buttonAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAssignments.ForeColor = System.Drawing.SystemColors.MenuText;
            buttonAssignments.Image = Properties.Resources.icons8_file_32;
            buttonAssignments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAssignments.Location = new System.Drawing.Point(0,69);
            buttonAssignments.Margin = new System.Windows.Forms.Padding(4);
            buttonAssignments.Name = "buttonAssignments";
            buttonAssignments.Padding = new System.Windows.Forms.Padding(18,0,0,0);
            buttonAssignments.Size = new System.Drawing.Size(214,64);
            buttonAssignments.TabIndex = 2;
            buttonAssignments.Tag = "https://icons8.com/icons/set/website";
            buttonAssignments.Text = "Assignments";
            buttonAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAssignments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            buttonAssignments.UseVisualStyleBackColor = true;
            buttonAssignments.Click += buttonAssignments_Click;
            // 
            // toolTipFile
            // 
            toolTipFile.AutomaticDelay = 0;
            toolTipFile.AutoPopDelay = 0;
            toolTipFile.InitialDelay = 0;
            toolTipFile.ReshowDelay = 0;
            // 
            // listboxSubmissions
            // 
            listboxSubmissions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            listboxSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            listboxSubmissions.ItemHeight = 20;
            listboxSubmissions.Location = new System.Drawing.Point(240,34);
            listboxSubmissions.Margin = new System.Windows.Forms.Padding(4);
            listboxSubmissions.Name = "listboxSubmissions";
            listboxSubmissions.Size = new System.Drawing.Size(338,384);
            listboxSubmissions.TabIndex = 10;
            listboxSubmissions.SelectedIndexChanged += listboxSubmissions_SelectedIndexChanged;
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelMain.Controls.Add(Rtb_Results);
            panelMain.Controls.Add(Lbl_ResultsLabel);
            panelMain.Controls.Add(Lbl_SubmissionsTitle);
            panelMain.Controls.Add(listboxSubmissions);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0,0);
            panelMain.Margin = new System.Windows.Forms.Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(941,488);
            panelMain.TabIndex = 10;
            // 
            // Rtb_Results
            // 
            Rtb_Results.Font = new System.Drawing.Font("Microsoft Sans Serif",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            Rtb_Results.Location = new System.Drawing.Point(590,34);
            Rtb_Results.Name = "Rtb_Results";
            Rtb_Results.ReadOnly = true;
            Rtb_Results.Size = new System.Drawing.Size(337,384);
            Rtb_Results.TabIndex = 15;
            Rtb_Results.Text = "";
            // 
            // Lbl_ResultsLabel
            // 
            Lbl_ResultsLabel.AutoEllipsis = true;
            Lbl_ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            Lbl_ResultsLabel.Location = new System.Drawing.Point(590,8);
            Lbl_ResultsLabel.Name = "Lbl_ResultsLabel";
            Lbl_ResultsLabel.Size = new System.Drawing.Size(337,23);
            Lbl_ResultsLabel.TabIndex = 14;
            Lbl_ResultsLabel.Text = "Results:";
            // 
            // Lbl_SubmissionsTitle
            // 
            Lbl_SubmissionsTitle.AutoEllipsis = true;
            Lbl_SubmissionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif",12F,System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point);
            Lbl_SubmissionsTitle.Location = new System.Drawing.Point(242,8);
            Lbl_SubmissionsTitle.Name = "Lbl_SubmissionsTitle";
            Lbl_SubmissionsTitle.Size = new System.Drawing.Size(336,23);
            Lbl_SubmissionsTitle.TabIndex = 13;
            Lbl_SubmissionsTitle.Text = "Submissions:";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += PrintResults;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0,0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0,0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400,300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F,15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.WindowText;
            ClientSize = new System.Drawing.Size(941,488);
            Controls.Add(panelSideMenuPanel);
            Controls.Add(PanelMainControls);
            Controls.Add(panelMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3,2,3,2);
            Name = "FormMain";
            Text = "Automated Code Metics";
            FormClosing += FormMain_FormClosing;
            PanelMainControls.ResumeLayout(false);
            PanelExit.ResumeLayout(false);
            panelSideMenuPanel.ResumeLayout(false);
            panelSideMenuPanel.PerformLayout();
            Pnl_HelpControls.ResumeLayout(false);
            Pnl_ThemeControls.ResumeLayout(false);
            Pnl_SubmissionControls.ResumeLayout(false);
            Pnl_AssignmentControls.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label labelTitlecard;
        private ClassCustomButton buttonExecute;
        private ClassCustomButton buttonPrint;
        private System.Windows.Forms.Panel PanelMainControls;
        private System.Windows.Forms.Panel panelSideMenuPanel;
        private System.Windows.Forms.Panel Pnl_AssignmentControls;
        private System.Windows.Forms.Button buttonOpenAssignment;
        private System.Windows.Forms.Button buttonAssignments;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel Pnl_ThemeControls;
        private System.Windows.Forms.Button buttonDarkTheme;
        private System.Windows.Forms.Button buttonLightTheme;
        private System.Windows.Forms.Panel PanelExit;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ToolTip toolTipFile;
        private System.Windows.Forms.Button buttonCreateAssignment;
        private System.Windows.Forms.Panel Pnl_HelpControls;
        private System.Windows.Forms.Panel Pnl_SubmissionControls;
        private System.Windows.Forms.Button buttonCreateSubmission;
        private System.Windows.Forms.Button buttonSubmission;
        private System.Windows.Forms.ListBox listboxSubmissions;
        private System.Windows.Forms.Panel panelMain;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label Lbl_SubmissionsTitle;
        private System.Windows.Forms.Label Lbl_ResultsLabel;
        private System.Windows.Forms.RichTextBox Rtb_Results;
    }
}

