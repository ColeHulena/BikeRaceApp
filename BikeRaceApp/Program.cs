using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRaceApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Initializing Racemanager class and passing it through all the other classes
            RaceManager rm = new RaceManager();
            //Loading Riders
            rm.LoadRiders();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu(rm));
        }
    }
}
