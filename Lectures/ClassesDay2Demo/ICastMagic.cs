using System;

namespace ClassesDay2Demo
{
    interface ICastMagic
    {
        int mana {get;set;}
        void castSpell(string move)
        {
            mana -=10;
            Console.WriteLine($"The person cast a spell!");
        }
    }
}