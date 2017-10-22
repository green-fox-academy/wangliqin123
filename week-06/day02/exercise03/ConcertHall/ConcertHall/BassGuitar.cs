using System;

namespace Music
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            numberOfStrings = 4;
            Console.Write("Bass guitar is a {0}-stringed instrument that ", numberOfStrings);
            Sound();
        }

        public BassGuitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
            Console.Write("Bass guitar is a {0}-stringed instrument that ", numberOfStrings);
            Sound();
        }

        public override void Sound()
        {
            Console.WriteLine("Duum-duum-duum");
        }
    }
}