using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi 1 = 30 olacaktır.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999 olacaktır. 

            //int,decimal,float, double,bool = değer tiplerdir.

            //array,class,interface = referans tiplerdir.

            //Bellekte stack ve heap adlı kısımlar. Stack'te değer tipler sayi1 = sayi2 dediğimizde
            //sayi1'in değeri sayi2'nin değerine eşittir denir ve sayi2 ile olan tüm bağ bu noktadan
            //sonra kopar.

            //Referans tipler int[] sayilar1 dediğimizde stackte sayilar1 adlı bir değişken oluşturur.
            //New dediğimiz anda heap'te [10,20,30] adlı bir dizi oluşturur. Bellekte adreste tutulur.
            //Yani new demek, bellekte adres oluştur demektir.
            //sayilar1 = sayilar2 dediğimizde de sayilar1'in referans numarası = sayılar2'nin referans numarasıdır.
            //Yani sayilar1'in dizi adresi bellekte 101 ise ve sayilar2 102 ise; sayilar2'nin adresi olan 102'yi
            //sayilar1'in yeni adresi yapar. Adres kopyalaması yapar. Bu olay C'de pointer denebilir.
        }
    }
}
