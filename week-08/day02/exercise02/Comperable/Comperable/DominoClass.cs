using System;

namespace Comperable
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object obj)
        {
            Domino domino = obj as Domino;
            return domino.GetValues()[1].CompareTo(domino.GetValues()[0]);
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}