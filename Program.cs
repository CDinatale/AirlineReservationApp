/*
    The application is developed by 
        Nikola Vojinovic - 101181089, 
        Cora Dinatele - 100645103
        Tanner Rizapoulos - 101072045
        Jeffrey Taseen 100972776
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationDecktopApp
{
    static class Program
    {
        static AirlineCoordinator aCoord;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            aCoord = new AirlineCoordinator(100, 2, 30, 30);    //  Creted Airline Coordinator object
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AirlineReservationForm(aCoord));    //  binding of aCoord to AirlineReservationForm object 
        }
    }
}
