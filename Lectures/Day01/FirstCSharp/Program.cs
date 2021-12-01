// import
using System;
using System.Collections.Generic;

// think of namespace like a book in a library
namespace FirstCSharp
{
    // class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my first C# project!");
            // Our code here
            // Anthing inside of here is going to run
            string name = "Nichole";
            name = "Chris";

            // int
            int num = 29;
            int num2 = 19;
            // bool
            bool isHungry = false;
            // char
            char letter = 'N';
            Console.WriteLine("Your num is " + num + num2);
            Console.WriteLine($"Your num is {num}");
            // Console.WriteLine(myAlgo());
            Random rand = new Random();
            Console.WriteLine(rand.Next(5,11));
            int[] myArray = new int[] {1,2,3,4,5,6};
            //                         0,1,2,3,4,5
            myArray[2] = 18;

            List<string>
        }
        // static int myAlgo()
        // {
        //     return 7;
        // }
    }

}
