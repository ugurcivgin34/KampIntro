using System;
using System.Collections.Generic;

namespace PersonelBilgiSistemi
{
    class Program
    {
        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();
        static void Main(string[] args)
        {

            PersonelEkle(tc: 67309105720, adSoyad: "Veysel Perü", adres: "SahrayıCedit/Kadıköy.", telefon: "05327741763");
            PersonelEkle(tc: 12065847520, adSoyad: "Uğur Okan Çivgin", adres: "Ümraniye/İstanbul", telefon: "05385839563");
            PersonelEkle(tc: 25421036985, adSoyad: "Önder Özben", adres: "Esenler/İstanbul", telefon: "02545245896");

            //PersonelGüncelle(tc: 0, adSoyad: "Semanur Mutlu", adres: "SahrayıCedit/Kadıköy.", telefon: "12324643453");
            //PersonelSil(12065847520);
            Console.WriteLine();
            Console.WriteLine(PersonelGetir());
            //for (int i = 0; i < TCler.Count; i++)
            //{
            //    Console.WriteLine(TCler[i]);
            //    Console.WriteLine(adSoyadlar[i]);
            //    Console.WriteLine(adresler[i]);
            //    Console.WriteLine(telefonlar[i]);
            //    Console.WriteLine("---------------------");
            //}
        } //Main Sonu

        static string PersonelGetir(long tc=0,string adSoyad="")
        {
            string personel = "";
            int indisGetir = -1;
            if (tc != 0)
            {
                personel = "TC bulunamadı";
                
            }
            if (adSoyad != "")
            {
                personel = "Ad ve soyad bulunamadı";
               
            }
            if (tc!=0)
            {
                indisGetir = PersonelIndexGetir(tc);
            }else
            {
                indisGetir = adSoyadlar.IndexOf(adSoyad);
            }
            if (indisGetir !=-1)
            {
                personel = Convert.ToString(TCler[indisGetir] + " " +
                    adSoyadlar[indisGetir] + " " +
                     adresler[indisGetir] + " " +
                      telefonlar[indisGetir]);
            }
            return personel;
            
        }
        static void PersonelSil(long tc)
        {
            int indisGetir = -1;
            indisGetir = PersonelIndexGetir(tc);
            if(indisGetir!=-1)
            {
                Console.WriteLine(tc+" tc li  kişisi silindi");
                TCler.RemoveAt(indisGetir);
                adSoyadlar.RemoveAt(indisGetir);
                adresler.RemoveAt(indisGetir);
                telefonlar.RemoveAt(indisGetir);

            }
            else
            {
                Console.WriteLine("Böyle bir kullanıcı yok.Bu yüzden işlem yapılamadı");
            }
        }
        static void PersonelGüncelle(long tc, string adSoyad, string adres, string telefon)
        {
            int indexGetir = -1;
            indexGetir = PersonelIndexGetir(tc);

            if (indexGetir != -1)
            {
                if (!TcKontrol(tc))
                {
                    if (tc == 0)
                    {
                        Console.WriteLine("Tc alanı 0 olamaz.Lütfen entera basınız");
                        Console.ReadLine();
                        return;
                    }
                    if (!TcKontrol(tc))
                    {
                        Console.WriteLine(adSoyad + " Adlı kişisinin  Tc formatı yanlış.Bu yüzden güncellenemedi.Lütfen entera basınız");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                Console.WriteLine(tc + " Tc bulunduğu için " + adSoyad + " yeni ismi ile güncellendi");
                if (adSoyad != "") adSoyadlar[indexGetir] = adSoyad;
                if (adres != "") adresler[indexGetir] = adres;
                if (telefon != "") telefonlar[indexGetir] = telefon;
            }
            else
            {
                if (tc == 0) Console.WriteLine("Tc 0 olamaz.Bu yüzden güncellenemedi"); return;
                Console.WriteLine(tc+" tc  bulunamadığı için güncellenemedi");
                return;
            }
        }
        static void PersonelEkle(long tc, string adSoyad, string adres, string telefon)
        {
            int indisGetir = -1;
            if (tc == 0)
            {
                Console.WriteLine("Tc alanı 0 olamaz.Lütfen entera basınız");
                Console.ReadLine();
                return;
            }
            if (!TcKontrol(tc))
            {
                Console.WriteLine(adSoyad + " Adlı kişisinin  Tc formatı yanlış.Bu yüzden eklenemedi.Lütfen entera basınız");
                Console.ReadLine();
                return;
            }

            indisGetir = PersonelIndexGetir(tc);

            if (indisGetir == -1)
            {
                if (adSoyad == "")
                {
                    Console.WriteLine("Ad soyad boş olamaz.Entera basınız");
                    Console.ReadLine();
                    return;
                }
                TCler.Add(tc);
                adSoyadlar.Add(adSoyad);
                adresler.Add(adres);
                telefonlar.Add(telefon);
            }

        }


        private static int PersonelIndexGetir(long tc)
        {
            int indexGetir = -1;
            if (TCler.Contains(tc))
            {
                indexGetir = TCler.IndexOf(tc);
            }
            return indexGetir;
        }

        private static bool TcKontrol(long tc)
        {
            if (tc < 10000000000 || tc > 99999999999)
                return false;
            return true;
        }
    }
}
