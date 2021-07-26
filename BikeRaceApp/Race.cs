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
        bool raceStatus = false;
        string startTime = "15:30:00";
        string finishTime;
        public int raceTime;
        

        public Race()
        {

        }
        public int CalculateRaceTime()
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

            raceTime = finishTimeSeconds - startTimeSeconds;

            return raceTime;

        }

        public void SetRaceStatus(bool raceStatus)
        {
            this.raceStatus = raceStatus;
        }
        public bool GetRaceStatus()
        {
            return raceStatus;
        }
        public void SetFinishTime(string finishTime)
        {
            this.finishTime = finishTime;
            MessageBox.Show(this.finishTime);
        }
    }
}
