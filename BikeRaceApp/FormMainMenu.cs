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
    public partial class FormMainMenu : Form
    {
        RaceManager rm;
        public FormMainMenu(RaceManager rm)
        {
            this.rm = rm;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRider_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you competeing in a team?",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormCreateTeam window1 = new FormCreateTeam(rm);
                window1.FormClosed += (s, args) => this.Close();
                window1.Show();
            }
            this.Hide();
            FormAddRider window = new FormAddRider(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateTeam window = new FormCreateTeam(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnEditRiderTeam_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to edit a riders Details", "Question",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormManageRaceDetails window = new FormManageRaceDetails(rm);
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }

        }
        
    }
}
