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
    public partial class FormAddRider : Form
    {
        RaceManager rm;
        public FormAddRider(RaceManager rm)
        {
            this.rm = rm;
            InitializeComponent();
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("If you create a team you will have to re-enter your data here",
            //"Warning",
            //MessageBoxButtons.YesNo,
            //MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    this.Hide();
            //    FormCreateTeam window = new FormCreateTeam(rm);
            //    window.FormClosed += (s, args) => this.Close();
            //    window.Show();
            //}

            rm.AddRider(txpName.Text, txpSurname.Text, txpSchool.Text);

            if (chbRace1.Checked)
            {
                rm.EnterRaces(0);
            }
            if (chbRace2.Checked)
            {
                rm.EnterRaces(1);
            }
            if (chbRace3.Checked)
            {
                rm.EnterRaces(2);
            }
            if (chbRace4.Checked)
            {
                rm.EnterRaces(3);
            }

            MessageBox.Show("Rider Successfully Added \n"+rm.NewRiderSummary());
        }
        
        private void rdbIndividual_CheckedChanged(object sender, EventArgs e)
        {
            chbRace1.Visible = true;
            chbRace2.Visible = true;
            chbRace3.Visible = true;
            chbRace4.Visible = true;
        }
        private void rdbTeam_CheckedChanged(object sender, EventArgs e)
        {
            chbRace1.Visible = false;
            chbRace2.Visible = false;
            chbRace3.Visible = false;
            chbRace4.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
