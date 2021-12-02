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
            Console.WriteLine($"{Fist.Name} damaged {Hands.Name} by {Hands.Health} leaving {Hands.Name} with 15 health");
            Ninja Vanish = new Ninja("MiMi",10,25,125,100);
            Wizard Magic = new Wizard("Tyrience",3,25,3,50);
            Samurai Slice = new Samurai("Cara",3,25,3,200);
            Magic.Attack(Vanish);
            Vanish.Attack(Slice);
            Slice.Attack(Hands);
            Magic.Heal(Fist);
            Slice.Meditate(Slice);
            Vanish.Steal(Fist);
        }
    }
}


// Provide an override Attack method to Samurai, which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.

// Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
