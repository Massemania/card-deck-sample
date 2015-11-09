using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace CardDeckSample.Specs
{
    [Binding]
    public class DeckSteps
    {
        private Deck deck;

        [Given(@"An unshuffled deck")]
        public void GivenAnUnshuffledDeck()
        {
            deck = Deck.CreateFullDeck();
        }

        [When(@"the deck is shuffled")]
        public void WhenTheDeckIsShuffled()
        {
            deck.Shuffle();
        }

        [When(@"the deck is sorted")]
        public void WhenTheDeckIsSorted()
        {
            deck.SortAscending();
        }

        [Then(@"the deck should have (.*) cards")]
        public void ThenTheDeckShouldHaveCards(int totalCards)
        {
            Assert.AreEqual(52, deck.Cards.Count);
        }

        [Then(@"the deck should have (.*) suits")]
        public void ThenTheDeckShouldHaveSuits(int suitCount)
        {
            var suits = new HashSet<Suit>();
            foreach (var card in deck.Cards)
            {
                suits.Add(card.Suit);
            }
            Assert.AreEqual(suitCount, suits.Count);
        }

        [Then(@"the deck should have (.*) card numbers")]
        public void ThenTheDeckShouldHaveCardNumbers(int cardNumberCount)
        {
            var cardNumbers = new HashSet<CardNumber>();
            foreach (var card in deck.Cards)
            {
                cardNumbers.Add(card.Number);
            }
            Assert.AreEqual(cardNumberCount, cardNumbers.Count);
        }

        [Then(@"the deck should not have duplicate cards")]
        public void ThenTheDeckShouldNotHaveDuplicateCards()
        {
            var uniqueCards = new HashSet<Card>();
            foreach (var card in deck.Cards)
            {
                Assert.IsFalse(uniqueCards.Contains(card));
                uniqueCards.Add(card);
            }
            Assert.AreEqual(52, uniqueCards.Count);
        }

        [Then(@"the cards are in ascending order")]
        public void ThenTheCardsAreInAscendingOrder()
        {
            Card currentCard = null;
            foreach (var card in deck.Cards)
            {
                if (currentCard != null)
                {
                    Assert.IsTrue(card.CompareTo(currentCard) > 0);
                }
                currentCard = card;
            }
        }

    }
}
