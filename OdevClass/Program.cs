using System;
using System.Security.Cryptography.X509Certificates;

namespace OdevClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "Tablet";
            urun1.UrunMarkasi = "Apple";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.UrunAdi = "telefon";
            urun2.UrunMarkasi = "Apple";

            Urun urun3  =new Urun();
            urun3.Id = 3;
            urun3.UrunAdi = "Bilgisayar";
            urun3.UrunMarkasi = "Lenovo";


            Urun[] urunler = new Urun[]{urun1, urun2, urun3};

            Console.WriteLine("----------------FOR------------");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Id + " " + urunler[i].UrunAdi +" "+ urunler[i].UrunMarkasi);
                
            }

            Console.WriteLine("------------------------------");

            int x = 0;
            while(x<urunler.Length)
            {
                Console.WriteLine(urunler[x].Id + " " + urunler[x].UrunAdi + " " + urunler[x].UrunMarkasi);
                x++;
            }

            Console.WriteLine("---------------------------------");

            foreach (Urun urunList in urunler)
            {
                Console.WriteLine(urunList.Id + " " + urunList.UrunAdi + " " + urunList.UrunMarkasi);
            }
        }
    }


    class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string UrunMarkasi { get; set; }

    }
}
