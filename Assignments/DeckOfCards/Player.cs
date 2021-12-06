using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }
        public Card Draw(Deck dk, int num)
        {
            System.Console.WriteLine($"{Name} deals {num} cards");
            Card oneCard = null;
            for (int i=0;i<=num;i++)
            {
            oneCard = dk.Deal();
            Hand.Add(oneCard);
            Console.WriteLine($"{Name} draws a {oneCard.cardVal} of {oneCard.suit}. She added it to her hand.");
            }
            return oneCard;
        }
        public Card Discard(int index)
        {
            if (index > Hand.Count -1 )
            {
                return null;
            } 
            else
            {
                Card discardPile= Hand[index];
                Hand.Remove(discardPile);
                Console.WriteLine($"Cara puts down the {discardPile.cardVal} of {discardPile.suit} from her hand, beating the opponent's card!");
                return discardPile;
            }
        }

    }
}