using System;

namespace ClassesDay2Demo
{
    interface ICastMagic
    {
        int mana {get;set;}
        void castSpell(string move)
        {
            Console.WriteLine($"The person cast a spell!");
            mana -=10;
        }
    }
}