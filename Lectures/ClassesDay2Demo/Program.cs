using System;
using System.Collections.Generic;

namespace ClassesDay2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can't do this if the Character class is abstract
            // Character c1 = new Character("Default");
            Warrior fluffy = new Warrior("Fluffy");
            fluffy.showStats();
            Mage son = new Mage("Son of Anton");
            son.showStats();
            son.castSpell("fireball");
            Warlock zorbo = new Warlock("Zorbo");

            List<Character> allCharacters = new List<Character>();
            allCharacters.Add(fluffy);
            allCharacters.Add(son);
            allCharacters.Add(zorbo);

            List<ICastMagic> allMagicUsers = new List<ICastMagic>();
            foreach (Character a in allMagicUsers)
            {
                {
                    Console.WriteLine(a.name);
                }
                // }
                // allMagicUsers.Add(son);
                // allMagicUsers.Add(zorbo);
            }
        }
    }
}
