using System;

namespace ClassesDay2Demo
{
    public class Warrior : Character
    {
        public Warrior(string n) : base(n)
        {
            name = n;
            strength = 8;
            intelligence = 20;
            health = 110;
        }
        public override void attack()
        {
            Console.WriteLine($"{name} launched an attack!");
        }
    }
}