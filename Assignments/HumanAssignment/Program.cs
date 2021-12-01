using System;

namespace HumanAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Human a = new Human("Cara");
            Human b = new Human("Keila");
            a.Attack(b);
            Console.WriteLine($"{a.Name} damaged {b.Name} by {b.Health}");
            
        }
    }
}
