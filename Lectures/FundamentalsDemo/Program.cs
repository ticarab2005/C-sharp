// using System;

// namespace FundamentalsDemo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Fundamentals demo!");
//             // C# does accept a var datatype
//             var something = "something";
//             // We want to be explicit with our variable types
//             // String
//             string something2 = "something";  
//             //
//             Console.WriteLine(something);
//         }
//     }
// }

using System;

public class Program
{
    public static void Main()
    {
        int sum = 0;
        for (int i = 0; 3 * i < 1000; i++)
        {
            sum += 3 * i;

            if (5 * i < 1000 && (5 * i) % 3 != 0)
            {
                sum += 5 * i;
            }
        }
        Console.WriteLine(sum );
    }
}
