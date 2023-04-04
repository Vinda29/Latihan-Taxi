using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Taxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Latihan_Taxi taxi = new Latihan_Taxi();
            taxi.Drivername = "Vinda";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropPffPassenger();

            Console.WriteLine();
        }
    }
}