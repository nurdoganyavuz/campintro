using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //****ÖNEMLİ KONU****

            //int degisken olusturalım

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            //int array olusturalım

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);



        }
    }
}

//  DEĞER VE REFERANS TİPLER

//Değer tipler --> int, double, float, decimal, bool (sayısal deger tutan tipler)
//Referans tipler --> array, class, interface

//Değer tiplerde yapılan değişiklikler değere yansır, değer üzerinden olur.
//Referans tiplerde yapılan değişiklikler adres üzerinden yapılır ve adrese yansır...