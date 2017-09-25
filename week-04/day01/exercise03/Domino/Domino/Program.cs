using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoo
{
    public class Domino
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            var newDominoes = new List<Dominoo>();
            newDominoes.Add(dominoes[0]);
            dominoes.RemoveAt(0);

            SortDominoes(dominoes);
        }

        public static void SortDominoes(List<Dominoo> dominoes)
        {
            for (int i = 0; i < dominoes.Count; i++)
            {
                if (dominoes[1].GetValues()[0] != dominoes[0].GetValues()[1])
                {
                   
                }
                else
                {
                    dominoes.Add(newDominoes[1]);
                }
                return;
            }
        }

        public static List<Dominoo> InitializeDominoes()
        {
            var dominoes = new List<Dominoo>();
            dominoes.Add(new Dominoo(5, 2));
            dominoes.Add(new Dominoo(4, 6));
            dominoes.Add(new Dominoo(1, 5));
            dominoes.Add(new Dominoo(6, 7));
            dominoes.Add(new Dominoo(2, 4));
            dominoes.Add(new Dominoo(7, 1));
            return dominoes;
        }
    }
}
