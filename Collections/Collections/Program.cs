using System;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            BuildDeck();
        }

        public static Deck<Card> BuildDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            string[] cards = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string card in cards)
            {
                deck.Add(new Card(card, Card.Suits.Hearts));
                Console.WriteLine($"{card} {Card.Suits.Hearts}");
                deck.Add(new Card(card, Card.Suits.Diamonds));
                Console.WriteLine($"{card} {Card.Suits.Diamonds}");
                deck.Add(new Card(card, Card.Suits.Spades));
                Console.WriteLine($"{card} {Card.Suits.Spades}");
                deck.Add(new Card(card, Card.Suits.Clubs));
                Console.WriteLine($"{card} {Card.Suits.Clubs}");
            }
            return deck;
        }
    }
}
