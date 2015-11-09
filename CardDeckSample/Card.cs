using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckSample
{
    public class Card
    {
        public CardNumber Number { get; private set; }
        public Suit Suit { get; private set; }

        public Card(CardNumber number, Suit suit)
        {
            Number = number;
            Suit = suit;
        }
    }
}
