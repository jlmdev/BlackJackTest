using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack
{
    class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }
        public int Value()
        {
            switch (Face)
            {
                case "Ace":
                    return 11;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "Jack":
                    return 10;
                case "Queen":
                    return 10;
                case "King":
                    return 10;
                default:
                    return 0;
            }
        }
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
            // IMPORTANT!! reference variable.property representing instance of the class's property directly
            // Results in CS0120: An object reference is required ... error otherwise

            // foreach (var cardName in deck)
            // {
            //     Console.WriteLine($"{cardName.Face} of {cardName.Suit} with value of {cardName.Value()}");
            // }

            // Shuffling Algorithm
            var numberOfCards = deck.Count();
            var randomNumberGenerator = new Random();

            for (var rightIndex = numberOfCards - 1; rightIndex > 0; rightIndex--)
            {
                var leftIndex = randomNumberGenerator.Next(rightIndex - 1);
                var leftCard = deck[rightIndex];
                var rightCard = deck[leftIndex];
                deck[rightIndex] = rightCard;
                deck[leftIndex] = leftCard;
            }

            // Test printing out all of the cards
            // IMPORTANT!! reference variable.property representing instance of the class's property directly
            // Results in CS0120: An object reference is required ... error otherwise

            // foreach (var cardName in deck)
            // {
            //     Console.WriteLine($"{cardName.Face} of {cardName.Suit} with value of {cardName.Value()}");
            // }
        }
    }
}