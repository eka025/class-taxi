using System;
using System.Collections.Generic;
using System.Text;

namespace pemrogaman_taxi_0
{
    class taxi
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassanger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Number of Passanger : {0}", NumPassanger);

        }
        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOfPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}