using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

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

        //Adding custom font to this form
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Montserrat-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
            }
        }
        //Sending user to add rider component
        private void btnAddRider_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddRider window = new FormAddRider(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        //Sending user to manage race details component
        private void btnManageRaceDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManageRaceDetails window = new FormManageRaceDetails(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();

        }
        //Sending user to leaderboards component
        private void btnLeaderboards_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLeaderBoard window = new FormLeaderBoard(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        //Sending user to search component
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSearchRider window = new FormSearchRider(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
