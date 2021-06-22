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
        public FormMainMenu()
        {
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
            this.Hide();
            FormAddRider window = new FormAddRider();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCreateTeam window = new FormCreateTeam();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnEditRiderTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMessageBox window = new FormMessageBox("Would you like to a team or rider", "Team", "Rider");
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        
    }
}
