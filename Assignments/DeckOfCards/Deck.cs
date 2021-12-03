using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        public List<Card> Reset()
        {
            cards.Clear();
            for(int i=0;i<4;i++)
            {
                int j = 1;
                while(j<14)
                {
                    cards.Add(new Card(Card.Suits[i],j));
                    j++;
                }
            }
            return cards;
        }
        public List<Card> Cards
        {
            get{return this.cards;}
        }
        public Deck()
        {
            Reset();
        }
        public void ShowDeck()
        {
            foreach(Card c in cards)
            {
                c.SayCard();
            }
        }
        public Card Deal()
        {
            Card oneCard = cards[0];
            cards.RemoveAt(0);
            return oneCard;
        }
        public void Shuffle()
        {
            List<Card> cardstoshuffle = this.cards;
            List<Card> shuffle = new List<Card>();
            Random rand = new Random();
            while(cardstoshuffle.Count > 0)
            {
                int x = rand.Next(0, cardstoshuffle.Count);
                shuffle.Add(cardstoshuffle[x]);
                cardstoshuffle.RemoveAt(x);
            }
            this.cards = shuffle;
        }

    }
}