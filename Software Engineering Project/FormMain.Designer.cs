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
            this.listBoxProjectOpener = new System.Windows.Forms.ListBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelMainControls = new System.Windows.Forms.Panel();
            this.PanelExit = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panelSideMenuPanel = new System.Windows.Forms.Panel();
            this.panelSubMenuHelp = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonProgramGrader = new System.Windows.Forms.Button();
            this.panelSubMenuEdit = new System.Windows.Forms.Panel();
            this.buttonDarkTheme = new System.Windows.Forms.Button();
            this.buttonLightTheme = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelSubMenuFile = new System.Windows.Forms.Panel();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.toolTipFile = new System.Windows.Forms.ToolTip(this.components);
            this.buttonView = new Software_Engineering_Project.ClassCustomButton();
            this.buttonRun = new Software_Engineering_Project.ClassCustomButton();
            this.panelMain.SuspendLayout();
            this.PanelMainControls.SuspendLayout();
            this.PanelExit.SuspendLayout();
            this.panelSideMenuPanel.SuspendLayout();
            this.panelSubMenuHelp.SuspendLayout();
            this.panelSubMenuEdit.SuspendLayout();
            this.panelSubMenuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitlecard
            // 
            this.labelTitlecard.BackColor = System.Drawing.SystemColors.Info;
            this.labelTitlecard.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitlecard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlecard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTitlecard.Location = new System.Drawing.Point(0, 0);
            this.labelTitlecard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitlecard.Name = "labelTitlecard";
            this.labelTitlecard.Size = new System.Drawing.Size(177, 60);
            this.labelTitlecard.TabIndex = 1;
            this.labelTitlecard.Text = "PROGRAM GRADER";
            // 
            // listBoxProjectOpener
            // 
            this.listBoxProjectOpener.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxProjectOpener.Location = new System.Drawing.Point(207, 10);
            this.listBoxProjectOpener.Name = "listBoxProjectOpener";
            this.listBoxProjectOpener.Size = new System.Drawing.Size(278, 290);
            this.listBoxProjectOpener.TabIndex = 10;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(509, 10);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(278, 290);
            this.listBoxOutput.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.listBoxOutput);
            this.panelMain.Controls.Add(this.listBoxProjectOpener);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(806, 423);
            this.panelMain.TabIndex = 10;
            // 
            // PanelMainControls
            // 
            this.PanelMainControls.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PanelMainControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMainControls.Controls.Add(this.PanelExit);
            this.PanelMainControls.Controls.Add(this.buttonView);
            this.PanelMainControls.Controls.Add(this.buttonRun);
            this.PanelMainControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMainControls.Location = new System.Drawing.Point(0, 314);
            this.PanelMainControls.Name = "PanelMainControls";
            this.PanelMainControls.Size = new System.Drawing.Size(806, 109);
            this.PanelMainControls.TabIndex = 11;
            // 
            // PanelExit
            // 
            this.PanelExit.BackColor = System.Drawing.SystemColors.Info;
            this.PanelExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelExit.Controls.Add(this.ButtonExit);
            this.PanelExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelExit.Location = new System.Drawing.Point(0, 0);
            this.PanelExit.Name = "PanelExit";
            this.PanelExit.Size = new System.Drawing.Size(200, 107);
            this.PanelExit.TabIndex = 10;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Image = global::Software_Engineering_Project.Properties.Resources.icons8_exit_48;
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.Location = new System.Drawing.Point(10, 25);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(166, 61);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Tag = "https://icons8.com/icons/set/website";
            this.ButtonExit.Text = "&Exit";
            this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panelSideMenuPanel
            // 
            this.panelSideMenuPanel.AutoScroll = true;
            this.panelSideMenuPanel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelSideMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSideMenuPanel.Controls.Add(this.panelSubMenuHelp);
            this.panelSideMenuPanel.Controls.Add(this.buttonHelp);
            this.panelSideMenuPanel.Controls.Add(this.buttonProgramGrader);
            this.panelSideMenuPanel.Controls.Add(this.panelSubMenuEdit);
            this.panelSideMenuPanel.Controls.Add(this.buttonEdit);
            this.panelSideMenuPanel.Controls.Add(this.panelSubMenuFile);
            this.panelSideMenuPanel.Controls.Add(this.buttonFile);
            this.panelSideMenuPanel.Controls.Add(this.labelTitlecard);
            this.panelSideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenuPanel.Name = "panelSideMenuPanel";
            this.panelSideMenuPanel.Size = new System.Drawing.Size(200, 314);
            this.panelSideMenuPanel.TabIndex = 12;
            // 
            // panelSubMenuHelp
            // 
            this.panelSubMenuHelp.BackColor = System.Drawing.SystemColors.Info;
            this.panelSubMenuHelp.Controls.Add(this.buttonAbout);
            this.panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuHelp.Location = new System.Drawing.Point(0, 450);
            this.panelSubMenuHelp.Name = "panelSubMenuHelp";
            this.panelSubMenuHelp.Size = new System.Drawing.Size(177, 61);
            this.panelSubMenuHelp.TabIndex = 11;
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
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAbout.Size = new System.Drawing.Size(177, 55);
            this.buttonAbout.TabIndex = 6;
            this.buttonAbout.Tag = "https://icons8.com/icons/set/website";
            this.buttonAbout.Text = "About";
            this.buttonAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
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
            this.buttonHelp.Location = new System.Drawing.Point(0, 395);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonHelp.Size = new System.Drawing.Size(177, 55);
            this.buttonHelp.TabIndex = 10;
            this.buttonHelp.Tag = "https://icons8.com/icons/set/website";
            this.buttonHelp.Text = "Help";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // buttonProgramGrader
            // 
            this.buttonProgramGrader.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProgramGrader.FlatAppearance.BorderSize = 0;
            this.buttonProgramGrader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonProgramGrader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgramGrader.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonProgramGrader.Image = global::Software_Engineering_Project.Properties.Resources.icons8_grades_32;
            this.buttonProgramGrader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProgramGrader.Location = new System.Drawing.Point(0, 340);
            this.buttonProgramGrader.Name = "buttonProgramGrader";
            this.buttonProgramGrader.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonProgramGrader.Size = new System.Drawing.Size(177, 55);
            this.buttonProgramGrader.TabIndex = 9;
            this.buttonProgramGrader.Text = "Program Grader";
            this.buttonProgramGrader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProgramGrader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProgramGrader.UseVisualStyleBackColor = true;
            this.buttonProgramGrader.Click += new System.EventHandler(this.ButtonProgramGrader_Click);
            // 
            // panelSubMenuEdit
            // 
            this.panelSubMenuEdit.BackColor = System.Drawing.SystemColors.Info;
            this.panelSubMenuEdit.Controls.Add(this.buttonDarkTheme);
            this.panelSubMenuEdit.Controls.Add(this.buttonLightTheme);
            this.panelSubMenuEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEdit.Location = new System.Drawing.Point(0, 229);
            this.panelSubMenuEdit.Name = "panelSubMenuEdit";
            this.panelSubMenuEdit.Size = new System.Drawing.Size(177, 111);
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
            this.buttonDarkTheme.Location = new System.Drawing.Point(0, 55);
            this.buttonDarkTheme.Name = "buttonDarkTheme";
            this.buttonDarkTheme.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonDarkTheme.Size = new System.Drawing.Size(177, 55);
            this.buttonDarkTheme.TabIndex = 6;
            this.buttonDarkTheme.Text = "Dark Theme";
            this.buttonDarkTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDarkTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDarkTheme.UseVisualStyleBackColor = true;
            this.buttonDarkTheme.Click += new System.EventHandler(this.ButtonDarkTheme_Click);
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
            this.buttonLightTheme.Name = "buttonLightTheme";
            this.buttonLightTheme.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLightTheme.Size = new System.Drawing.Size(177, 55);
            this.buttonLightTheme.TabIndex = 5;
            this.buttonLightTheme.Text = "Light Theme";
            this.buttonLightTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLightTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLightTheme.UseVisualStyleBackColor = true;
            this.buttonLightTheme.Click += new System.EventHandler(this.ButtonLightTheme_Click);
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
            this.buttonEdit.Location = new System.Drawing.Point(0, 174);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonEdit.Size = new System.Drawing.Size(177, 55);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.Tag = "https://icons8.com/icons/set/website";
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // panelSubMenuFile
            // 
            this.panelSubMenuFile.BackColor = System.Drawing.SystemColors.Info;
            this.panelSubMenuFile.Controls.Add(this.buttonOpenFile);
            this.panelSubMenuFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuFile.Location = new System.Drawing.Point(0, 115);
            this.panelSubMenuFile.Name = "panelSubMenuFile";
            this.panelSubMenuFile.Size = new System.Drawing.Size(177, 59);
            this.panelSubMenuFile.TabIndex = 6;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOpenFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonOpenFile.Image = global::Software_Engineering_Project.Properties.Resources.icons8_add_file_32;
            this.buttonOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonOpenFile.Size = new System.Drawing.Size(177, 55);
            this.buttonOpenFile.TabIndex = 4;
            this.buttonOpenFile.Tag = "https://icons8.com/icons/set/website";
            this.buttonOpenFile.Text = "&Open File";
            this.buttonOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFile.FlatAppearance.BorderSize = 0;
            this.buttonFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonFile.Image = global::Software_Engineering_Project.Properties.Resources.icons8_file_32;
            this.buttonFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFile.Location = new System.Drawing.Point(0, 60);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonFile.Size = new System.Drawing.Size(177, 55);
            this.buttonFile.TabIndex = 2;
            this.buttonFile.Tag = "https://icons8.com/icons/set/website";
            this.buttonFile.Text = "File";
            this.buttonFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.ButtonFile_Click);
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Location = new System.Drawing.Point(509, 26);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(278, 61);
            this.buttonView.TabIndex = 8;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(207, 26);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(278, 61);
            this.buttonRun.TabIndex = 9;
            this.buttonRun.Text = "Run";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(806, 423);
            this.Controls.Add(this.panelSideMenuPanel);
            this.Controls.Add(this.PanelMainControls);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Home";
            this.panelMain.ResumeLayout(false);
            this.PanelMainControls.ResumeLayout(false);
            this.PanelExit.ResumeLayout(false);
            this.panelSideMenuPanel.ResumeLayout(false);
            this.panelSubMenuHelp.ResumeLayout(false);
            this.panelSubMenuEdit.ResumeLayout(false);
            this.panelSubMenuFile.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelSubMenuHelp;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonProgramGrader;
        private System.Windows.Forms.Panel panelSubMenuEdit;
        private System.Windows.Forms.Button buttonDarkTheme;
        private System.Windows.Forms.Button buttonLightTheme;
        private System.Windows.Forms.Panel PanelExit;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ToolTip toolTipFile;
    }
}

