using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class FormMain:Form
    {
        private FileInfo recentAssignment;

        #region Properties
        public Assignment CurrentAssignment
        {
            get; private set;
        }
        public DirectoryInfo ProgramDirectory
        {
            get; private set;
        }
        public Submission SelectedSubmission => SelectedSubmissionIndex >= 0 ? CurrentAssignment.Submissions[SelectedSubmissionIndex] : null;
        public int SelectedSubmissionIndex => listboxSubmissions.SelectedIndex;
        #endregion

        public FormMain()
        {
            InitializeComponent();
            InitializeFormTheme();
            SetupTooltip();

            CreateDirectory();
            recentAssignment = new FileInfo(Path.Combine(ProgramDirectory.FullName,"recent.json"));

            if (recentAssignment.Exists)
                LoadRecentAssignment();
        }

        private bool CreateDirectory()
        {
            string temp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"Automated Code Metrics");
            ProgramDirectory = Directory.CreateDirectory(temp);
            return ProgramDirectory.Exists;
        }

        private void SetupTooltip()
        {
            toolTipFile.SetToolTip(Rtb_Results,"Compilation results and build messages for the selected submission are displayed here");
            toolTipFile.SetToolTip(listboxSubmissions,"Assignment submissions are displayed here. Select a Submission to use other form functions");
            toolTipFile.SetToolTip(buttonPrint,"Print contents of the submission results shown above.");
            toolTipFile.SetToolTip(buttonExecute,"Compile and Run submission with this button");
            toolTipFile.SetToolTip(ButtonExit,"Exit here");
            toolTipFile.SetToolTip(buttonHelp,"Instructions here");
            toolTipFile.SetToolTip(buttonEdit,"Change Themes here");
            toolTipFile.SetToolTip(buttonAssignments,"Open or Create Assignments here");
            toolTipFile.SetToolTip(buttonSubmission,"Open or Create Submissions here");
        }

        #region Form Theme Functions

        // TODO: Stretch Goal - Handle theme initialization with ThemeManager

        private void InitializeFormTheme()
        {
            panelMain.BackColor = Color.LightGray;
            labelTitlecard.BackColor = Color.Tan;
            panelSideMenuPanel.BackColor = Color.WhiteSmoke;
            buttonAssignments.ForeColor = Color.Black;
            buttonEdit.ForeColor = Color.Black;
            buttonHelp.ForeColor = Color.Black;
            //buttonProgramGrader.ForeColor = Color.Black;
            Pnl_AssignmentControls.BackColor = Color.Tan;
            Pnl_ThemeControls.BackColor = Color.Tan;
            Pnl_HelpControls.BackColor = Color.Tan;
            Pnl_SubmissionControls.BackColor = Color.Tan;
            buttonLightTheme.ForeColor = Color.Black;
            buttonDarkTheme.ForeColor = Color.Black;
            buttonAbout.ForeColor = Color.Black;
            buttonOpenAssignment.ForeColor = Color.Black;
            PanelExit.BackColor = Color.Tan;
            PanelMainControls.BackColor = Color.Gray;
        }

        // TODO: Stretch Goal - Refactor submenu toggling

        /// <summary>
        /// Hides Sub Menus after clicked on
        /// </summary>
        private void HideSubMenu()
        {
            if (Pnl_AssignmentControls.Visible == true)
            {
                Pnl_AssignmentControls.Visible = false;
            }
            if (Pnl_ThemeControls.Visible == true)
            {
                Pnl_ThemeControls.Visible = false;
            }
            if (Pnl_HelpControls.Visible == true)
            {
                Pnl_HelpControls.Visible = false;
            }
            if (Pnl_SubmissionControls.Visible == true)
            {
                Pnl_SubmissionControls.Visible = false;
            }
        }

        /// <summary>
        /// Shows the sub menus when main buttons are clicked
        /// </summary>
        /// <param name="subMenu"></param>
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            } else if (subMenu.Visible == true)
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region Menu Buttons

        /// <summary>
        /// Opens the Sub menu for files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAssignments_Click(object sender,EventArgs e)
        {
            ShowSubMenu(Pnl_AssignmentControls);
        }

        private void buttonSubmission_Click(object sender,EventArgs e)
        {
            ShowSubMenu(Pnl_SubmissionControls);
        }

        private void buttonEdit_Click(object sender,EventArgs e)
        {
            ShowSubMenu(Pnl_ThemeControls);
        }

        private void buttonHelp_Click(object sender,EventArgs e)
        {
            ShowSubMenu(Pnl_HelpControls);
        }

        #endregion

        #region Sub Menu Buttons
        /// <summary>
        /// Button launches LoadAssignment method and sets the Current Assignment property if LoadAssignment is successful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenAssignment_Click(object sender,EventArgs e)
        {
            Assignment assignment = LoadAssignment();

            if (assignment != null)
            {
                SaveCurrentAssignment();
                CurrentAssignment = assignment;
                SaveCurrentAssignment();
                SetAssignmentTitle();
            }

            // Hides the Assignment sub menu after use
            HideSubMenu();
        }

        // TODO: Stretch Goal - Implement ThemeManager class to handle Light/Dark mode in FormMain.cs

        /// <summary>
        /// This button gives you the ability to go back to the normal theme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLightTheme_Click(object sender,EventArgs e)
        {
            panelMain.BackColor = Color.LightGray;
            labelTitlecard.BackColor = Color.Tan;
            panelSideMenuPanel.BackColor = Color.WhiteSmoke;
            buttonAssignments.ForeColor = Color.Black;
            buttonEdit.ForeColor = Color.Black;
            buttonHelp.ForeColor = Color.Black;
            //buttonProgramGrader.ForeColor = Color.Black;
            Pnl_AssignmentControls.BackColor = Color.Tan;
            Pnl_ThemeControls.BackColor = Color.Tan;
            Pnl_HelpControls.BackColor = Color.Tan;
            Pnl_SubmissionControls.BackColor = Color.Tan;
            buttonLightTheme.ForeColor = Color.Black;
            buttonDarkTheme.ForeColor = Color.Black;
            buttonAbout.ForeColor = Color.Black;
            buttonOpenAssignment.ForeColor = Color.Black;
            PanelExit.BackColor = Color.Tan;
            PanelMainControls.BackColor = Color.Gray;

            HideSubMenu();
        }

        /// <summary>
        /// This button gives you the ability to go to a dark theme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDarkTheme_Click(object sender,EventArgs e)
        {
            panelMain.BackColor = Color.SlateGray;
            labelTitlecard.BackColor = Color.DarkSlateGray;
            Pnl_SubmissionControls.BackColor = Color.DarkSlateGray;
            buttonSubmission.ForeColor = Color.White;
            panelSideMenuPanel.BackColor = Color.Black;
            buttonAssignments.ForeColor = Color.White;
            buttonCreateAssignment.ForeColor = Color.White;
            buttonCreateSubmission.ForeColor = Color.White;
            //buttonOpenSubmission.ForeColor = Color.White;
            buttonEdit.ForeColor = Color.White;
            buttonHelp.ForeColor = Color.White;
            //buttonProgramGrader.ForeColor = Color.White;
            Pnl_AssignmentControls.BackColor = Color.DarkSlateGray;
            Pnl_ThemeControls.BackColor = Color.DarkSlateGray;
            Pnl_HelpControls.BackColor = Color.DarkSlateGray;
            buttonLightTheme.ForeColor = Color.White;
            buttonDarkTheme.ForeColor = Color.White;
            buttonAbout.ForeColor = Color.White;
            buttonOpenAssignment.ForeColor = Color.White;
            PanelExit.BackColor = Color.DarkSlateGray;
            PanelMainControls.BackColor = Color.Black;
            HideSubMenu();
        }

        /// <summary>
        /// Helpful tab for how to run this program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAbout_Click(object sender,EventArgs e)
        {
            MessageBox.Show("To Start, Click File " +
                "then Open File. After that it'll take you" +
                " to where you can get a cpp file. Click on OK and it will show up on the listbox." +
                " We then can click run to get the stats and grade of the program." +
                " Lastly we can view the Stats.","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
            HideSubMenu();
        }

        /// <summary>
        /// Button launches OpenFormCreateAssignment method and hides the sub menu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateAssignment_Click(object sender,EventArgs e)
        {
            OpenFormCreateAssignment();
            HideSubMenu();
            SetAssignmentTitle();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateSubmission_Click(object sender,EventArgs e)
        {
            if (CurrentAssignment != null)
            {
                var form = new FormAddSubmission(CurrentAssignment);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    CurrentAssignment.Submissions.Add(form.submission);
                    RefreshListBox();
                    SaveCurrentAssignment();
                }

                form.Dispose();
            } 
            else
                MessageBox.Show("Must have an assignment open before adding submissions.","Unable to Add Submission - Missing Requirements",MessageBoxButtons.OK);
        }
        #endregion

        #region Sub Menu Methods
        /// <summary>
        /// uses open file dialog to create an assignment from a json file
        /// </summary>
        /// <returns></returns>
        public Assignment LoadAssignment()
        {
            Assignment assignment = null;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;

                var filestream = openFileDialog.OpenFile();
                var reader = new StreamReader(filestream);

                string json = reader.ReadToEnd();
                assignment = JsonSerializer.Deserialize<Assignment>(json);
                UpdateResultText();
                RefreshListBox();
            }

            return assignment;
        }

        /// <summary>
        /// Method opens create assignment form, if assignment is created, sets the current assignment
        /// </summary>
        private void OpenFormCreateAssignment()
        {
            SaveCurrentAssignment();

            var form = new FormCreateAssignment(ProgramDirectory);

            if (form.ShowDialog() == DialogResult.OK)
            {
                CurrentAssignment = form.assignment;
                SaveCurrentAssignment();
                SetAssignmentTitle();
            }
            form.Dispose();
        }

        /// <summary>
        /// Method serializes the currentAssignment as json and saves it inside the folder with its name
        /// </summary>
        private void SaveCurrentAssignment()
        {
            if (!ProgramDirectory.Exists)
                CreateDirectory();

            if (CurrentAssignment != null)
            {
                // Serialize CurrentAssignment as json
                string json = JsonSerializer.Serialize(CurrentAssignment, new JsonSerializerOptions{ WriteIndented = true });

                // folderpath created
                if (!Directory.Exists(CurrentAssignment.AssignmentDirectory))
                {
                    CurrentAssignment.AssignmentDirectory = ProgramDirectory.CreateSubdirectory(CurrentAssignment.AssignmentName).FullName;
                    CurrentAssignment.AssignmentFile = Path.Combine(CurrentAssignment.AssignmentDirectory,$"{CurrentAssignment.AssignmentName}.json");
                }
                // written user info to json
                WriteFile(CurrentAssignment.AssignmentFile,json);
            }
        }

        private void SaveRecentAssignment()
        {
            if (CurrentAssignment != null)
            {
                WriteFile(recentAssignment.FullName,JsonSerializer.Serialize(CurrentAssignment, new JsonSerializerOptions{ WriteIndented = true }));
            }
        }

        private async void WriteFile(string filePath,string text)
        {
            var task = File.WriteAllTextAsync(filePath,text);

            while (!task.IsCompleted)
                await System.Threading.Tasks.Task.Delay(50);
        }

        private void LoadRecentAssignment()
        {
            var filestream = recentAssignment.OpenRead();
            var reader = new StreamReader(filestream);

            string json = reader.ReadToEnd();
            CurrentAssignment = JsonSerializer.Deserialize<Assignment>(json);

            SetAssignmentTitle();
            RefreshListBox();
        }
        #endregion

        #region Compiler Buttons
        /// <summary>
        /// Compiles and Runs code from the selected Submission in listboxSubmissions
        /// </summary>
        /// <param name="sender">The object running this event</param>
        /// <param name="e">The EventArguments</param>
        private void ButtonExecute_Click(object sender,EventArgs e)
        {
            //If a file is selected  
            if (CurrentAssignment != null)
            {
                if (CurrentAssignment.Submissions.Count > 0)
                {
                    RunCompilerService(SelectedSubmission);
                    UpdateResultText();
                }
            }
            SaveCurrentAssignment();
        }

        private void ButtonPrint_Click(object sender,EventArgs e)
        {
            //Placeholder for printing from the textBoxResult.text
            int selectedIndex = listboxSubmissions.SelectedIndex;
            if (CurrentAssignment != null)
            {
                if (CurrentAssignment.Submissions.Count > 0)
                {
                    Submission selectedSubmission = CurrentAssignment.Submissions[selectedIndex];
                    if (selectedSubmission.Result == null)
                        selectedSubmission.Result = new Result();
                    UpdateResultText();

                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
            }
        }
        #endregion

        #region Compiler Methods
        private bool RunCompilerService(Submission selectedSubmission)
        {
            if (selectedSubmission != null)
            {
                CppService service = new CppService(CurrentAssignment,selectedSubmission);
                return service.IsBuilt;
            }

            return false;
        }
        #endregion

        private void UpdateResultText()
        {
            printDocument1.DocumentName = $"{SelectedSubmission.SubmissionName}_Results";
            Rtb_Results.Text = SelectedSubmission.Result.ToString();
            Rtb_Results.Refresh();
        }

        private void RefreshListBox(){
            if(CurrentAssignment != null && CurrentAssignment.Submissions.Count > 0){
                listboxSubmissions.Items.Clear();

                foreach(Submission submission in CurrentAssignment.Submissions)
                    listboxSubmissions.Items.Add(submission);

                listboxSubmissions.Refresh();
            }
        }

        private void SetAssignmentTitle(){
            if (CurrentAssignment != null)
                Lbl_SubmissionsTitle.Text = $"Submissions: {CurrentAssignment.AssignmentName}";                
        }

        //TODO: figure out print preview not showing what's in Rtb_Results
        private void PrintResults(object sender,PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;
            string resultText = Rtb_Results.Text;
            Font resultFont = Rtb_Results.Font;

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            SizeF sizeF = e.Graphics.MeasureString(resultText,resultFont,e.MarginBounds.Size,StringFormat.GenericTypographic,out charactersOnPage,out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(resultText,resultFont,Brushes.Black,e.MarginBounds,StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            resultText = resultText.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (resultText.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                resultText = Rtb_Results.Text;
        }

        #region Exit Button

        /// <summary>
        /// exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender,EventArgs e)
        {
            if (CurrentAssignment != null)
            {
                SaveCurrentAssignment();
            }
            Application.Exit();
        }

        #endregion

        private void listboxSubmissions_SelectedIndexChanged(object sender,EventArgs e)
        {
            if (SelectedSubmissionIndex >= 0)
            {
                Lbl_ResultsLabel.Text = $"Results: {CurrentAssignment.Submissions[SelectedSubmissionIndex]}";
                UpdateResultText();
            }
        }

        private void FormMain_FormClosing(object sender,FormClosingEventArgs e)
        {
            if (CurrentAssignment != null)
            {
                SaveCurrentAssignment();
                SaveRecentAssignment();
            }
        }

        private void labelTitlecard_Click(object sender,EventArgs e)
        {
            if (CurrentAssignment != null)
                MessageBox.Show(CurrentAssignment.ToString(),$"State of {CurrentAssignment.AssignmentName}",MessageBoxButtons.OK);
            else
                MessageBox.Show("Current Assignment is null.",$"State of the current assignment",MessageBoxButtons.OK);
        }
    }
}
