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

            deck.ShuffleDeck();

            foreach (Card card in deck.newCards)
            {
                Console.WriteLine(card);
            }

            Console.ReadLine();
        }
    }
}
