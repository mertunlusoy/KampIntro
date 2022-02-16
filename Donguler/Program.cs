using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlama INTRO", "Java Kursu", "Python Kursu", "C#", "C++"};


            for (int i = 0; i < kurslar.Length; i=i+1)  //genel for döngüsü
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\nFor döngüsü bitti, Foreach döngüsüne geçiliyor\n");

            foreach (string kurs in kurslar)        //dizileri tek tek dolaşmaya yarar
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\n---Sayfa Sonu---");
        }
    }
}
