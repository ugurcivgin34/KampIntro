using System;
using System.Linq;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {


            int sayi1;
            int sayi2;
            var result =Topla(out sayi1, out sayi2);
            Console.WriteLine(sayi1);
        }

        static int Topla(out int x, out int y )
        {
            x = 10;
            y = 20;
            return x + y;
        }
        //static int Topla(params int[] sayi)
        //{
        //    return sayi.Sum();
        //}
    }

    
}
