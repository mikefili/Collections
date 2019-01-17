using System;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BuildDeck();
            Console.WriteLine("Please wait while the dealer shuffles . . . ");
            Deck<Card> dealer = BuildDeck();
            Deck<Card> playerOne = new Deck<Card>();
            Deck<Card> playerTwo = new Deck<Card>();
            Console.WriteLine("Please wait while the dealer deals . . . ");
            Deal(dealer, playerOne, playerTwo);
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

        public static void Deal(Deck<Card> dealer, Deck<Card> playerOne, Deck<Card> playerTwo)
        {
            int deckSize = dealer.cardsInDeck.Length;
            int leftovers = deckSize;
            string whoseTurn = "Player One";
            bool validate = true;

            if (deckSize % 2 != 0)
            {
                deckSize = deckSize - 1;
                validate = false;
            }
            Console.WriteLine($"Leftovers: {leftovers}");

            for (int i = 0; i < deckSize; i++)
			{
                leftovers--;
                Console.WriteLine($"{dealer.cardsInDeck[0].Value} of {dealer.cardsInDeck[0].Suit} to {whoseTurn}");

                if (whoseTurn == "Player One")
	            {
                    playerOne.Add(dealer.cardsInDeck[0]);
                    whoseTurn = "Player Two";
                    Console.WriteLine("Player One's Hand: ");
                    foreach (Card card in playerOne)
	                {
                        Console.Write($"{card.Value} of {card.Suit}");
	                }
                    Console.WriteLine();
	            }
                else if (whoseTurn == "Player Two")
	            {
                    playerTwo.Add(dealer.cardsInDeck[0]);
                    whoseTurn = "Player One";
                    Console.WriteLine("Player Two's Hand: ");
                    foreach (Card card in playerTwo)
	                {
                        Console.Write($"{card.Value} of {card.Suit}");
	                }
                    Console.WriteLine();
	            }
                dealer.Remove(dealer.cardsInDeck[0]);

                Console.WriteLine("Dealer's Hand: ");
                if (validate && leftovers == 0)
                {
                    Console.WriteLine("All cards are on the table.");
                }
                else
                {
                    foreach (Card card in dealer)
                    {
                        Console.WriteLine($"{card.Value} of {card.Suit}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"Cards Left: {leftovers}");
			}
        }
    }
}
