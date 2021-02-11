using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "One");
            Console.WriteLine(myDictionary.Length + "," + myDictionary.Length1);
            myDictionary.Add(2, "Two");
            Console.WriteLine(myDictionary.Length + "," + myDictionary.Length1);
            myDictionary.Add(3, "Three");
            Console.WriteLine(myDictionary.Length + "," + myDictionary.Length1);
            myDictionary.Add(4, "Four");
            myDictionary.Add(5, "Five");
        }
    }
}
