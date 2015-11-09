using System.Collections.Generic;

namespace CardDeckSample
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        private Deck()
        {
            // This is private so that Deck.CreateFullDeck() is used to create a deck
            Cards = new List<Card>();
        }

        public static Deck CreateFullDeck()
        {
            Deck deck = new Deck();
            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                for (int cardNumberIndex = 0; cardNumberIndex < 13; cardNumberIndex++)
                {
                    deck.Cards.Add(new Card((CardNumber)cardNumberIndex, (Suit)suitIndex));
                }
            }
            return deck;
        }

        public void SortAscending()
        {
            Cards.Sort();
        }
    }
}
