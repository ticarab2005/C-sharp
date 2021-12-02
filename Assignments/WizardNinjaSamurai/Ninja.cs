using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string nam, int intel, int dex, int hlt, int stl) : base(nam,intel,dex,hlt)
        {
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int dmg = Dexterity * 5;
            if (rand.Next(100) <= 20)
            {
                dmg += 10;
            }
            Console.WriteLine($"{Name} used ninjustsu, dealing {dmg} damage to {target.Name}'s Dexterity");
            Console.WriteLine($"Ninjutsu caused additional damage, dealing {dmg} to {target.Name}!");
            return target.Health;
        }
        public void Steal(Human target)
        {
            int Steal = target.Health;
            target.Health += base.Attack(target,5);
            Console.WriteLine($"{Name} uses steal, which gives {Steal} health to {Name}");
        }
    }
    }

