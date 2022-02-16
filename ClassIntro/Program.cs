using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mert";
            int yas = 25;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C# Kursu";
            kurs1.Egitmen = "Mert Ünlüsoy";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java Kursu";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 32;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python Kursu";
            kurs3.Egitmen = "Mert Ünlüsoy";
            kurs3.IzlenmeOrani = 3;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "TEMEL Kurs";
            kurs4.Egitmen = "Mert Ünlüsoy";
            kurs4.IzlenmeOrani = 100;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani + "%");
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }


}
