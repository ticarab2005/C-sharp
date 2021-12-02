using System;

namespace ClassesDay2Demo
{
    public class Mage : Character, ICastMagic
    {
        public int mana {get;set;}
        public Mage(string n) : base(n)
        {
            name = n;
            strength = 8;
            intelligence = 20;
            mana = 250;
        }
        public void castSpell(string move)
        {
            Console.WriteLine("The person cast a spell!");
            mana -=10;
        }
        public override void attack()
        {
            Console.WriteLine($"{name} launched an attack!");
        }
    }
}