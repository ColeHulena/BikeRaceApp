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
        //Making the riders visible to the user in the search area
        private void PopulateListView(DataView dv)
        {
            //clearing list view
            lvSearch.Items.Clear();
            //adding each rider to the list view 1 by 1
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lvSearch.Items.Add(new ListViewItem(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString() }));
            }
        }
        //sending user back to main menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
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
        //adding custom font to form
        private void FormSearchRider_Load(object sender, EventArgs e)
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
