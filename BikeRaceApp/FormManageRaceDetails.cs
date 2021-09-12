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
    public partial class FormManageRaceDetails : Form
    {
        RaceManager rm;
        private DataView dv;
        int tempID = -1;
        int raceIndex = -1;

        public FormManageRaceDetails(RaceManager rm)
        {
            this.rm = rm;
            InitializeComponent();
            dtpFinishTime.Value = DateTime.ParseExact("15:30:00", "HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
            dtpFinishTime.Enabled = false;
            rbtnRace1.Enabled = false;
            rbtnRace2.Enabled = false;
            rbtnRace3.Enabled = false;
            rbtnRace4.Enabled = false;
            //populate table
            List<Rider> tempriders = rm.GetRiders();

            //LISTVIEW PROPERTIES
            lvSearch.View = View.Details;
            lvSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add Columns
            lvSearch.Columns.Add("Name", 150);
            lvSearch.Columns.Add("Surname", 150);
            lvSearch.Columns.Add("School", 150);
            lvSearch.Columns.Add("ID Num", 150);

            //Set datetime picker format
            dtpFinishTime.Format = DateTimePickerFormat.Custom;
            dtpFinishTime.CustomFormat = "HH:mm:ss";

            //Fill Data Table
            dv = new DataView(this.rm.FillDataTable());
            PopulateListView(dv);

        }

        private void PopulateListView(DataView dv)
        {
            lvSearch.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lvSearch.Items.Add(new ListViewItem(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() }));
            }
        }

        private void txbSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch((txbSearchBar.Text), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("You cannot enter 123!@# ect in a search bar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dv.RowFilter = string.Format("Name Like '%{0}%'", txbSearchBar.Text);
            PopulateListView(dv);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void lvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvSearch.SelectedItems.Count > 0)
            {
                ListViewItem rowData = lvSearch.SelectedItems[0];
                tempID = Convert.ToInt32(rowData.SubItems[3].Text) - 1;
            }
            List<bool> entryStatus = rm.GetRiderEntryStatus(tempID);

            rbtnRace1.Enabled = entryStatus[0];
            rbtnRace2.Enabled = entryStatus[1];
            rbtnRace3.Enabled = entryStatus[2];
            rbtnRace4.Enabled = entryStatus[3];
            
        }

        private void rbtnRace1_CheckedChanged(object sender, EventArgs e)
        {
            if (!dtpFinishTime.Enabled)
            {
                dtpFinishTime.Enabled = true;
            }
            raceIndex = 0;
            if (!rm.GetRaceTime(tempID,raceIndex).Equals("9999999") )
            {
                dtpFinishTime.Value = DateTime.ParseExact(rm.GetFinishTime(tempID, raceIndex), "HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                lblRaceTimeInput.Text = rm.GetRaceTime(tempID, raceIndex) + " Seconds";

            }
        }

        private void rbtnRace2_CheckedChanged(object sender, EventArgs e)
        {
            if (!dtpFinishTime.Enabled)
            {
                dtpFinishTime.Enabled = true;
            }
            raceIndex = 1;
            if (!rm.GetRaceTime(tempID, raceIndex).Equals("9999999"))
            {
                dtpFinishTime.Value = DateTime.ParseExact(rm.GetFinishTime(tempID, raceIndex), "HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                lblRaceTimeInput.Text = rm.GetRaceTime(tempID, raceIndex) + " Seconds";

            }
        }

        private void rbtnRace3_CheckedChanged(object sender, EventArgs e)
        {
            if (!dtpFinishTime.Enabled)
            {
                dtpFinishTime.Enabled = true;
            }
            raceIndex = 2;
            if (!rm.GetRaceTime(tempID, raceIndex).Equals("9999999"))
            {
                dtpFinishTime.Value = DateTime.ParseExact(rm.GetFinishTime(tempID, raceIndex), "HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                lblRaceTimeInput.Text = rm.GetRaceTime(tempID, raceIndex) + " Seconds";

            }
        }

        private void rbtnRace4_CheckedChanged(object sender, EventArgs e)
        {
            if (!dtpFinishTime.Enabled)
            {
                dtpFinishTime.Enabled = true;
            }
            raceIndex = 3;
            if (!rm.GetRaceTime(tempID, raceIndex).Equals("9999999"))
            {
                dtpFinishTime.Value = DateTime.ParseExact(rm.GetFinishTime(tempID, raceIndex), "HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                lblRaceTimeInput.Text = rm.GetRaceTime(tempID, raceIndex) + " Seconds";

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            rm.SetRiderFinishTime(tempID, raceIndex, dtpFinishTime.Text);
            lblRaceTimeInput.Text = rm.GetRaceTime(tempID, raceIndex)+" Seconds";
            rm.SaveRiders();
        }

        private void FormManageRaceDetails_Load(object sender, EventArgs e)
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
