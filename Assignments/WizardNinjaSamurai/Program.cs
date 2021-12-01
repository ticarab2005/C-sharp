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
            Wizard Magic = new Wizard("Tyrience",3,25,3,50);
            Magic.Attack(Fist);
            Magic.Heal(Magic);
            Console.WriteLine($"{Magic.Name} damaged {Fist.Name} Intelligence by {Fist.Health}");
            Ninja Vanish = new Ninja("MiMi",10,25,125,100);
            Samurai Slice = new Samurai("Cara",3,25,3,200);
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