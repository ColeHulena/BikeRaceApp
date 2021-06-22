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
        public FormAddRider()
        {
            InitializeComponent();
            if (rdbIndividual.Checked)
            {
                lblTeamMembers.Visible = false;
                cmbSelectTeam.Visible = false;
            }
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("If you create a team you will have to re-enter your data here",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormCreateTeam window = new FormCreateTeam();
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }
        }


        private void rdbIndividual_CheckedChanged(object sender, EventArgs e)
        {
            lblTeamMembers.Visible = false;
            cmbSelectTeam.Visible = false;
        }

        private void rdbTeam_CheckedChanged(object sender, EventArgs e)
        {
            lblTeamMembers.Visible = true;
            cmbSelectTeam.Visible = true;
        }
    }
}
