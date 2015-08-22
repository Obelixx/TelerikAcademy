using System;
using NUnit.Framework;
using Santase.Logic.Cards;
using Santase.Logic;
using System.Collections.Generic;
using System.Linq;

namespace Santase.Tests
{
    [TestFixture]
    public class DeckTests
    {
        private const int FULL_DECK_SIZE = 24;

        [Test]
        public void NewDeckMustHave24Cards()
        {
            var deck = new Deck();
            Assert.AreEqual(FULL_DECK_SIZE, deck.CardsLeft);
        }

        [TestCase(1)]
        [TestCase(3)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(24)]
        public void CardsLeftMustGoSmallerAfterDrowingCards(int count)
        {
            var deck = new Deck();
            for (int i = 0; i < count; i++)
            {
                deck.GetNextCard();
            }
            Assert.AreEqual(FULL_DECK_SIZE - count, deck.CardsLeft);
        }

        [Test]
        public void NewDeckMustHave24differentCards()
        {
            var deck = new Deck();
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 24; i++)
            {
                cards.Add(deck.GetNextCard());
            }
            List<Card> cardsWithoutDublicates = cards.Distinct().ToList<Card>();
            Assert.AreEqual(cards.Count, cardsWithoutDublicates.Count,"Cards count must be equal.");
        }

        [Test]
        public void ChangeTrumpCardShouldChangeTheTrumpCard()
        {
            var deck = new Deck();
            Card initialTrumpCard = deck.GetTrumpCard;
            Card newCard = deck.GetNextCard();
            deck.ChangeTrumpCard(newCard);
            Assert.AreNotSame(initialTrumpCard, deck.GetTrumpCard);
        }

        [Test]
        public void ChangeTrumpCardWitoutCardsInTheDeckShouldNotChangeTrumpCard()
        {
            var deck = new Deck();
            Card trumpCard = deck.GetNextCard();
            deck.ChangeTrumpCard(trumpCard);
            Card lastCard = deck.GetNextCard();
            while (deck.CardsLeft > 0)
            {
                lastCard = deck.GetNextCard();
            }
            Assert.AreEqual(0, deck.CardsLeft,"No cards left.");
            deck.ChangeTrumpCard(lastCard);
            Assert.AreSame(trumpCard, deck.GetTrumpCard, "Trump card should not be changed.");
        }

        [ExpectedException(typeof(InternalGameException))]
        [Test]
        public void Drawing25cards()
        {
            var deck = new Deck();
            for (int i = 0; i < 25; i++)
            {
                deck.GetNextCard();
            }
        }


    }
}
