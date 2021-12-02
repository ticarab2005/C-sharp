using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string nam, int stg, int intel, int hlt, int med) : base(nam,stg,intel,hlt)
        {
        }
        // public override int Attack(Human target)
        // {
        //     int Strength = Attack(target);
        //     if(Strength < 50)
        //     {
        //         target.Health = 0;
        //     Console.WriteLine($"{Name} damaged {target.Name} with {Strength} health, dealing the final blow!");
        //     }
        //         return Strength;
        // }
        public void Meditate(Human target)
        {
            health = 200;
            Console.WriteLine($"{Name} uses Heal, which gives her {health} health!");
        }
    }
    }
