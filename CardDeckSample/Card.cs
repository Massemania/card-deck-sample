using System;

namespace CardDeckSample
{
    public class Card : IComparable<Card>
    {
        public CardNumber Number { get; private set; }
        public Suit Suit { get; private set; }

        public Card(CardNumber number, Suit suit)
        {
            Number = number;
            Suit = suit;
        }

        public int CompareTo(Card other)
        {
            // Card number is most important for our sorting
            if (Number != other.Number)
                return Number.CompareTo(other.Number);

            // The card numbers are the same, so compare suits as a fallback
            return Suit.CompareTo(other.Suit);
        }
    }
}
