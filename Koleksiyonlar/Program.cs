using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Uğur Okan Çivgin");
            isimler.Add("Sait Çivgin");

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
