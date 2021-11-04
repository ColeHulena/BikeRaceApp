using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        //Add Rider Button
        private void btnAddRider_Click(object sender, EventArgs e)
        {
            //Checking for Invalid Text
            if (!Regex.IsMatch((txbName.Text), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("You cannot enter 123!@# ect in as a Name", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Checking for Invalid Text
            else if (!Regex.IsMatch((txbSurname.Text), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("You cannot enter 123!@# ect as a Surname", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Checking for Invalid Text
            else if (!Regex.IsMatch((txbSchool.Text), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("You cannot enter 123!@# ect as a School", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Checking for Invalid Text
            else if (!chbRace1.Checked && !chbRace2.Checked && !chbRace3.Checked && !chbRace4.Checked)
            {
                MessageBox.Show("You have to enter atleast one race", "ERROR",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Adding rider to rider list
            else
            {
                //Adding the riders name surname and school to the rider class
                rm.AddRider(txbName.Text, txbSurname.Text, txbSchool.Text);
                //Checking to see if the rider is to be entered in a specific race and if so entering the rider
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
                //Saving new riders to .txt file
                rm.SaveRiders();
                //Displaying that the rider has been added
                MessageBox.Show("Rider Successfully Added \n" + rm.NewRiderSummary());
                //Send user back to main menu
                this.Hide();
                FormMainMenu window = new FormMainMenu(rm);
                window.FormClosed += (s, args) => this.Close();
                window.Show();
            }
        }
        
        //Sending user back to menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        //Changing font to custom font
        private void FormAddRider_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Montserrat-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
            }
        }
    }
}
