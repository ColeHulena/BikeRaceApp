using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRaceApp
{
    class Race
    {
        bool raceStatus = false;
        string startTime = "15:30:00";
        string finishTime;

        public Race()
        {

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
        }
    }
}
