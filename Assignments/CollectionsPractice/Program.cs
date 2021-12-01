using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10];
            for (int i = 0; i < numArray.Length; i++)
                numArray[i] = i;
            foreach (int i in numArray)
            {
                Console.WriteLine(i);
            }

            string[] strArray = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }

            bool[] arrayBool = new bool[10];
            for (int i = 0; i < arrayBool.Length; i++)
            {
                if (arrayBool[i] = i % 2 == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }


            List<string> names = new List<string>();
            names.Add("Strawberry");
            names.Add("Mint");
            names.Add("Chocolate");
            names.Add("Vanilla");
            names.Add("Sherbert");
            {
                Console.WriteLine(String.Join(", ", names));
            }
            Console.WriteLine($"Third Flavor: {names[2]}");
            names.RemoveAt(2);
            {
                Console.WriteLine(String.Join(", ", names));
            }
            Random rand = new Random();
            string[] name = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            List<string> iceCream = new List<string>();
            iceCream.Add("Strawberry");
            iceCream.Add("Mint");
            iceCream.Add("Vanilla");
            iceCream.Add("Sherbert");
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            for (int i = 0; i < name.Length; i++)
            {
                myDictionary.Add(names[i], iceCream[rand.Next(iceCream.Count)]);
            }
            foreach (KeyValuePair<string, string> val in myDictionary)
            {
                Console.WriteLine(val.Key + " : " + val.Value);
            }





        }
    }
}
