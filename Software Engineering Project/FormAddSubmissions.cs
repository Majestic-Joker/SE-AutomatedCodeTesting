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

namespace Software_Engineering_Project
{
    public partial class FormAddSubmissions : Form
    {
        public FormAddSubmissions()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with Yes and No buttons
            DialogResult closeResult = MessageBox.Show("Are You Sure you Want to Exit This Window?",
                "Make sure to Add Submissions",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Check which button the user clicked
            if (closeResult == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
