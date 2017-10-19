using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Card
    {
        public CardColor Color;
        public CardSuit Suit;
        public CardRank Rank;

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