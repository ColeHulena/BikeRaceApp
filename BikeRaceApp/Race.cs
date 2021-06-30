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
        DateTime startTime;
        DateTime finishTime;

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
    }
}
