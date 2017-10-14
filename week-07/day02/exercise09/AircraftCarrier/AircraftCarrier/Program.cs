using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft aircraft = new Aircraft();

            aircraft.Refill(100);          
            aircraft.Fight();
            aircraft.GetStatus("F16");
            Console.ReadLine();
        }
    }
}
