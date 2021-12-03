using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        private string name;
        private List<Card> hand;
        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }
        public string Name
        {
            get{return name;}
        }
        public Card Draw(Deck dl)
        {
            Card oneCard = dl.Deal();
            hand.Add(oneCard);
            return oneCard;
        }
        public Card Discard(int x)
        {
            Card oneCard;
            if(x<hand.Count)
            {
                oneCard = hand[x];
                hand.RemoveAt(x);
                return oneCard;
            }
            else
            {
                return null;
            }
        }
    }
}