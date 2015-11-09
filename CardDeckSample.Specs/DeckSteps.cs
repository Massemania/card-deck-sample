using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CardDeckSample.Specs
{
    [Binding]
    public class DeckSteps
    {
        private Deck Deck;

        [Given(@"An unshuffled deck")]
        public void GivenAnUnshuffledDeck()
        {
            Deck = Deck.CreateFullDeck();
        }
        
        [Then(@"the deck should have (.*) cards")]
        public void ThenTheDeckShouldHaveCards(int totalCards)
        {
            Assert.AreEqual(52, Deck.Cards.Count);
        }
        
        [Then(@"the deck should have (.*) cards in (.*) suits")]
        public void ThenTheDeckShouldHaveCardsInSuits(int cardsPerSuit, int suitCount)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the deck should not have duplicate cards")]
        public void ThenTheDeckShouldNotHaveDuplicateCards()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
