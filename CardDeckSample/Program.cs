using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // A deck could be created using Deck.CreateFullDeck() and shuffled,
            // sorted, etc...  The list of cards is exposed as a property.  A 'deal'
            // method could be added.

            var deck1 = Deck.CreateFullDeck();
            var deck2 = Deck.CreateFullDeck();

            deck1.Shuffle();
            deck2.Shuffle();

            for (int i = 0; i < deck1.Cards.Count; ++i)
            {
                if ((deck1.Cards[i].Number != deck2.Cards[i].Number) ||
                    (deck1.Cards[i].Suit != deck2.Cards[i].Suit))
                {
                    Console.WriteLine("They're different!");
                    return;
                }
            }

            Console.WriteLine("Uh oh...");
        }
    }
}
