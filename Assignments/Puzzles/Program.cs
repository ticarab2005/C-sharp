using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine(TossCoin());
            var result = Names();
        }
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int sum = 0;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(5, 26);
            }
            foreach (int num in nums)
            {
                sum += num;
                if (min > num)
                    min = num;
                if (max < num)
                    max = num;
            }
            Console.WriteLine($"Min: {min}, Max:{max}, Sum {sum}");
            return nums;
        }
        public static string TossCoin()
        {
            Random rand = new Random();
            string result;
            if (rand.Next(2) == 0)
                result = "Heads";
            else
                result = "Tails";
            Console.WriteLine($"Coin flipped: {result}");
            return result;
        }
        public static double TossMultipleCoins(int num)
        {
            Random rand = new Random();
            int numHeads = 0;
            for(var flip = 0; flip < num; flip++)
            {
                if(rand.Next(2) == 0)
                numHeads++;
            }
            Console.WriteLine($"Double flipped: {numHeads/num}");
            return (double)numHeads/num;
        }
        public static List<string> Names()
        {
            List<string> aName = new List<string>();
            aName.Add("Todd");
            aName.Add("Tiffany");
            aName.Add("Charlie");
            aName.Add("Geneva");
            aName.Add("Sydney");
            Random rand = new Random();
            for (var i=0; i< aName.Count;i++)
            {
                int randomName = rand.Next(aName.Count);
                string temp = aName[randomName];
                aName[randomName] = aName[i];
                aName[i] = temp;
            }
            foreach(var name in aName)
            {
                Console.WriteLine(name);
            }
            for(var i = 0; i < aName.Count; i++)
            {
                if(aName[i].Length < 5)
                {
                aName.RemoveAt(i);
                }
            }
            Console.WriteLine("Names longer than five characters");
            foreach(var name in aName)
            {
                
                Console.WriteLine(name);
            }
            return aName;
        }
    }
}
