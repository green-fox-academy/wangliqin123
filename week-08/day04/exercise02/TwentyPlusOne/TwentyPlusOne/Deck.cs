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

        public List<Card> newCards = new List<Card>();
        
        public void ShuffleDeck()
        {
            Random random = new Random();

            foreach (Card card in cards)
            {
                newCards.Insert(random.Next(0, newCards.Count + 1), card);
            }
        }

        public void PullFirst()
        {
            var firstCard = newCards.FirstOrDefault();
            Console.WriteLine(firstCard);
        }

        public void PullLast()
        {
            var lastCard = newCards.LastOrDefault();
            Console.WriteLine(lastCard);
        }

        public void PullRandom()
        {
            Random random = new Random();
            var randomCard = newCards[random.Next(newCards.Count)];
            Console.WriteLine(randomCard);         
        }
    }
}