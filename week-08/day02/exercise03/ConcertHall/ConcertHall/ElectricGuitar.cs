using System;

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
            this.numberOfStrings = numberOfStrings;
            Console.Write("Electric guitar is a {0}-stringed instrument that ", numberOfStrings);
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("Twang");
        }
    }
}