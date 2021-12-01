using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public int Meditate;

        public Samurai(string nam, int intel, int dex, int hlt, int med) : base(nam,intel,dex,hlt)
        {
            Meditate = med;
        }
    }
}