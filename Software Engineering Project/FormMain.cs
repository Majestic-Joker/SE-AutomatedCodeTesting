using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class FormMain : Form
    {
        #region Properties
        public Assignment CurrentAssignment { get; private set; }
        public DirectoryInfo ProgramDirectory { get; private set; }
        #endregion

        public FormMain()
        {
            InitializeComponent();
            InitializeFormTheme();

            while(!ProgramDirectory.Exists)
                CreateDirectory();

            // TODO: Try to load most recent assignment
        }

        private bool CreateDirectory(){
            string temp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Automated Code Metrics");
            ProgramDirectory = Directory.CreateDirectory(temp);

            return ProgramDirectory.Exists;
        }

        #region Form Theme Functions

        // TODO: Handle with ThemeManager

        private void InitializeFormTheme(){
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

        // TODO: Refactor submenu toggling

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
            }
            else if (subMenu.Visible == true)
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region MouseHover Events
        private void TextboxResults_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(sender as TextBox, "Compilation results and build messages for the selected submission are displayed here");
        }

        private void ListboxSubmissions_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(sender as ListBox, "Assignment submissions are displayed here. Select a Submission to use other form functions");
        }

        private void ButtonPrint_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(sender as Button, "Print contents of the submission results shown above.");
        }
        
        private void ButtonExecute_MouseHover(object sender, EventArgs e){
            toolTipFile.SetToolTip(sender as Button, "Compile and Run submission with this button");
        }

        private void ButtonExit_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(ButtonExit, "Exit here");
        }

        private void ButtonHelp_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonHelp, "Instructions here");
        }

        private void ButtonThemeSettings_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonEdit, "Change Themes here");
        }

        private void ButtonAssignments_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonAssignments, "Open or Create Assignments here");
        }

        private void ButtonSubmissions_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonSubmission, "Open or Create Submissions here");
        }
        #endregion

        #region Menu Buttons

        /// <summary>
        /// Opens the Sub menu for files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAssignments_Click(object sender, EventArgs e)
        {
            ShowSubMenu(Pnl_AssignmentControls);
        }

        private void buttonSubmission_Click(object sender, EventArgs e)
        {
            ShowSubMenu(Pnl_SubmissionControls);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ShowSubMenu(Pnl_ThemeControls);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
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
        private void ButtonOpenAssignment_Click(object sender, EventArgs e)
        {
            Assignment assignment = LoadAssignment();

            if (assignment != null)
            {
                CurrentAssignment = assignment;
            }

            // Hides the Assignment sub menu after use
            HideSubMenu();
        }

        // TODO: Implement ThemeManager class to handle Light/Dark mode in FormMain.cs

        /// <summary>
        /// This button gives you the ability to go back to the normal theme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLightTheme_Click(object sender, EventArgs e)
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
        private void ButtonDarkTheme_Click(object sender, EventArgs e)
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
        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Start, Click File " +
                "then Open File. After that it'll take you" +
                " to where you can get a cpp file. Click on OK and it will show up on the listbox." +
                " We then can click run to get the stats and grade of the program." +
                " Lastly we can view the Stats.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HideSubMenu();
        }

        /// <summary>
        /// Button launches OpenFormCreateAssignment method and hides the sub menu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateAssignment_Click(object sender, EventArgs e)
        {
            OpenFormCreateAssignment();
            HideSubMenu();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateSubmission_Click(object sender, EventArgs e)
        {
            var form = new FormAddSubmission(CurrentAssignment.AssignmentDirectory.FullName);

            if (form.ShowDialog() == DialogResult.OK)
            {
                CurrentAssignment.Submissions.Add(form.submission);
                listboxSubmissions.Items.Add(form.submission);
                listboxSubmissions.Refresh();
                SaveCurrentAssignment();
            }

            form.Dispose();
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
            }
            form.Dispose();
        }

        /// <summary>
        /// Method serializes the currentAssignment as json and saves it inside the folder with its name
        /// </summary>
        private void SaveCurrentAssignment()
        {
            if(!ProgramDirectory.Exists)
                CreateDirectory();

            if(CurrentAssignment != null){
                // Serialize CurrentAssignment as json
                string json = JsonSerializer.Serialize(CurrentAssignment);

                // folderpath created
                if(!CurrentAssignment.AssignmentDirectory.Exists) 
                    CurrentAssignment.AssignmentDirectory = ProgramDirectory.CreateSubdirectory(CurrentAssignment.AssignmentName);

                string temp = Path.Combine(CurrentAssignment.AssignmentDirectory.FullName, $"{CurrentAssignment.AssignmentName}.json");

                // written user info to json
                File.WriteAllText(temp, json);
            }
        }
        #endregion

        #region Compiler Buttons
        /// <summary>
        /// Compiles and Runs code from the selected Submission in listboxSubmissions
        /// </summary>
        /// <param name="sender">The object running this event</param>
        /// <param name="e">The EventArguments</param>
        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            int selectedIndex = listboxSubmissions.SelectedIndex;
            bool didCompile = false;
            
            // TODO: Ensure the listboxSubmissions is the same list as CurrentAssignment.Submissions
            //If a file is selected  
            if (CurrentAssignment != null)
            {
                if (CurrentAssignment.Submissions.Count > 0)
                {
                    Submission selectedSubmission = CurrentAssignment.Submissions[selectedIndex];
                    didCompile = RunCompilerService(selectedSubmission);
                    UpdateResultText(selectedSubmission);
                }
            }

            if (didCompile)
            {
                MessageBox.Show("Compilation sucessful");
            }
            else
            {
                MessageBox.Show("Compilation failed");
            }

            SaveCurrentAssignment();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
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
                    UpdateResultText(selectedSubmission);

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
                CppService service = new CppService(CurrentAssignment, selectedSubmission);
                return service.IsBuilt;
            }

            return false;
        }
        #endregion

        #pragma warning disable CA1416
        private void UpdateResultText(Submission selectedSubmission)
        {
            printDocument1.DocumentName = $"{selectedSubmission.StudentName}_Results";
            textBoxResult.Text = selectedSubmission.Result.ToString();
        }

        private void PrintResults(object sender, PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;
            string resultText = textBoxResult.Text;
            Font resultFont = textBoxResult.Font;

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
                resultText = textBoxResult.Text;
        }
        #pragma warning restore CA1416

        #region Exit Button

        /// <summary>
        /// exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (CurrentAssignment != null)
            {
                SaveCurrentAssignment();
            }
            Application.Exit();
        }

        #endregion
    }
}
