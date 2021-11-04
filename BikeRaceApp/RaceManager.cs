using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRaceApp
{
    public class RaceManager
    {

        List<Rider> riders = new List<Rider>();

        public RaceManager()
        {

        }
        //Creating Data Table to display all the riders for Managing race details
        public DataTable FillDataTable()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("School");
            dt.Columns.Add("ID");
            foreach (var rider in riders)
            {
                //Checking to see if the rider is active
                if (rider.GetActive() == true)
                {
                    dt.Rows.Add(rider.GetName(), rider.GetSurname(), rider.GetSchool(), rider.GetID());
                }
            }

            return dt;
        }
        //Creating data table to display all riders for Search table
        public DataTable FillSearchTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("School");
            dt.Columns.Add("Race 1");
            dt.Columns.Add("Race 2");
            dt.Columns.Add("Race 3");
            dt.Columns.Add("Race 4");
            foreach (var rider in riders)
            {
                //Checking to see if the rider is active
                if (rider.GetActive() == true)
                {
                    dt.Rows.Add(rider.GetName(), rider.GetSurname(), rider.GetSchool(), rider.GetSingleEntryStatus(0), rider.GetSingleEntryStatus(1), rider.GetSingleEntryStatus(2), rider.GetSingleEntryStatus(3));
                }
            }

            return dt;
        }
        //Adding rider through another class
        public void AddRider(string name, string surname, string school)
        {
            //Append to text file
            riders.Add(new Rider(name, surname, school, riders.Count + 1));
        }
        //Adding rider with a specific index through another class
        public void AddRider(string name, string surname, string school, int id)
        {
            //Append to text file
            riders.Add(new Rider(name, surname, school, id));
        }

        //Enter rider into races
        public void EnterRaces(int raceNumber)
        {
            riders[riders.Count - 1].EnterRace(raceNumber);
        }
        //Load riders from .txt file
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
                for (int i = 0; i < entryStatusTxt.Length; i++)
                {
                    if (entryStatusTxt[i] == "True")
                    {
                        EnterRaces(i);
                    }
                }
                string[] finishTimesTxt = tokens[5].Split('#');
                for (int i = 0; i < finishTimesTxt.Length - 1; i++)
                {
                    if (!finishTimesTxt[i].Equals("NA"))
                    {
                        riders[riders.Count - 1].SetFinishTime(i, finishTimesTxt[i]);
                    }
                }
                if (tokens[6] == "Inactive")
                {
                    riders[riders.Count - 1].SetActive();
                }
            }
        }
        //Setting Rider finish time for a specific race
        public void SetRiderFinishTime(int riderID, int raceIndex, string finishTime)
        {
            riders[riderID].SetFinishTime(raceIndex, finishTime);
        }
        //Setting a rider to actice or inactive
        public void SetRiderActive(int riderID)
        {
            riders[riderID].SetActive();
        }
        //Displaying rider summary 
        public string NewRiderSummary()
        {
            return riders[riders.Count - 1].RiderSummary();
        }
        //Passing through riders list to another class
        public List<Rider> GetRiders()
        {
            return riders;
        }
        //Passing through rider entry status for races to another class
        public List<bool> GetRiderEntryStatus(int riderID)
        {
            return riders[riderID].GetEntryStatus();
        }
        //Passing through riders race time for a specific race
        public string GetRaceTime(int riderIndex, int raceID)
        {
            return riders[riderIndex].GetCalculateRaceTime(raceID);
        }
        //Passing through riders race time for a specific race to another class
        public int GetCheckRaceTime(int riderIndex, int raceID)
        {
            return riders[riderIndex].GetCheckedRaceTime(raceID);
        }
        //Generating leaderboard for riders
        public string[] GenerateLeardboard(int raceIndex)
        {
            List<Rider> tempriders = new List<Rider>();
            string[] leaderboard = new string[2];
            foreach (Rider rider in riders)
            {
                if (rider.GetActive() == true)
                {
                    if (rider.GetSingleEntryStatus(raceIndex))
                    {
                        tempriders.Add(rider);
                    }
                }
            }
            //Testing / Debugging
            //MessageBox.Show(tempriders.Count + "");
            tempriders = SortRiderByRaceTime(tempriders, raceIndex);
            leaderboard[0] = "";
            leaderboard[1] = "";
            int pos = 0;
            //Testing / Debugging
            //MessageBox.Show(tempriders.Count+"");
            foreach (Rider rider in tempriders)
            {
                string raceTime = rider.GetCalculateRaceTime(raceIndex);
                if (raceTime.Equals("9999999"))
                {
                    raceTime = "NA";
                }
                leaderboard[0] += (pos + 1) + ". " + rider.GetName() + " " + rider.GetSurname() + "\n";
                leaderboard[1] += raceTime + "\n";
                pos++;
            }
            return leaderboard;
        }

        //Sorting riders by their times for leader board
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
                    if (Convert.ToInt32(riders[pos].GetCalculateRaceTime(raceIndex)) > Convert.ToInt32(riders[j].GetCalculateRaceTime(raceIndex)))
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
        //Saving riders to .txt file
        public void SaveRiders()
        {
            string allRiders = "";

            foreach (Rider rider in riders)
            {
                allRiders += rider.StoreRider() + "\n";
            }
            File.WriteAllText("Riders.txt", allRiders);
        }
        //Passing through finish time for a specific rider and race to another class
        public string GetFinishTime(int riderIndex, int raceIndex)
        {
            return riders[riderIndex].GetFinishTime(raceIndex);
        }


    }
}
