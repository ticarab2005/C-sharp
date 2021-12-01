using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public int Heal;

        public Wizard(string nam, int intel, int dex, int hlt, int hl) : base(nam,intel,dex,hlt)
        {
            Heal = hl;
        }
        // public override int Attack(Human target)
        // {
        //     int dmg =  * 5;
        //     target.Intelligence -= dmg;
        //     if()
        //     return target.health;
        // }
        // public void heal(Human target)
        // {
        //     Heal += 5;
        //     if(target.Intelligence < 10)
        //     {

        //     }
        //     return target.health;
        // }
    }
}