using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Deck oneCard = new Deck ();
            oneCard.Shuffle();
            for(int i=0;i<52;i++)
            {
                System.Console.Write("{0,-14}", oneCard.Deal());
                if((i+1)%4 ==0)
                    Console.WriteLine();
            }
            foreach(string c in Card)
            {
                Console.WriteLine(c);
            }
            // Step one: Create a card class
            // Step two: Create a deck
            // string[] suits = new string[] {"Heart","Diamond","Spade","Club"};
            // List<string[]> Deck = new List<string[]>(); 
        }
    }
}

// Create a class called "Card"

// Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a string.
// Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
// Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.


// Next, create a class called "Deck"

// Give the Deck class a property called "cards" which is a list of Card objects.
// When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
// Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
// Give the Deck a reset method that resets the cards property to contain the original 52 cards.
// Give the Deck a shuffle method that randomly reorders the deck's cards.


// Finally, create a class called "Player"

// Give the Player class a name property.
// Give the Player a hand property that is a List of type Card.
// Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
// Note this method will require reference to a deck object
// Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.