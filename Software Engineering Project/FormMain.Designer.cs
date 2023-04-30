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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelTitlecard = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.PanelMainControls = new System.Windows.Forms.Panel();
            this.PanelExit = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.buttonPrint = new Software_Engineering_Project.ClassCustomButton();
            this.buttonExecute = new Software_Engineering_Project.ClassCustomButton();
            this.panelSideMenuPanel = new System.Windows.Forms.Panel();
            this.panelSubMenuHelp = new System.Windows.Forms.Panel();
            this.panelSubMenuEdit = new System.Windows.Forms.Panel();
            this.buttonDarkTheme = new System.Windows.Forms.Button();
            this.buttonLightTheme = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SubmissionDockpanel = new System.Windows.Forms.Panel();
            this.buttonCreateSubmission = new System.Windows.Forms.Button();
            this.buttonSubmission = new System.Windows.Forms.Button();
            this.panelSubMenuFile = new System.Windows.Forms.Panel();
            this.buttonCreateAssignment = new System.Windows.Forms.Button();
            this.buttonOpenAssignment = new System.Windows.Forms.Button();
            this.buttonAssignments = new System.Windows.Forms.Button();
            this.toolTipFile = new System.Windows.Forms.ToolTip(this.components);
            this.listboxSubmissions = new System.Windows.Forms.ListBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Lbl_SubmissionsTitle = new System.Windows.Forms.Label();
            this.Lbl_ResultsLabel = new System.Windows.Forms.Label();
            this.PanelMainControls.SuspendLayout();
            this.PanelExit.SuspendLayout();
            this.panelSideMenuPanel.SuspendLayout();
            this.panelSubMenuHelp.SuspendLayout();
            this.panelSubMenuEdit.SuspendLayout();
            this.SubmissionDockpanel.SuspendLayout();
            this.panelSubMenuFile.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitlecard
            // 
            this.labelTitlecard.BackColor = System.Drawing.SystemColors.Info;
            this.labelTitlecard.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitlecard.Font = new System.Drawing.Font("Middle Ages", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTitlecard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitlecard.Location = new System.Drawing.Point(0, 0);
            this.labelTitlecard.Name = "labelTitlecard";
            this.labelTitlecard.Size = new System.Drawing.Size(214, 69);
            this.labelTitlecard.TabIndex = 1;
            this.labelTitlecard.Text = "AUTOMATED CODE METRICS";
            this.labelTitlecard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonAbout.Image = global::Software_Engineering_Project.Properties.Resources.icons8_info_32;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(0, 0);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.buttonAbout.Size = new System.Drawing.Size(214, 64);
            this.buttonAbout.TabIndex = 6;
            this.buttonAbout.Tag = "https://icons8.com/icons/set/website";
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonHelp.Image = global::Software_Engineering_Project.Properties.Resources.icons8_help_30;
            this.buttonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.Location = new System.Drawing.Point(0, 581);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.buttonHelp.Size = new System.Drawing.Size(214, 64);
            this.buttonHelp.TabIndex = 10;
            this.buttonHelp.Tag = "https://icons8.com/icons/set/website";
            this.buttonHelp.Text = "Help";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.MouseHover += new System.EventHandler(this.ButtonHelp_MouseHover);
            // 
            // PanelMainControls
            // 
            this.PanelMainControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PanelMainControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMainControls.Controls.Add(this.PanelExit);
            this.PanelMainControls.Controls.Add(this.buttonPrint);
            this.PanelMainControls.Controls.Add(this.buttonExecute);
            this.PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMainControls.Location = new System.Drawing.Point(0, 426);
            this.PanelMainControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelMainControls.Name = "PanelMainControls";
            this.PanelMainControls.Size = new System.Drawing.Size(941, 62);
            this.PanelMainControls.TabIndex = 11;
            // 
            // PanelExit
            // 
            this.PanelExit.BackColor = System.Drawing.SystemColors.Info;
            this.PanelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelExit.Controls.Add(this.ButtonExit);
            this.PanelExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelExit.Location = new System.Drawing.Point(0, 0);
            this.PanelExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelExit.Name = "PanelExit";
            this.PanelExit.Size = new System.Drawing.Size(233, 60);
            this.PanelExit.TabIndex = 10;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ButtonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.Location = new System.Drawing.Point(21, 6);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(188, 46);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Tag = "https://icons8.com/icons/set/website";
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.MouseHover += new System.EventHandler(this.ButtonExit_MouseHover);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrint.Location = new System.Drawing.Point(590, 6);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(338, 48);
            this.buttonPrint.TabIndex = 8;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            this.buttonPrint.MouseHover += new System.EventHandler(this.ButtonPrint_MouseHover);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExecute.Location = new System.Drawing.Point(240, 7);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(338, 48);
            this.buttonExecute.TabIndex = 9;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // panelSideMenuPanel
            // 
            this.panelSideMenuPanel.AutoScroll = true;
            this.panelSideMenuPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelSideMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSideMenuPanel.Controls.Add(this.panelSubMenuHelp);
            this.panelSideMenuPanel.Controls.Add(this.buttonHelp);
            this.panelSideMenuPanel.Controls.Add(this.panelSubMenuEdit);
            this.panelSideMenuPanel.Controls.Add(this.buttonEdit);
            this.panelSideMenuPanel.Controls.Add(this.SubmissionDockpanel);
            this.panelSideMenuPanel.Controls.Add(this.buttonSubmission);
            this.panelSideMenuPanel.Controls.Add(this.panelSubMenuFile);
            this.panelSideMenuPanel.Controls.Add(this.buttonAssignments);
            this.panelSideMenuPanel.Controls.Add(this.labelTitlecard);
            this.panelSideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSideMenuPanel.Name = "panelSideMenuPanel";
            this.panelSideMenuPanel.Size = new System.Drawing.Size(233, 426);
            this.panelSideMenuPanel.TabIndex = 12;
            // 
            // panelSubMenuHelp
            // 
            this.panelSubMenuHelp.BackColor = System.Drawing.SystemColors.Info;
            this.panelSubMenuHelp.Controls.Add(this.buttonAbout);
            this.panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuHelp.Location = new System.Drawing.Point(0, 645);
            this.panelSubMenuHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubMenuHelp.Name = "panelSubMenuHelp";
            this.panelSubMenuHelp.Size = new System.Drawing.Size(214, 128);
            this.panelSubMenuHelp.TabIndex = 9;
            // 
            // panelSubMenuEdit
            // 
            this.panelSubMenuEdit.BackColor = System.Drawing.SystemColors.Info;
            this.panelSubMenuEdit.Controls.Add(this.buttonDarkTheme);
            this.panelSubMenuEdit.Controls.Add(this.buttonLightTheme);
            this.panelSubMenuEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEdit.Location = new System.Drawing.Point(0, 453);
            this.panelSubMenuEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubMenuEdit.Name = "panelSubMenuEdit";
            this.panelSubMenuEdit.Size = new System.Drawing.Size(214, 128);
            this.panelSubMenuEdit.TabIndex = 8;
            // 
            // buttonDarkTheme
            // 
            this.buttonDarkTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDarkTheme.FlatAppearance.BorderSize = 0;
            this.buttonDarkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDarkTheme.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonDarkTheme.Image = global::Software_Engineering_Project.Properties.Resources.icons8_layout_32__1_;
            this.buttonDarkTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarkTheme.Location = new System.Drawing.Point(0, 64);
            this.buttonDarkTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDarkTheme.Name = "buttonDarkTheme";
            this.buttonDarkTheme.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.buttonDarkTheme.Size = new System.Drawing.Size(214, 64);
            this.buttonDarkTheme.TabIndex = 6;
            this.buttonDarkTheme.Text = "Dark Theme";
            this.buttonDarkTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarkTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDarkTheme.UseVisualStyleBackColor = true;
            // 
            // buttonLightTheme
            // 
            this.buttonLightTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLightTheme.FlatAppearance.BorderSize = 0;
            this.buttonLightTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLightTheme.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buttonLightTheme.Image = global::Software_Engineering_Project.Properties.Resources.icons8_layout_32;
            this.buttonLightTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLightTheme.Location = new System.Drawing.Point(0, 0);
            this.buttonLightTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLightTheme.Name = "buttonLightTheme";
            this.buttonLightTheme.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.buttonLightTheme.Size = new System.Drawing.Size(214, 64);
            this.buttonLightTheme.TabIndex = 5;
            this.buttonLightTheme.Text = "Light Theme";
            this.buttonLightTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLightTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLightTheme.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonEdit.Image = global::Software_Engineering_Project.Properties.Resources.icons8_settings_32;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(0, 389);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.buttonEdit.Size = new System.Drawing.Size(214, 64);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Tag = "https://icons8.com/icons/set/website";
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.MouseHover += new System.EventHandler(this.ButtonThemeSettings_MouseHover);
            // 
            // SubmissionDockpanel
            // 
            this.SubmissionDockpanel.BackColor = System.Drawing.SystemColors.Info;
            this.SubmissionDockpanel.Controls.Add(this.buttonCreateSubmission);
            this.SubmissionDockpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmissionDockpanel.Location = new System.Drawing.Point(0, 327);
            this.SubmissionDockpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmissionDockpanel.Name = "SubmissionDockpanel";
            this.SubmissionDockpanel.Size = new System.Drawing.Size(214, 62);
            this.SubmissionDockpanel.TabIndex = 9;
            // 
            // buttonCreateSubmission
            // 
            this.buttonCreateSubmission.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateSubmission.FlatAppearance.BorderSize = 0;
            this.buttonCreateSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateSubmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonCreateSubmission.Image = global::Software_Engineering_Project.Properties.Resources.icons8_add_file_32;
            this.buttonCreateSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateSubmission.Location = new System.Drawing.Point(0, 0);
            this.buttonCreateSubmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateSubmission.Name = "buttonCreateSubmission";
            this.buttonCreateSubmission.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.buttonCreateSubmission.Size = new System.Drawing.Size(214, 64);
            this.buttonCreateSubmission.TabIndex = 6;
            this.buttonCreateSubmission.Tag = "https://icons8.com/icons/set/website";
            this.buttonCreateSubmission.Text = "&Create Submissions";
            this.buttonCreateSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCreateSubmission.UseVisualStyleBackColor = true;
            // 
            // buttonSubmission
            // 
            this.buttonSubmission.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSubmission.FlatAppearance.BorderSize = 0;
            this.buttonSubmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmission.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonSubmission.Image = global::Software_Engineering_Project.Properties.Resources.icons8_file_32;
            this.buttonSubmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmission.Location = new System.Drawing.Point(0, 263);
            this.buttonSubmission.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubmission.Name = "buttonSubmission";
            this.buttonSubmission.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.buttonSubmission.Size = new System.Drawing.Size(214, 64);
            this.buttonSubmission.TabIndex = 7;
            this.buttonSubmission.Tag = "https://icons8.com/icons/set/website";
            this.buttonSubmission.Text = "Submissions";
            this.buttonSubmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSubmission.UseVisualStyleBackColor = true;
            this.buttonSubmission.MouseHover += new System.EventHandler(this.ButtonSubmissions_MouseHover);
            // 
            // panelSubMenuFile
            // 
            this.panelSubMenuFile.BackColor = System.Drawing.SystemColors.Info;
            this.panelSubMenuFile.Controls.Add(this.buttonCreateAssignment);
            this.panelSubMenuFile.Controls.Add(this.buttonOpenAssignment);
            this.panelSubMenuFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuFile.Location = new System.Drawing.Point(0, 133);
            this.panelSubMenuFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSubMenuFile.Name = "panelSubMenuFile";
            this.panelSubMenuFile.Size = new System.Drawing.Size(214, 130);
            this.panelSubMenuFile.TabIndex = 6;
            // 
            // buttonCreateAssignment
            // 
            this.buttonCreateAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateAssignment.FlatAppearance.BorderSize = 0;
            this.buttonCreateAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAssignment.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonCreateAssignment.Image = global::Software_Engineering_Project.Properties.Resources.icons8_add_file_32;
            this.buttonCreateAssignment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateAssignment.Location = new System.Drawing.Point(0, 64);
            this.buttonCreateAssignment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateAssignment.Name = "buttonCreateAssignment";
            this.buttonCreateAssignment.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.buttonCreateAssignment.Size = new System.Drawing.Size(214, 64);
            this.buttonCreateAssignment.TabIndex = 5;
            this.buttonCreateAssignment.Tag = "https://icons8.com/icons/set/website";
            this.buttonCreateAssignment.Text = "&Create Assignment";
            this.buttonCreateAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCreateAssignment.UseVisualStyleBackColor = true;
            // 
            // buttonOpenAssignment
            // 
            this.buttonOpenAssignment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOpenAssignment.FlatAppearance.BorderSize = 0;
            this.buttonOpenAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAssignment.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonOpenAssignment.Image = global::Software_Engineering_Project.Properties.Resources.icons8_add_file_32;
            this.buttonOpenAssignment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenAssignment.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenAssignment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenAssignment.Name = "buttonOpenAssignment";
            this.buttonOpenAssignment.Padding = new System.Windows.Forms.Padding(41, 0, 0, 0);
            this.buttonOpenAssignment.Size = new System.Drawing.Size(214, 64);
            this.buttonOpenAssignment.TabIndex = 4;
            this.buttonOpenAssignment.Tag = "https://icons8.com/icons/set/website";
            this.buttonOpenAssignment.Text = "&Open Assignment";
            this.buttonOpenAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenAssignment.UseVisualStyleBackColor = true;
            // 
            // buttonAssignments
            // 
            this.buttonAssignments.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAssignments.FlatAppearance.BorderSize = 0;
            this.buttonAssignments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAssignments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignments.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonAssignments.Image = global::Software_Engineering_Project.Properties.Resources.icons8_file_32;
            this.buttonAssignments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssignments.Location = new System.Drawing.Point(0, 69);
            this.buttonAssignments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAssignments.Name = "buttonAssignments";
            this.buttonAssignments.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.buttonAssignments.Size = new System.Drawing.Size(214, 64);
            this.buttonAssignments.TabIndex = 2;
            this.buttonAssignments.Tag = "https://icons8.com/icons/set/website";
            this.buttonAssignments.Text = "Assignments";
            this.buttonAssignments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssignments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAssignments.UseVisualStyleBackColor = true;
            this.buttonAssignments.MouseHover += new System.EventHandler(this.ButtonAssignments_MouseHover);
            // 
            // listboxSubmissions
            // 
            this.listboxSubmissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listboxSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listboxSubmissions.ItemHeight = 20;
            this.listboxSubmissions.Location = new System.Drawing.Point(240, 34);
            this.listboxSubmissions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listboxSubmissions.Name = "listboxSubmissions";
            this.listboxSubmissions.Size = new System.Drawing.Size(338, 384);
            this.listboxSubmissions.TabIndex = 10;
            this.listboxSubmissions.MouseHover += new System.EventHandler(this.ListboxSubmissions_MouseHover);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.Lbl_ResultsLabel);
            this.panelMain.Controls.Add(this.Lbl_SubmissionsTitle);
            this.panelMain.Controls.Add(this.textBoxResult);
            this.panelMain.Controls.Add(this.listboxSubmissions);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(941, 488);
            this.panelMain.TabIndex = 10;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxResult.Location = new System.Drawing.Point(590, 34);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.PlaceholderText = "Compiled submission results are shown here.";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(338, 384);
            this.textBoxResult.TabIndex = 12;
            this.textBoxResult.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Lbl_SubmissionsTitle
            // 
            this.Lbl_SubmissionsTitle.AutoEllipsis = true;
            this.Lbl_SubmissionsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SubmissionsTitle.Location = new System.Drawing.Point(242, 8);
            this.Lbl_SubmissionsTitle.Name = "Lbl_SubmissionsTitle";
            this.Lbl_SubmissionsTitle.Size = new System.Drawing.Size(336, 23);
            this.Lbl_SubmissionsTitle.TabIndex = 13;
            this.Lbl_SubmissionsTitle.Text = "Submissions: {Assignment Name}";
            // 
            // Lbl_ResultsLabel
            // 
            this.Lbl_ResultsLabel.AutoEllipsis = true;
            this.Lbl_ResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_ResultsLabel.Location = new System.Drawing.Point(590, 8);
            this.Lbl_ResultsLabel.Name = "Lbl_ResultsLabel";
            this.Lbl_ResultsLabel.Size = new System.Drawing.Size(337, 23);
            this.Lbl_ResultsLabel.TabIndex = 14;
            this.Lbl_ResultsLabel.Text = "Results: {Submission Name}";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(941, 488);
            this.Controls.Add(this.panelSideMenuPanel);
            this.Controls.Add(this.PanelMainControls);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Automated Code Metics";
            this.PanelMainControls.ResumeLayout(false);
            this.PanelExit.ResumeLayout(false);
            this.panelSideMenuPanel.ResumeLayout(false);
            this.panelSubMenuHelp.ResumeLayout(false);
            this.panelSubMenuEdit.ResumeLayout(false);
            this.SubmissionDockpanel.ResumeLayout(false);
            this.panelSubMenuFile.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitlecard;
        private ClassCustomButton buttonExecute;
        private ClassCustomButton buttonPrint;
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
        private System.Windows.Forms.ListBox listboxSubmissions;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label Lbl_SubmissionsTitle;
        private System.Windows.Forms.Label Lbl_ResultsLabel;
    }
}

