using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRaceApp
{
    public class RaceManager
    {
        
        List<Rider> riders = new List<Rider>();

        public RaceManager()
        {
            
        }

        public DataTable FillDataTable()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("School");
            dt.Columns.Add("Team");
            dt.Columns.Add("ID");
            foreach (var rider in riders)
            {
                dt.Rows.Add(rider.GetName(),rider.GetSurname(),rider.GetSchool(),rider.GetTeam(),rider.GetID());
            }

            return dt;
        }

        public void AddRider(string name, string surname, string school, bool team)
        {
            //Append to text file
            riders.Add(new Rider(name, surname, school, team, riders.Count + 1));
        }        
        public void AddRider(string name, string surname, string school, bool team, int id)
        {
            //Append to text file
            riders.Add(new Rider(name, surname, school, team, id));
        }

        
        public void EnterRaces(int raceNumber)
        {
            riders[riders.Count - 1].EnterRace(raceNumber);
        }

        public void LoadRiders()
        {
            string[] lines = File.ReadAllLines("riders.txt");

            foreach (string line in lines)
            {
                string[] tokens = line.Split(',');
                string name = tokens[0];
                string surname = tokens[1];
                string school = tokens[2];
                bool team = bool.Parse(tokens[3]);
                int id = Convert.ToInt32(tokens[4]);
                AddRider(name, surname, school, team, id);

                string[] entryStatusTxt = tokens[5].Split('#');
                for (int i = 0; i<entryStatusTxt.Length; i++)
                {
                    if (entryStatusTxt[i] == "true")
                    {
                        EnterRaces(i);
                    }
                }
            }
        }
        public string NewRiderSummary()
        {
            return riders[riders.Count - 1].RiderSummary();
        }

        public List<Rider> GetRiders()
        {
            return riders;
        }

    }
}
