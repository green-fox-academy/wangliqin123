using System;
using System.Collections.Generic;
using System.Linq;

namespace Fox
{
    class Program
    {
        public static void Main(string[] args)
        {
            var foxList = new List<Foxx>();
            var fox1 = new Foxx("Alpaga", "green", "pallida");
            var fox2 = new Foxx("Oracle", "green", "pallida");
            var fox3 = new Foxx("Rabbit", "green", "pallida");
            var fox4 = new Foxx("Totoro", "green", "static");
            var fox5 = new Foxx("FutureFox", "yellow", "FutureType");
            foxList.Add(fox1);
            foxList.Add(fox2);
            foxList.Add(fox3);
            foxList.Add(fox4);
            foxList.Add(fox5);

            GreensWithQuery(foxList);
            Console.WriteLine();
            GreensAndPallidasWithQuery(foxList);
            Console.WriteLine();
            GreensAndPallidasWithLambda(foxList);
            Console.WriteLine();
            GreensWithQueryLambda(foxList);

            Console.ReadLine();
        }

        public static void GreensWithQuery(List<Foxx>foxList)
        {
            var greenList = from fox in foxList
                            where fox.Color == "green"
                            select fox;

            foreach (var fox in greenList)
            {
                Console.WriteLine(fox.Name);
            }    
        }

        public static void GreensAndPallidasWithQuery(List<Foxx>foxList)
        {
            var greenPallidaList = from fox in foxList
                            where fox.Color == "green" && fox.Type == "pallida"
                            select fox;

            foreach (var fox in greenPallidaList)
            {
                Console.WriteLine(fox.Name);
            }
        }

        public static void GreensAndPallidasWithLambda(List<Foxx> foxList)
        {
            var greenPallidaListLambda = foxList.Where(x => x.Color == "green" && x.Type == "pallida");

            foreach (var fox in greenPallidaListLambda)
            {
                Console.WriteLine(fox.Name);
            }
        }

        public static void GreensWithQueryLambda(List<Foxx> foxList)
        {
            var greenListLambda = foxList.Where(x => x.Color == "green");

            foreach (var fox in greenListLambda)
            {
                Console.WriteLine(fox.Name);
            }
        }
    }
}