using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 101;
            musteri1.Adi = "Mert";
            musteri1.Soyad = "Ünlüsoy";
            musteri1.DogumYili = 1997;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 102;
            musteri2.Adi = "Fernando";
            musteri2.Soyad = "Muslera";
            musteri2.DogumYili = 1987;

            Musteri musteri3 = new Musteri();
            musteri3.ID = 103;
            musteri3.Adi = "Harun";
            musteri3.Soyad = "Tekin";
            musteri3.DogumYili = 1985;

            Musteri musteri4 = new Musteri();
            musteri4.ID = 104;
            musteri4.Adi = "Mehmet";
            musteri4.Soyad = "Ahmet";
            musteri4.DogumYili = 1970;

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            MusteriManager customerManager = new MusteriManager();

            customerManager.MusteriyiEkle(musteri1);
            customerManager.MusteriyiEkle(musteri2);
            customerManager.MusteriyiEkle(musteri3);
            customerManager.MusteriyiEkle(musteri4);


            customerManager.MusteriyiSil(musteri2);
            Console.WriteLine("Müşteri Listesi");
            customerManager.MusteriyiListele();

            customerManager.MusteriyiEkle(musteri2);
            Console.WriteLine("Yeni müşteri listesi;");
            customerManager.MusteriyiListele();
            Console.ReadLine();
        }
    }
    class Musteri
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
    }
}
