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

        public int GetRaceTime(int riderIndex, int raceID)
        {
            return riders[riderIndex].GetCalculateRaceTime(raceID);
        }
        public string GenerateLeardboard(int raceIndex)
        {
            List<Rider> tempriders = new List<Rider>();
            foreach (Rider rider in riders)
            {
                if (rider.CheckEntryStatus(raceIndex))
                {
                    tempriders.Add(rider);
                }
            }
            tempriders = SortRiderByRaceTime(tempriders, raceIndex);
            string leaderboard = "";
            int pos = 0;
            foreach (Rider rider in tempriders)
            {
                leaderboard += (pos + 1) + ". " + rider.GetName() + " " + rider.GetSurname() + "\t" + rider.GetCalculateRaceTime(raceIndex)+"\n"; 
            }
            return leaderboard;
        }


        public List<Rider> SortRiderByRaceTime(List<Rider> riders, int raceIndex)
        {
            for (int i = 0; i < riders.Count - 1; i++)
            {
                // pos will be used store the index of the highest value greather than the value referenced by index
                //  it will start start by storing i as i potentially could be the highest value 
                int pos = i;

                // inner loop will loop through the all elemnts after i and store the index of the highest value
                for (int j = i + 1; j < riders.Count; j++)
                {
                    if (riders[pos].GetCalculateRaceTime(raceIndex) < riders[j].GetCalculateRaceTime(raceIndex))
                    {
                        pos = j;
                    }
                }
                //swoping logic to swop cost[i] with the highest found cost i.e cost[pos]
                Rider riderTemp = riders[i];
                riders[i] = riders[pos];
                riders[pos] = riderTemp;

            }

            return riders;
        }

        

    }
}
