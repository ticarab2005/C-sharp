﻿using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Loop that prints all values from 1-255
            for(var value = 0; value <= 255; value++)
            {
                Console.WriteLine(value);
            }

            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for(var value = 1; value <= 100; value++)
            {
                bool byThreeOrFive = (value % 3 == 0 || value % 5 == 0);
                bool notThreeAndFive = !(value % 3 == 0 && value % 5 == 0);

                if(byThreeOrFive && notThreeAndFive)
                {
                    Console.WriteLine(value);
                }
            }

            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for(var value = 1; value <= 100; value++)
            {
                bool byThree = (value % 3 == 0);
                bool byFive =  (value % 5 == 0);
                bool byThreeAndFive = (value % 3 == 0 && value % 5 == 0);

                if(byThreeAndFive)
                {
                    Console.WriteLine($"Fizz Buzz (value:{value})");
                }
                else if(byThree)
                {
                    Console.WriteLine($"Fizz (value:{value})");
                }
                else if(byFive)
                {
                    Console.WriteLine($"Buzz (value:{value})");
                }
            }
        }
    }
}