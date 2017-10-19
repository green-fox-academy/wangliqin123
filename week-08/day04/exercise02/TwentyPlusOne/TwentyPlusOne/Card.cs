using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Card : Deck
    {
        public CardColor Color;
        public CardSuit Suit;
        public CardRank Rank;
        public int score;

        public Card(CardColor color, CardSuit suit, CardRank rank)
        {
            Color = color;
            Suit = suit;
            Rank = rank;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Color, Suit, Rank);
        }

        public bool IsPictureCard
        {
            get
            {
                return Rank >= CardRank.J && Rank <= CardRank.K;
            }
            set
            {
                IsPictureCard = value;
            }
        }

        public int Score
        {
            get
            {
                if (IsPictureCard)
                {
                    return 10;
                }
                else if (Rank == CardRank.A)
                {
                    return 11;
                }
                else
                {
                    return (int)Rank + 2;
                }
            }
            set
            {
                score = value;
            }
        }
    }

    public enum CardColor
    {
        red,
        black
    }

    public enum CardSuit
    {
        clubs,
        diamonds,
        hearts,
        spades
    }

    public enum CardRank
    {
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        J,
        Q,
        K,
        A
    }
}