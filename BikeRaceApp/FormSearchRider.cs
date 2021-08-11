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
    public partial class FormSearchRider : Form
    {
        RaceManager rm;
        private DataView dv;
        public FormSearchRider(RaceManager rm)
        {
            this.rm = rm;
            InitializeComponent();
            //populate table
            List<Rider> tempriders = rm.GetRiders();

            //LISTVIEW PROPERTIES
            lvSearch.View = View.Details;
            lvSearch.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add Columns
            lvSearch.Columns.Add("Name", 100);
            lvSearch.Columns.Add("Surname", 150);
            lvSearch.Columns.Add("School", 100);
            lvSearch.Columns.Add("Race 1", 65);
            lvSearch.Columns.Add("Race 2", 65);
            lvSearch.Columns.Add("Race 3", 65);
            lvSearch.Columns.Add("Race 4", 65);

            //Fill Data Table
            dv = new DataView(this.rm.FillSearchTable());
            PopulateListView(dv);
        }

        private void PopulateListView(DataView dv)
        {
            lvSearch.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lvSearch.Items.Add(new ListViewItem(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString() }));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
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
    }
}
