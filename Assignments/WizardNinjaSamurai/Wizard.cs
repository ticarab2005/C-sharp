using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string nam, int intel, int dex, int hlt, int hl) : base(nam, intel, dex, hlt)
        {

        }
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            base.Attack(target, dmg);
            target.Health -= dmg;
            Console.WriteLine($"{Name} used magic, dealing {dmg} damage to {target.Name}'s Intelligence");

            target.Health += dmg;
            Console.WriteLine($"Because magic was a successful hit, it auto healed {Name}'s by {dmg}+ health!");
            return target.Health;
        }
        public void Heal(Human target)
        {
            int heal = 10 * Intelligence;
            target.Health += heal;
            Console.WriteLine($"{Name} uses Heal, which deals {heal} Intelligence to {target.Name}");
        }
    }
}