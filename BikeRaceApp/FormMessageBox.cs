using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRaceApp
{
    public partial class FormMessageBox : Form
    {
        public FormMessageBox(string message, string leftBtnText, string rightBtnText)
        {
            InitializeComponent();
            lblMessage.Text = message;
            btnLeftText.Text = leftBtnText;
            btnRightText.Text = rightBtnText;           
        }

        private void FormMessageBox_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLeftText_Click(object sender, EventArgs e)
        {
            if (btnLeftText.Text == "Team")
            {
                Console.WriteLine("Team");
            }
        }

        private void btnRightText_Click(object sender, EventArgs e)
        {
            if (btnRightText.Text == "Rider")
            {
                Console.WriteLine("Rider");
            }
        }
    }
}
