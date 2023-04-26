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
        #region member variables

        // forms
        //readonly FormCreateAssignment formCreateAssignment = new FormCreateAssignment();

        public Assignment? currentAssignment = null;
        //readonly FormAddSubmissions formAddSubmissions = new FormAddSubmissions();

        #endregion

        public FormMain()
        {
            InitializeComponent();

            #region form
            panelMain.BackColor = Color.LightGray;
            labelTitlecard.BackColor = Color.Tan;
            panelSideMenuPanel.BackColor = Color.WhiteSmoke;
            buttonAssignments.ForeColor = Color.Black;
            buttonEdit.ForeColor = Color.Black;
            buttonHelp.ForeColor = Color.Black;
            //buttonProgramGrader.ForeColor = Color.Black;
            panelSubMenuFile.BackColor = Color.Tan;
            panelSubMenuEdit.BackColor = Color.Tan;
            panelSubMenuHelp.BackColor = Color.Tan;
            SubmissionDockpanel.BackColor = Color.Tan;
            buttonLightTheme.ForeColor = Color.Black;
            buttonDarkTheme.ForeColor = Color.Black;
            buttonAbout.ForeColor = Color.Black;
            buttonOpenAssignment.ForeColor = Color.Black;
            PanelExit.BackColor = Color.Tan;
            PanelMainControls.BackColor = Color.Gray;
            #endregion

            // Hides submenus initially
            SubMenuDesign();

            buttonRun.Enabled = false;
            buttonView.Enabled = false;

            #region Events
            buttonAssignments.MouseHover += ButtonFile_MouseHover;
            buttonSubmission.MouseHover += ButtonSubmission_MouseHover;
            buttonEdit.MouseHover += ButtonEdit_MouseHover;
            buttonHelp.MouseHover += ButtonHelp_MouseHover;
            ButtonExit.MouseHover += ButtonExit_MouseHover;
            buttonRun.MouseHover += ButtonRun_MouseHover;
            buttonView.MouseHover += ButtonView_MouseHover;
            listBoxProjectOpener.MouseHover += ListBoxProjectOpener_MouseHover;
            listBoxOutput.MouseHover += ListBoxOutput_MouseHover;
            #endregion
        }

        #region MouseHover ToolTips
        private void ListBoxOutput_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(listBoxOutput, "Code will be Here");
        }

        private void ListBoxProjectOpener_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(listBoxProjectOpener, "Files will be placed here");
        }

        private void ButtonView_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonView, "View Statistics and more here");
        }

        private void ButtonRun_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonRun, "Run Code here");
        }

        private void ButtonExit_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(ButtonExit, "Exit here");
        }

        private void ButtonHelp_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonHelp, "Instructions here");
        }

        private void ButtonEdit_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonEdit, "Change Themes here");
        }

        private void ButtonFile_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonAssignments, "Open or Create Assignments here");
        }

        private void ButtonSubmission_MouseHover(object sender, EventArgs e)
        {
            toolTipFile.SetToolTip(buttonSubmission, "Open or Create Submissions here");
        }
        #endregion

        #region Sub Menu Stuff

        /// <summary>
        /// Hides all SubMenus
        /// </summary>
        private void SubMenuDesign()
        {
            panelSubMenuFile.Visible = false;
            panelSubMenuEdit.Visible = false;
            panelSubMenuHelp.Visible = false;
            SubmissionDockpanel.Visible = false;
        }

        /// <summary>
        /// Hides Sub Menus after clicked on
        /// </summary>
        private void HideSubMenu()
        {
            if (panelSubMenuFile.Visible == true)
            {
                panelSubMenuFile.Visible = false;
            }
            if (panelSubMenuEdit.Visible == true)
            {
                panelSubMenuEdit.Visible = false;
            }
            if (panelSubMenuHelp.Visible == true)
            {
                panelSubMenuHelp.Visible = false;
            }
            if (SubmissionDockpanel.Visible == true)
            {
                SubmissionDockpanel.Visible = false;
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

        #region Compiler Buttons
        /// <summary>
        /// Supposed to take and run the code from ListBoxProjectOpener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRun_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxProjectOpener.SelectedIndex;
            bool didCompile = false;
            //If a file is selected  
            if(currentAssignment != null ){
                if(currentAssignment.Submissions.Count > 0) {
                    Submission selectedSubmission = currentAssignment.Submissions[selectedIndex];
                    didCompile = RunCompilerService(selectedSubmission);
                    UpdateResultText(selectedSubmission);
                }
            } 

            if(didCompile){
                MessageBox.Show("Compilation sucessful");
            }
            else{
                MessageBox.Show("Compilation failed");
            }

            saveCurrentAssignment();
        }

        private void ButtonPrint_Click(object sender, EventArgs e){
            //Placeholder for printing from the textBoxResult.text
            int selectedIndex = listBoxProjectOpener.SelectedIndex;
            if(currentAssignment != null ){
                if(currentAssignment.Submissions.Count > 0) {
                    Submission selectedSubmission = currentAssignment.Submissions[selectedIndex];
                    if(selectedSubmission.Result == null)
                        selectedSubmission.Result = new Result();
                    UpdateResultText(selectedSubmission);

                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
            }
        }
        #endregion

        #region Sub Menu Buttons

        /// <summary>
        /// Part of Submenu and its goal is to open files and store them in Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            Assignment assignment = LoadAssignment();

            if (assignment != null)
            {
                currentAssignment = assignment;
            }
            // Hides the Open File button after use
            HideSubMenu();
        }

        /// <summary>
        /// uses open file dialog to get json file
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
            panelSubMenuFile.BackColor = Color.Tan;
            panelSubMenuEdit.BackColor = Color.Tan;
            panelSubMenuHelp.BackColor = Color.Tan;
            SubmissionDockpanel.BackColor = Color.Tan;
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
            SubmissionDockpanel.BackColor = Color.DarkSlateGray;
            buttonSubmission.ForeColor = Color.White;
            panelSideMenuPanel.BackColor = Color.Black;
            buttonAssignments.ForeColor = Color.White;
            buttonCreateAssignment.ForeColor = Color.White;
            buttonCreateSubmission.ForeColor = Color.White;
            buttonOpenSubmission.ForeColor = Color.White;
            buttonEdit.ForeColor = Color.White;
            buttonHelp.ForeColor = Color.White;
            //buttonProgramGrader.ForeColor = Color.White;
            panelSubMenuFile.BackColor = Color.DarkSlateGray;
            panelSubMenuEdit.BackColor = Color.DarkSlateGray;
            panelSubMenuHelp.BackColor = Color.DarkSlateGray;
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
        /// opens create assignment form. create assignment gives the user the ability to make assignments 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateAssignment_Click(object sender, EventArgs e)
        {
            OpenFormCreateAssignment();
            HideSubMenu();
        }

        /// <summary>
        /// opens create assignment form and brings it to front
        /// </summary>
        private void OpenFormCreateAssignment()
        {
            var form = new FormCreateAssignment();
            if (form.ShowDialog() == DialogResult.OK)
            {
                currentAssignment = form.assignment;
                saveCurrentAssignment();
            }
            form.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateSubmission_Click(object sender, EventArgs e)
        {
            var form = new FormAddSubmission(currentAssignment.AssignmentDirectory);

            if (form.ShowDialog() == DialogResult.OK)
            {
                currentAssignment.Submissions.Add(form.submission);
                listBoxProjectOpener.Items.Add(form.submission);
                listBoxProjectOpener.Refresh();
                saveCurrentAssignment();
            }
            form.Dispose();
        }

        // add a save current assignment method
        /* save json */
        private void saveCurrentAssignment()
        {
            // creates a folder called CppGrader
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CppGrader");

            // serialize
            string json = JsonSerializer.Serialize(currentAssignment);

            // folderpath created
            folderPath = Path.Combine(folderPath, currentAssignment.AssignmentName);
            Directory.CreateDirectory(folderPath);

            string temp = Path.Combine(folderPath, $"{currentAssignment.AssignmentName}.json");

            // written user info to json
            File.WriteAllText(temp, json);
        }

        #endregion

        #region Menu Buttons

        /// <summary>
        /// Opens the Sub menu for files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFile_Click(object sender, EventArgs e)
        {
            // show sub menu file
            ShowSubMenu(panelSubMenuFile);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuEdit);
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuHelp);
        }

        private void Buttonsubmission_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubmissionDockpanel);
        }

        #endregion

        private bool RunCompilerService(Submission selectedSubmission) {
            if(selectedSubmission != null) {
                CppService service = new CppService(currentAssignment, selectedSubmission);
                return service.IsBuilt;
            }

            return false;
        }

        private void UpdateResultText(Submission selectedSubmission){
            printDocument1.DocumentName = $"{selectedSubmission.StudentName}_Results";
            textBoxResult.Text = selectedSubmission.Result.ToString();
        }

        private void PrintResults(object sender, PrintPageEventArgs e){
            int charactersOnPage = 0;
            int linesPerPage = 0;
            string resultText = textBoxResult.Text;
            Font resultFont = textBoxResult.Font;

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(resultText, resultFont,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(resultText, resultFont, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            resultText = resultText.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (resultText.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                resultText = textBoxResult.Text;
        }

        #region Exit Button

        /// <summary>
        /// exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if(currentAssignment != null)
            {
                saveCurrentAssignment();
            }
            Application.Exit();
        }

        #endregion
    }
}
