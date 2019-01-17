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

        
    }
}
