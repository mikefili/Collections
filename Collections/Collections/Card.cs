using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Card
    {
        public enum Suits { Hearts, Diamonds, Spades, Clubs }

        public string Value { get; set; }
        public Suits Suit { get; set; }

        public Card(string value, Suits suit)
        {
            Suit = suit;
            Value = value;
        }
    }
}
