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
       
            
            SortDominoes(dominoes);
            foreach (var dominos in sortedDominoes)
            {
                Console.Write("[{0} {1}] ", dominos.GetValues()[0], dominos.GetValues()[1]);

            }
            Console.ReadLine();
        }

        public static List<int> SortDominoes(List<Dominoo> dominoes)
        {
            var newDominoes = new List<Dominoo>();
            newDominoes.Add(dominoes[0]);
            dominoes.RemoveAt(0);

            for (int i = 0; i < dominoes.Count; i++)
            {
                while (dominoes[i].GetValues()[1] != dominoes[i+1].GetValues()[0])
                {
                    dominoes.Add(newDominoes[1]);
                }   
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
