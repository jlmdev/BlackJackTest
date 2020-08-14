using System;
using System.Collections.Generic;

namespace blackjack
{
    class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }
        public int Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Deck List
            var deck = new List<Card>();
            // Define arrays of suits and faces for assignment
            var assignedSuit = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
            var assignedFace = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // loops to assign card suits and faces
            for (var suitIndex = 0; suitIndex < assignedSuit.Length; suitIndex++)
            {
                for (var faceIndex = 0; faceIndex < assignedFace.Length; faceIndex++)
                {
                    // Assign suit and face to cards
                    string cardSuit = assignedSuit[suitIndex];
                    string cardFace = assignedFace[faceIndex];
                    var newCard = new Card();

                    {
                        newCard.Suit = cardSuit;
                        newCard.Face = cardFace;
                    }

                    deck.Add(newCard);
                }
            }

            // Test printing out all of the cards

            foreach (var cardName in deck)
            {
                Console.WriteLine($"{cardName.Face} of {cardName.Suit}");
            }
        }
    }
}