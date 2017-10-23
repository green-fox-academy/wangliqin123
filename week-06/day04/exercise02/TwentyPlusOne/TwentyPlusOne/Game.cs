using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Game
    {
        Deck deck = new Deck();

        static Card myFirstCard = Deck.PullFirst();
        static Card mySecondCard = Deck.PullRandom();

        public static int OpponentScore()
        {
            int opponentScore = Deck.random.Next(15, 21);
            return opponentScore;
        }

        public static int GetMyScore()
        {
            int myscore = myFirstCard.Value;
            return myscore;
        }

        public static int GetMyNewScore()
        {
            int mySecondScore = mySecondCard.Value;
            return mySecondScore;
        }
    }
}
