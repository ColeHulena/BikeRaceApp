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
            dt.Columns.Add("ID");
            foreach (var rider in riders)
            {
                dt.Rows.Add(rider.GetName(),rider.GetSurname(),rider.GetSchool(),rider.GetID());
            }

            return dt;
        }

        public void AddRider(string name, string surname, string school)
        {
            //Append to text file
            riders.Add(new Rider(name, surname, school, riders.Count + 1));
        }        
        public void AddRider(string name, string surname, string school, int id)
        {
            //Append to text file
            riders.Add(new Rider(name, surname, school, id));
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
                int id = Convert.ToInt32(tokens[3]);
                AddRider(name, surname, school, id);

                string[] entryStatusTxt = tokens[4].Split('#');
                for (int i = 0; i<entryStatusTxt.Length; i++)
                {
                    if (entryStatusTxt[i] == "true")
                    {
                        EnterRaces(i);
                    }
                }
            }
        }
        public void SetRiderFinishTime(int riderID, int raceIndex, string finishTime)
        {
            riders[riderID].SetFinishTime(raceIndex, finishTime);
        }

        public string NewRiderSummary()
        {
            return riders[riders.Count - 1].RiderSummary();
        }

        public List<Rider> GetRiders()
        {
            return riders;
        }
        public List<bool> GetRiderEntryStatus(int riderID)
        {
            return riders[riderID].GetEntryStatus();
        }

        

    }
}
