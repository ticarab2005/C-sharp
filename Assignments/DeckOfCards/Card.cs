using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Card
    {
        public string cardVal;
        public string suit;
        public int value;

        public Card(string cVal, string s, int val)
        {
            this.cardVal = cVal;
            this.suit= s;
            this.value =val;
    //         switch(val)
    //         {
    //             case 1:
    //             stringVal = "Ace";
    //             break;
    //             case 11:
    //             stringVal = "Jack";
    //             break;
    //             case 12:
    //             stringVal = "Queen";
    //             break;
    //             case 13:
    //             stringVal = "King";
    //             break;
    //             default:
    //             stringVal = val.ToString();
    //             break;
    //         }
    //         suits = st;
    //         value = val;
        }
    }
}
