using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Fist = new Human("Tasha");
            Human Hands = new Human("Tammy");
            Fist.Attack(Hands);
            Console.WriteLine($"{Fist.Name} damaged {Hands.Name} by {Hands.Health}");
            Ninja Vanish = new Ninja("MiMi",10,25,125,100);
            Wizard Magic = new Wizard("Tyrience",3,25,3,50);
            Samurai Slice = new Samurai("Cara",3,25,3,200);
            Magic.Attack(Vanish);
            Console.WriteLine($"{Magic.Name} damaged {Vanish.Name}'s Intelligence while healing {Magic.Name} by {Vanish.Health}");
            Magic.Attack(Vanish);
            Console.WriteLine($"{Magic.Name} damaged {Vanish.Name}'s Intelligence while healing {Magic.Name} by {Vanish.Health}");
            Slice.Attack(Magic);
            Console.WriteLine($"{Slice.Name} attacked {Vanish.Name} damaging {Magic.Name} by {Vanish.Health}");

        }
    }
}

// Wizard should have a default health of 50 and Intelligence of 25

// Ninja should have a default dexterity of 175

// Samurai should have a default health of 200

// Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt

// Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.

// Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.

// Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence

// Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health

// Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.