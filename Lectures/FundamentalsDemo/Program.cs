using System;
using System.Collections.Generic;

namespace FundamentalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fundamentals demo!");
            // C# does accept a var datatype
            // var something = "something";
            // We want to be explicit with our variable types
            // String
            // string something2 = "something";  
            // //Integer
            // int num = 7;
            // // Boolean
            // bool fact = true;
            // // Array
            // [1,2,3,4,5]
            // ["hello","world"]
            // ["one", 2 ,"world"]
            // Arrays MUST  have a predefined number of values stored in it
            int[] numberArray = new int[] {1,2,3,4,5,7,6,10};
            numberArray[3] = 17;
            Console.WriteLine(numberArray);
            for(int i = 0; i <numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            // List
            List<string> names = new List<string>();
            names.Add("7");
            names.Add("Nichole");
            names.Add("Mitch");
            names.Add("7");
            names.Add("Ryan");
            // Removes the first instance it encounters that matches the search query
            names.Remove("7");
            names.Remove("7");
            // names.RemoveAt(2);
            names.Insert(1, "Habib");
            // Console.WriteLine(names[1]);
            foreach(string name in names)
            {
                Console.WriteLine($"{name}");
            }
            Console.WriteLine(String.Join(", ", names));
            // Dictionary
            // A dictionary is made up of keys and values
            // {"key": "value", "key2",: "value2" }
            Dictionary<string,int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("A", 10);
            myDictionary.Add("B", 25);
            Console.WriteLine($"The value at A is: {myDictionary["A"]}");
            foreach(KeyValuePair<string,int> val in myDictionary)
            {
                Console.WriteLine(val.Key + ":" + val.Value );
            }
            foreach(var val in myDictionary)
            {
                Console.WriteLine(val.Key + ":" + val.Value );
            }
            // Console.WriteLine(something);
        }
    }
}
