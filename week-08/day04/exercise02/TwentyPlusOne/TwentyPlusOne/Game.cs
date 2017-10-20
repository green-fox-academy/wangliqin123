using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        Random random = new Random();
        Deck deck = new Deck();
        static int myScore;
        static int opponentScore;
        static Card firstCard = Deck.PullRandom();
        static Card secondCard = Deck.PullRandom();

        public int OpponentScore()
        {
            return random.Next(15, 21);
        }

        public static int GetMyScore()
        {
            return firstCard.Value;
        }

        public static void Play()
        {

            Deck.CardCreator();
            Deck.ShuffleDeck();

            
        }
    }
}
