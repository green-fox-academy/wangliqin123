﻿namespace Music
{
    public abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        public abstract void Sound();

        public override void Play()
        {
            Sound();
        }
    }
}