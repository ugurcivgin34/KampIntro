using System;
using System.Collections.Generic;

namespace Odev4
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "uğur okan çivgin");
            myDictionary.Add(2, "sait çivgin");
            myDictionary.Add(3, "hakan çivgin");

            Console.WriteLine(myDictionary.Count);

            foreach (var item in myDictionary.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}

       

    