using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Reflection;

namespace Software_Engineering_Project
{
    public partial class FormAddSubmissions : Form
    {
        public FormAddSubmissions()
        {
            InitializeComponent();

            FormClosing += FormAddSubmissions_FormClosing;
        }

        #region Exit buttons
        private void FormAddSubmissions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Visible = false;
            e.Cancel = true;//cancel close if user requested
            PropertyInfo pi = typeof(Form).GetProperty("CloseReason", BindingFlags.NonPublic | BindingFlags.Instance);
            pi.SetValue(this, CloseReason.None, null);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Visible = false;
            //e.Cancel = true;//cancel close if user requested
            PropertyInfo pi = typeof(Form).GetProperty("CloseReason", BindingFlags.NonPublic | BindingFlags.Instance);
            pi.SetValue(this, CloseReason.None, null);
        }
        #endregion
    }
}
