using System;
using System.Text;


namespace pemrogaman_taxi_0
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.DriverName = "Jeno";
            taxi.OnDuty = true;
            taxi.NumPassanger = 77;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOfPassanger();

            Console.ReadKey();
        }
    }
}