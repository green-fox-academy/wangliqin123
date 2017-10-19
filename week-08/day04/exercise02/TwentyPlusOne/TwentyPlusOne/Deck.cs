using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Deck
    {
        public List<Card> cards = new List<Card>();
        private static Random random = new Random();

        public void CardCreator()
        {
            for (var i = 0; i < 2; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    for (var k = 0; k < 13; k++)
                    {
                        cards.Add(new Card((CardColor)i, (CardSuit)j, (CardRank)k));
                    }                   
                }
            }
        }
        
        public void ShuffleDeck()
        {
            cards = cards.OrderBy(x => random.Next()).ToList();
        }

        public void GetScore()
        {
            Console.WriteLine(PullFirst().Score);
        }

        public Card PullFirst()
        {
            var firstCard = cards.FirstOrDefault();
            Console.WriteLine(firstCard);
            return firstCard;
        }

        public void PullLast()
        {
            var lastCard = cards.LastOrDefault();
            Console.WriteLine(lastCard);
        }

        public void PullRandom()
        {
            Random random = new Random();
            var randomCard = cards[random.Next(cards.Count)];
            Console.WriteLine(randomCard);         
        }
    }
}