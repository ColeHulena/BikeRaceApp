using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRaceApp
{
    class Race
    {
        //Creating inital variables
        private bool raceStatus = false;
        private string startTime = "15:30:00";
        private string finishTime = "NA";
        
        

        public Race()
        {

        }
        //String to calculate Race time
        public string CalculateRaceTime()
        {
            string raceTime;


            if (!this.finishTime.Equals("NA"))
            {
                string[] startTime = this.startTime.Split(':');
                int sHours = (Convert.ToInt32(startTime[0]) * 60) * 60;
                int sMins = Convert.ToInt32(startTime[1]) * 60;
                int sSeconds = Convert.ToInt32(startTime[2]);
                int startTimeSeconds = sHours + sMins + sSeconds;


                string[] finishTime = this.finishTime.Split(':');
                int fHours = (Convert.ToInt32(finishTime[0]) * 60) * 60;
                int fMins = Convert.ToInt32(finishTime[1]) * 60;
                int fSeconds = Convert.ToInt32(finishTime[2]);
                int finishTimeSeconds = fHours + fMins + fSeconds;

                raceTime = (finishTimeSeconds - startTimeSeconds)+"";
            }
            else
            {
                raceTime = "9999999";
            }

            return raceTime;

        }
        //intager version of calculating race time
        public int CheckRaceTime()
        {
            int CheckedRaceTime = 0;
            if (!this.finishTime.Equals("NA"))
            {
                string[] startTime = this.startTime.Split(':');
                int sHours = (Convert.ToInt32(startTime[0]) * 60) * 60;
                int sMins = Convert.ToInt32(startTime[1]) * 60;
                int sSeconds = Convert.ToInt32(startTime[2]);
                int startTimeSeconds = sHours + sMins + sSeconds;


                string[] finishTime = this.finishTime.Split(':');
                int fHours = (Convert.ToInt32(finishTime[0]) * 60) * 60;
                int fMins = Convert.ToInt32(finishTime[1]) * 60;
                int fSeconds = Convert.ToInt32(finishTime[2]);
                int finishTimeSeconds = fHours + fMins + fSeconds;
                CheckedRaceTime = finishTimeSeconds - startTimeSeconds;
            }
            else
            {
                CheckedRaceTime = 9999999;
            }

            return CheckedRaceTime;
        }
        //No longer used but shows progression
        //public int GetRaceTime()
        //{
        //    return raceTime;
        //}
        //Setting race status
        public void SetRaceStatus(bool raceStatus)
        {
            this.raceStatus = raceStatus;
        }
        //Getting race status
        public bool GetRaceStatus()
        {
            return raceStatus;
        }
        //Setting Finish Time
        public void SetFinishTime(string finishTime)
        {
            this.finishTime = finishTime;
        }
        //Getting Finish Time
        public string GetFinishTime()
        {
            return finishTime;
        }
    }
}
