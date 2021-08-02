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
            this.Hide();
            FormAddRider window = new FormAddRider(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnEditRiderTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManageRaceDetails window = new FormManageRaceDetails(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();

        }

        private void btnLeaderboards_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLeaderBoard window = new FormLeaderBoard(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchRider window = new FormSearchRider(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
