using System;

namespace Music
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            numberOfStrings = 4;
            Console.Write("Violin is a {0}-stringed instrument that", numberOfStrings);
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("Screech");
        }
    }
}