using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public int Steal;

        public Ninja(string nam, int intel, int dex, int hlt, int stl) : base(nam,intel,dex,hlt)
        {
            Steal = stl;
        }
        
    }
}
