using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.CardCreator();

            foreach (Card card in deck.cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();
            deck.ShuffleDeck();

            foreach (Card card in deck.cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();
            deck.PullFirst();
            Console.WriteLine();
            deck.PullLast();
            Console.WriteLine();
            deck.PullRandom();
            Console.WriteLine();
            deck.GetScore();


            Console.ReadLine();
        }
    }
}