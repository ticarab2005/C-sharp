using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Cara = new Player("Cara");
            Deck oneDeck = new Deck();
            oneDeck.Shuffle();
            Cara.Draw(oneDeck,5);
            Cara.Discard(1);
        }
    }
}