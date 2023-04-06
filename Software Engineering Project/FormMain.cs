using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Project
{
    public partial class FormMain : Form
    {
        #region member variables
        // create open file so we can pull files from our desktop to run
        readonly OpenFileDialog openFileDialog1 = new OpenFileDialog
        {
            Multiselect = true,
            InitialDirectory = @"D:\",
            Title = "Browse Text Files",

            CheckFileExists = true,
            CheckPathExists = true,

            DefaultExt = "txt",
            Filter = "txt files (*.txt)|*.txt",
            FilterIndex = 2,
            RestoreDirectory = true,

            ReadOnlyChecked = true,
            ShowReadOnly = true,
        };

        // forms
        FormCreateAssignment formCreateAssignment = new FormCreateAssignment();

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
        }

        /// <summary>
        /// Hides Sub Menus after clicked on
        /// </summary>
        private void HideSubMenu()
        {
            if(panelSubMenuFile.Visible == true) 
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
        }

        /// <summary>
        /// Shows the sub menus when main buttons are clicked
        /// </summary>
        /// <param name="subMenu"></param>
        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
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

            //If a file is selected  
            var selectedFile = listBoxProjectOpener.SelectedItem as string;
            if (String.IsNullOrEmpty(selectedFile))
                return;

            //Open the file
        }

        /// <summary>
        /// Will view code in pdf and answers/stats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonView_Click(object sender, EventArgs e)
        {

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
            // Add Filename into ListBox
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog1.FileNames)
                {
                    listBoxProjectOpener.Items.Add(Path.GetFileName(openFileDialog1.FileName));
                }
            }
            // Hides the Open File button after use
            HideSubMenu();
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
            panelSideMenuPanel.BackColor = Color.Black;
            buttonAssignments.ForeColor = Color.White;
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
                " Lastly we can view the Stats.","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
            HideSubMenu();
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

        private void buttonCreateAssignment_Click(object sender, EventArgs e)
        {
            OpenFormCreateAssignment();
        }

        private void OpenFormCreateAssignment()
        {
            formCreateAssignment.Visible = true;
            formCreateAssignment.BringToFront();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubMenuHelp);
        }

        #endregion

        #region Exit Button
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        
    }
}
