using System;

namespace sessionDemo.Models
{
    public class Player
    {
        public string name{get;set;}
        public string hand {get;set;} = "Paper";
        public string[] choices = new string[]{"Rock","Paper","Scissors"};
        public void PlayHand()
        {
            Random rand = new Random();
            this.hand = choices[rand.Next(choices.Length)];
        }
    }
}