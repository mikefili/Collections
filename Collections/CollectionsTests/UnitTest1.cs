using System;
using Xunit;
using Collections;

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


    }
}
