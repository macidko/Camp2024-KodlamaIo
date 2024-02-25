using System;

namespace MaskeTakip
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int sonuc = Topla(6, 58);

            //Diziler / Arrays

            //string ogrenci1 = "Eren";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "Eren";
            //ogrenciler[1] = "Kerem";
            //ogrenciler[2] = "Berkay";
            //ogrenciler = new string[4];
            //ogrenciler[4] = "İlker";

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i]);
            //}

            //string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            //string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            //Console.WriteLine(sehirler2[0]);

            Person person = new Person();
            person.FirstName = "Eren";
            person.LastName = "Macit";
            person.DateOfBirthYear = 1997;
            person.NationalIdentity = 2222;

            //Person person2 = new Person();
            //person2.FirstName = "Eren";

            //foreach (var sehir in sehirler1)
            //{
            //    Console.WriteLine(sehir);
            //}

            //List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            //yeniSehirler1.Add("Adana1");
            //foreach (var sehir in yeniSehirler1)
            //{
            //    Console.WriteLine(sehir);
            //}

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);

            Console.ReadLine();

            static void SelamVer(string isim = "isimsiz")
            {
                Console.WriteLine("Selam" + isim);
            }

            static int Topla(int sayi1 = 10, int sayi2 = 20)
            {
                int sonuc = sayi1 + sayi2;
                Console.WriteLine("Toplam: " + sonuc.ToString());
                return sonuc;
            }
            static void Degiskenler()
            {
                string mesaj = "Merhaba";
                double tutar = 2000; //Database
                int sayi = 100;
                bool girisYapmisMi = false;

                string ad = "Eren";
                string soyad = "Macit";
                int dogumYili = 1997;
                long tcNo = 12345678911;

                Console.WriteLine(tutar * 1.18);
            }

        }
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }
        }
    }
}