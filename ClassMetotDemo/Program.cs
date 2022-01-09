using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Uğur Okan";
            musteri1.Soyad = "Çivgin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Sait";
            musteri2.Soyad = "Çivgin";

            Musteri[] musteri = new Musteri[] { musteri1, musteri2 };
            


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("-------------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            Console.WriteLine("-------------");
            musteriManager.Listele(musteri);
           

        }
    }
}
