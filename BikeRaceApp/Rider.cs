using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRaceApp
{
    public class Rider
    {
        private string name;
        private string surname;
        private string school;
        private int id;
        private List<Race> races = new List<Race>() {new Race(), new Race(), new Race(), new Race()};


        public Rider(string name,string surname, string school, int id)
        {
            this.name = name;
            this.surname = surname;
            this.school = school;
            this.id = id;
        }

        public void EnterRace(int raceNum)
        {
            races[raceNum].SetRaceStatus(true);
        }
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

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetSchool()
        {
            return school;
        }
        public int GetID()
        {
            return id;
        }
        public List<bool> GetEntryStatus()
        {
            List<bool> entryStatus = new List<bool>();
            foreach (var race in races)
            {
                entryStatus.Add(race.GetRaceStatus());
            }
            return entryStatus;
        }
        public void SetFinishTime(int raceIndex, string finishTime)
        {
            races[raceIndex].SetFinishTime(finishTime);
        }


    }
}
