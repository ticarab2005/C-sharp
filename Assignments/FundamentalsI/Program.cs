using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
        int start = 1;
        int end = 255;
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i);
        }
        for (int i = 1; i <= 100; i++)
        {
            if(i % 3 == 0 || i % 5 == 0)
        {
            Console.WriteLine(i);
        }
        }
        for (int i =1; i <=100; i++)
        {
            if(i % 15 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
        }
        }
    }
}
