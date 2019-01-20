using System;
using Xunit;
using Collections;

// X Add a card to your deck
// X Getter/Setters of your properties from your Card class
// X Remove a card from your deck that exists
// X Cannot remove a card from your deck that does not exist

namespace CollectionsTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddCard()
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card("Ace of ", Card.Suits.Spades));
            Assert.Equal(1, deck.Count());
        }

        [Fact]
        public void CanGetAndSetCardValue()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card = new Card("Ace of ", Card.Suits.Spades);
            deck.Add(card);
            Assert.Equal("Ace of Spades", $"{card.Value}{Card.Suits.Spades}");
        }

        [Fact]
        public void CanGetAndSetCardSuit()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card = new Card("Ace of ", Card.Suits.Spades);
            deck.Add(card);
            Assert.Equal(Card.Suits.Spades, card.Suit);
        }

        [Fact]
        public void CanRemoveCardInDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            Card cardOne = new Card("Ace of ", Card.Suits.Spades);
            Card cardTwo = new Card("Queen of ", Card.Suits.Hearts);
            deck.Add(cardOne);
            deck.Add(cardTwo);
            deck.Remove(cardTwo);
            Assert.Equal(1, deck.Count());
        }

        [Fact]
        public void CannotRemoveCardNotInDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            Card cardOne = new Card("Ace of ", Card.Suits.Spades);
            Card cardTwo = new Card("Queen of ", Card.Suits.Hearts);
            Card cardThree = new Card("Jack of", Card.Suits.Diamonds);
            deck.Add(cardOne);
            deck.Add(cardTwo);
            Assert.Throws<IndexOutOfRangeException>(() => deck.Remove(cardThree));
        }
    }
}
