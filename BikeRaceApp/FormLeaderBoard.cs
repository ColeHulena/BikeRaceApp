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
    public partial class FormLeaderBoard : Form
    {
        RaceManager rm;
        int raceIndex = 1;
        public FormLeaderBoard(RaceManager rm)
        {
            this.rm = rm;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void FormLeaderBoard_Load(object sender, EventArgs e)
        {
            if (rm.GenerateLeardboard(raceIndex) != null)
            {
                
            }
            
        }

        private void rbtnRace1_CheckedChanged(object sender, EventArgs e)
        {
            lblNames.Text = rm.GenerateLeardboard(0)[0];
            lblTimes.Text = rm.GenerateLeardboard(0)[1];
            //Debugging
            //MessageBox.Show(rm.GenerateLeardboard(0));
        }

        private void rbtnRace2_CheckedChanged(object sender, EventArgs e)
        {
            lblNames.Text = rm.GenerateLeardboard(1)[0];
            lblTimes.Text = rm.GenerateLeardboard(1)[1];
        }

        private void rbtnRace3_CheckedChanged(object sender, EventArgs e)
        {
            lblNames.Text = rm.GenerateLeardboard(2)[0];
            lblTimes.Text = rm.GenerateLeardboard(2)[1];
        }

        private void rbtnRace4_CheckedChanged(object sender, EventArgs e)
        {
            lblNames.Text = rm.GenerateLeardboard(3)[0];
            lblTimes.Text = rm.GenerateLeardboard(3)[1];
        }
    }
}
