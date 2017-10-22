using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            numberOfStrings = 6;
            Console.Write("Electric guitar is a {0}-stringed instrument that ", numberOfStrings);
            Sound();
        }

        public ElectricGuitar(int numberOfStrings)
        {
            this.numberOfStrings = 6;
        }

        public override void Sound()
        {
            Console.WriteLine("Twang");
        }
    }
}
