using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string nam, int stg, int intel, int hlt, int med) : base(nam, stg, intel, hlt)
        {
        }
        public override int Attack(Human target)
        {
            if (target.Health < 50)
            base.Attack(target,Health);
            {
                target.Health = 0;
                Console.WriteLine($"{Name} damaged {target.Name} with {target.Health} health, dealing the final blow!");
            }
            return target.Health;
        }
        public void Meditate(Human target)
        {
            health = 200;
            Console.WriteLine($"{Name} uses Meditate, which gives her {health} health!");
        }
    }
}
