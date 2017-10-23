using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Deck
    {
        public static Random random = new Random();
        public static List<Card> cards = new List<Card>();     

        public static void CardCreator()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 13; k++)
                    {
                        cards.Add(new Card((CardColor)i, (CardSuit)j, (CardRank)k));

                        if (k <= 8)
                        {
                            cards[cards.Count - 1].Value = k + 2;
                        }
                        else if (k == 12)
                        {
                            cards[cards.Count - 1].Value = 11;
                        }
                        else
                        {
                            cards[cards.Count - 1].Value = 10;
                        }
                    }
                }
            }
        }
        
        public static void ShuffleDeck()
        {
            cards = cards.OrderBy(x => random.Next()).ToList();
        }

        public static int GetValue(Card input)
        {
            return input.Value;
        }

        public static Card PullFirst()
        {
            Card firstCard = cards.FirstOrDefault();
            //cards.RemoveAt(0);
            return firstCard;
        }

        public static Card PullLast()
        {
            Card lastCard = cards.LastOrDefault();
            //cards.RemoveAt(cards.Count - 1);
            return lastCard;
        }

        public static Card PullRandom()
        {
            Card randomCard = cards[random.Next(cards.Count)];
            //cards.Remove(randomCard);
            return randomCard;
        }
    }
}