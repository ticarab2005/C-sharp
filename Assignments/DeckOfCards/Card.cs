using System;

namespace DeckOfCards
{
    public class Card
    {
        public string stringVal;
        public string Suits;
        public int value;
        public static string[] suits = new string[4] { "Heart", "Diamond", "Spade", "Club" };

        public Card(string s, int val)
        {
            switch(val)
            {
                case 11:
                stringVal = "Jack";
                break;
                case 12:
                stringVal = "Queen";
                break;
                case 13:
                stringVal = "King";
                break;
                case 1:
                stringVal = "Ace";
                break;
                default:
                stringVal = val.ToString();
                break;
            }
            Suits = s;
            value = val;
        }
        public void SayCard()
        {
            System.Console.WriteLine("the {0} of {1}", stringVal, suit);
        }
    }
}