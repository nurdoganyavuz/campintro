using System;

namespace Campintro
{
    class Program
    {
        static void Main(string[] args)
        { 
            //type safety -->tip güvenliği
            //değişken tanımlarken öncesinde tipini(veri türünü) tanımlamak zorundayız.
            //değişken --> deger tutucu, alias

            string KategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double dolarBugun = 7.45;
            double dolarDun = 7.75;
            bool giris = true;

            
            //şart blokları
            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Oku");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else
            {
                Console.WriteLine("Sabit Oku");
            }


            if (giris == true)
            {
                Console.WriteLine("Giriş Yaptınız!");
            }
            else
            {
                Console.WriteLine("Giriş yapmak için kayıt olunuz.");
            }
            

            Console.WriteLine(KategoriEtiketi);

            
            

        }
    }
}
