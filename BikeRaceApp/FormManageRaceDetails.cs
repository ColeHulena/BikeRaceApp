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
        int time = 0;

        public FormManageRaceDetails(RaceManager rm)
        {
            this.rm = rm;
            InitializeComponent();
            //Setting the inital value for the finish time to the start time
            dtpFinishTime.Value = DateTime.ParseExact("15:30:00", "HH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
            //Disabling the finish time DateTime picker
            dtpFinishTime.Enabled = false;
            //Disabling all races to be changed
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
        //Add riders to the list view so they will be visible to the user
        private void PopulateListView(DataView dv)
        {
            //clearing listview
            lvSearch.Items.Clear();
            //Adding each rider 1 by 1
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lvSearch.Items.Add(new ListViewItem(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() }));
            }
        }

        //Updating the rider that are showed based on the text in the Search Bar
        private void txbSearchBar_TextChanged(object sender, EventArgs e)
        {
            //Making sure there are no invalid characters in the search bar
            if (!Regex.IsMatch((txbSearchBar.Text), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("You cannot enter 123!@# ect in a search bar", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Filtering the list view to only displayed searched for riders
            dv.RowFilter = string.Format("Name Like '%{0}%'", txbSearchBar.Text);
            PopulateListView(dv);
        }
        //Sending user to main menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
        //Checking to see if a specific rider has been selected and making the races theyre in avalible for time changes
        private void lvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvSearch.SelectedItems.Count > 0)
            {
                ListViewItem rowData = lvSearch.SelectedItems[0];
                tempID = Convert.ToInt32(rowData.SubItems[3].Text) - 1;
            }
            List<bool> entryStatus = rm.GetRiderEntryStatus(tempID);
            //Making each specific race avalible or not
            rbtnRace1.Enabled = entryStatus[0];
            rbtnRace2.Enabled = entryStatus[1];
            rbtnRace3.Enabled = entryStatus[2];
            rbtnRace4.Enabled = entryStatus[3];
            
        }
        //Updating the times for each race
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
        //Updating the times for each race
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
        //Updating the times for each race
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
        //Updating the times for each race
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
        //Making the updated times for each race save so that it will show up
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Checking race time
            time = rm.GetCheckRaceTime(tempID, raceIndex);
            rm.SetRiderFinishTime(tempID, raceIndex, dtpFinishTime.Text);
            //Making sure the user hasent tried to make their race time less than 0
            if (time > 0)
            {
                //Displaying error
                MessageBox.Show("You cannot finnish the race before it started", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine(time);
            }
            else
            {
                //Saving users race time to race list
                rm.SetRiderFinishTime(tempID, raceIndex, dtpFinishTime.Text);
                lblRaceTimeInput.Text = rm.GetRaceTime(tempID, raceIndex) + " Seconds";
                //Saving users race to .txt file
                rm.SaveRiders();
            }
        }
        //Setting custom font on the form
        private void FormManageRaceDetails_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("Montserrat-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], c.Font.Size, c.Font.Style);
            }
        }

        //Remove rider
        private void btnRemoveRider_Click(object sender, EventArgs e)
        {
            //Changing the riders status to inactive
            rm.SetRiderActive(tempID);
            //Saving rider status to .txt file
            rm.SaveRiders();
            //Updating listview to display without the removed rider
            dv = new DataView(this.rm.FillDataTable());
            PopulateListView(dv);
        }
    }
}
