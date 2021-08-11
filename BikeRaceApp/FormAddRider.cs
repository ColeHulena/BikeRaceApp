using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (Regex.IsMatch((txpName.Text + txpSurname + txpSchool), "^[a-zA-Z]*$"))
            {
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

                rm.SaveRiders();

                MessageBox.Show("Rider Successfully Added \n" + rm.NewRiderSummary());
            }
            else
            {
                MessageBox.Show("You cannot enter 123!@# ect in a name or school", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void txpName_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch((txpName.Text), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("You cannot enter 123!@# ect in a first name", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txpSurname_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch((txpSurname.Text), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("You cannot enter 123!@# ect in a  surname", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txpSchool_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch((txpSchool.Text), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("You cannot enter 123!@# ect in a school", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
