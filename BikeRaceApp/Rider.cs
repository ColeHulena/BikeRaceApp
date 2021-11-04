using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRaceApp
{
    public class Rider
    {
        //Creating inital variables
        private string name;
        private string surname;
        private string school;
        private bool active = true;
        private int id;
        //Creating a list that will store all the riders races
        private List<Race> races = new List<Race>() {new Race(), new Race(), new Race(), new Race()};

        //Creating the rider
        public Rider(string name,string surname, string school, int id)
        {
            this.name = name;
            this.surname = surname;
            this.school = school;
            this.id = id;

        }
        //Setting a rider active or inactive
        public void SetActive()
        {
            if (active == true)
            {
                active = false;
            }
            else
            {
                active = true;
            }
        }
        //Entering a rider into a race
        public void EnterRace(int raceNum)
        {
            races[raceNum].SetRaceStatus(true);
        }
        //Producing a rider summary
        public string RiderSummary()
        {
            string summary = "Name: "+name+" "+surname+"\nSchool: "+school+"\n";

            for (int i = 1; i < 5; i++)
            {
                summary += $"Race {i}: ";

                string entryStatus = "Not Entered";

                if (races[i - 1].GetRaceStatus())
                {
                    entryStatus = "Entered";
                }

                summary += entryStatus+"\n";
            }

            return summary;
        }
        //Storing a rider
        public string StoreRider()
        {
            string storeRider = name + "," + surname + "," + school + ","+id+",";
            string rStatus = "";
            string fTime = "";
            foreach (Race race in races)
            {
                rStatus += race.GetRaceStatus() + "#";
                
                fTime += race.GetFinishTime() + "#";
            }

            rStatus += ",";

            storeRider += rStatus + fTime;

            if (active == true)
            {
                storeRider += ",Active";
            }
            else
            {
                storeRider += ",Inactive";
            }

            

            return storeRider;
        }
        //Getting rider name
        public string GetName()
        {
            return name;
        }
        //Getting rider surname
        public string GetSurname()
        {
            return surname;
        }
        //Getting rider school
        public string GetSchool()
        {
            return school;
        }
        //Getting rider id
        public int GetID()
        {
            return id;
        }
        //Seeing if rider is active
        public bool GetActive()
        {
            return active;
        }
        //Getting race entry status for a single race
        public bool GetSingleEntryStatus(int raceIndex)
        {
            return races[raceIndex].GetRaceStatus();
        }
        //Getting race entry status for all races
        public List<bool> GetEntryStatus()
        {
            List<bool> entryStatus = new List<bool>();
            foreach (var race in races)
            {
                entryStatus.Add(race.GetRaceStatus());
            }
            return entryStatus;
        }
        //Setting Finish Time
        public void SetFinishTime(int raceIndex, string finishTime)
        {
            races[raceIndex].SetFinishTime(finishTime);
        }
        //Passing Race time through classes
        public string GetCalculateRaceTime(int raceID)
        {
            return races[raceID].CalculateRaceTime();
        }
        //Passing int version of race time through classes
        public int GetCheckedRaceTime(int raceID)
        {
            return races[raceID].CheckRaceTime();
        }
        //Getting Finish time
        public string GetFinishTime(int raceIndex)
        {
            return races[raceIndex].GetFinishTime();
        }


    }
}
