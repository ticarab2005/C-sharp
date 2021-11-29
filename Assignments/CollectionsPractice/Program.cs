using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
            for(int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            string[] strArray = new string[] {"Tim","Martin","Nikki","Sara"};
            for(int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(strArray[i]);
            }
            string[] arrayBool = new string[10] {$"true","false","true","false","true","false","true","false","true","false"};
            for(int i = 0; i<arrayBool.Length; i++)
            {
                Console.WriteLine(arrayBool[i]);
            }
            List<string> names = new List<string>();
            names.Add("Strawberry");
            names.Add("Mint");
            names.Add("Vanilla");
            names.Add("Chocolate");
            names.Add("Sherbert");
            {
                Console.WriteLine(String.Join(", ", names));
            }
                Console.WriteLine(names[3]);
            names.Remove("Chocolate");
            {
                Console.WriteLine(String.Join(", ", names));
            }
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("Tim","Strawberry");
            myDictionary.Add("Martin","Mint");
            myDictionary.Add("Nikki","Vanilla");
            myDictionary.Add("Sara","Sherbert");
            foreach(KeyValuePair<string,string> val in myDictionary)
            {
                Console.WriteLine(val.Key + " : " + val.Value );
            }





        }
    }
}
