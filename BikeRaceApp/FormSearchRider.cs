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
            lvSearch.Columns.Add("Name", 150);
            lvSearch.Columns.Add("Surname", 150);
            lvSearch.Columns.Add("School", 150);
            lvSearch.Columns.Add("ID Num", 150);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainMenu window = new FormMainMenu(rm);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void txbSearchBar_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Name Like '%{0}%'", txbSearchBar.Text);
            PopulateListView(dv);
        }
    }
}
