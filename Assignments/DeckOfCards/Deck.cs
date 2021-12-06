using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
    public string [] cardVal = new string[] {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};

    public string[] suit = new string[]{"Clubs","Spades","Hearts","Diamonds"};

    public List<Card> deck = new List<Card>();
    public Deck()
    {
        Reset();
    }

        public void Reset()
        {
            deck.Clear();
            for(int i = 0; i< cardVal.Length; i++)
        {
            for( int j = 0; j < suit.Length; j++)
            {
                Card newCard = new Card(cardVal[i], suit[j], i+1);
                deck.Add(newCard);
            }
        }
        }
        public Card Deal()
        {
            Console.WriteLine("Draws Card");
            Card dealt = deck[0];
            deck.Remove(dealt);
            return dealt;
        }
        public void Shuffle()
        {
            Console.WriteLine("Cara is shuffling the cards.");
            List<Card> cards2shuffle = this.deck;
            List<Card> shuffled = new List<Card>();
            Random randy = new Random();
            while(cards2shuffle.Count > 0)
            {
                int idx = randy.Next(0, cards2shuffle.Count);
                shuffled.Add(cards2shuffle[idx]);
                cards2shuffle.RemoveAt(idx);
            }
            this.deck = shuffled;
        // public void Shuffle()
        // {
        //     Random rand = new Random ();
        //     int index = 0;
        //     while (index < deck.Count)
        //     {
        //         Card temp = deck[index];
        //         int newIndex = rand.Next(0,deck.Count);
        //         deck[index] = deck[newIndex];
        //         deck[newIndex] = temp;
        //         index++;
            // }
        }


    }
}
