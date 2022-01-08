using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs kurs1 = new Kurs();
            kurs1.Age = 27;
            kurs1.FirstName = "Uğur Okan";
            kurs1.LastName = "Çivgin";
            kurs1.CourseName = "C#";

            Kurs kurs2 = new Kurs();
            kurs2.Age = 20;
            kurs2.FirstName = "Sait";
            kurs2.LastName = "Çivgin";
            kurs2.CourseName = "Java";

            Kurs kurs3 = new Kurs();
            kurs3.Age = 20;
            kurs3.FirstName = "Enes";
            kurs3.LastName = "Evlat";
            kurs3.CourseName = "Python";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.FirstName);
            }


        }



        class Kurs
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string CourseName { get; set; }

        }
    }
}
