using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string nam, int intel, int dex, int hlt, int hl) : base(nam,intel,dex,hlt)
        {

        }
        public override int Attack(Human target)
        {
            int dmg = base.Attack(target, Intelligence * 5);
            Health -= dmg;
            return dmg;
        }
        public void Heal(Human target)
        {
            int heal = 10 * Intelligence;
                target.Health += heal;
        }
    }
}