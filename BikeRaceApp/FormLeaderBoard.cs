using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRaceApp
{
    public partial class FormLeaderBoard : Form
    {
        RaceManager rm;
        public FormLeaderBoard(RaceManager rm)
        {
            this.rm = rm;
            InitializeComponent();
        }

        //Sending the user back to the main menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        //Adding custom font to form
        private void FormLeaderBoard_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Montserrat-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
            }

        }

        //Checking to see if the program should display the leaderboard for this specific race
        private void rbtnRace1_CheckedChanged(object sender, EventArgs e)
        {
            lblNames.Text = rm.GenerateLeardboard(0)[0];
            lblTimes.Text = rm.GenerateLeardboard(0)[1];
            //Debugging
            //MessageBox.Show(rm.GenerateLeardboard(0));
        }
        //Checking to see if the program should display the leaderboard for this specific race
        private void rbtnRace2_CheckedChanged(object sender, EventArgs e)
        {
            lblNames.Text = rm.GenerateLeardboard(1)[0];
            lblTimes.Text = rm.GenerateLeardboard(1)[1];
        }
        //Checking to see if the program should display the leaderboard for this specific race
        private void rbtnRace3_CheckedChanged(object sender, EventArgs e)
        {
            lblNames.Text = rm.GenerateLeardboard(2)[0];
            lblTimes.Text = rm.GenerateLeardboard(2)[1];
        }
        //Checking to see if the program should display the leaderboard for this specific race
        private void rbtnRace4_CheckedChanged(object sender, EventArgs e)
        {
            lblNames.Text = rm.GenerateLeardboard(3)[0];
            lblTimes.Text = rm.GenerateLeardboard(3)[1];
        }
    }
}
