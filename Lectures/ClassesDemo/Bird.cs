namespace ClassesDemo
{
    public class Bird : Animal
    {
        public bool canFly;
        public Bird(string sp, int numLegs, double wgt, string clr, bool canFly) : base(sp,numLegs,wgt,clr)
        {
            canFly = true;
        }
    }
}