using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";    //yorum satırı
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu gösterilecek!");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu gösterilecek!");
            }
            else
            {
                Console.WriteLine("Değişmedi(eşitlik) butonu gösterilecek!");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
