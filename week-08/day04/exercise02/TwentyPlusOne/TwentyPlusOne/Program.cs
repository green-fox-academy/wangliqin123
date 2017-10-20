using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jigsaw's: BlackJack 1.0 \nI want to play a game!\n");
            
            Deck.CardCreator();
            Deck.ShuffleDeck();
            Console.WriteLine("Your opponent's score is: {0}\n", Game.OpponentScore());
            Console.WriteLine("Your first card's is: \"{0}\" your score is: {1}\n" , Deck.PullFirst(), Game.GetMyScore());
            Console.WriteLine("Do you want another card?\n");
            Console.WriteLine("Your second card's is: \"{0}\" your score is: {1}", Deck.PullRandom(), Game.GetMyNewScore());

            Console.ReadLine();
        }
    }
}