using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Kerem Koca");
            myDictionary.Add(2, "Yiğit Özkaya");
            myDictionary.Add(3, "Sadık Emre Polat");

            myDictionary.ToList();
            Console.WriteLine(myDictionary.Count());
        }
    }
}
