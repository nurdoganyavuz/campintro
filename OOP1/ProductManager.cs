using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //operasyonları içeren class
    {                   
                        //encapsulation
        public void Add(Product product) //ekleme operasyonu
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        public void Update(Product product) //güncelleme operasyonu
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

       


    }
}

// (metot olustururken) --> void vs int kullanımı

//void --> git, yap, bitir.
//bir metodu void ile tanımlarsak, metodu çalıştırır ve sonucunu yazdırır. Fakat bu sonucu döndürmez.
//örnegim; public void Topla(int sayi1, int sayi2){ Cw(sayi1+sayi2); }
//productManager.Topla(3,6);  --> 9 yazdırır.
//ama bu 9 bize programın baska bir yerinde lazımsa bir değişkene atayıp kullanamayız.
//çünkü sonucu döndürmüyor, yalnızca gösteriyor.

//int --> operasyon sonucu elde edilen degerin dönüşüne ihtiyacımız varsa yani bu degeri programın akısında farklı yerlerde kullanmamız gerekiyorsa int kullanırız.
//public int Topla(int sayi1, int sayi2){ return sayi1+sayi2; }
//productManager.Topla(3,6) -->9 değerini "döndürür."
//int sonuc = productManager.Topla(3,6) --> bu sekilde sonucu bir değişkene atayarak programda farklı yerlerde kullanabiliriz.
//cw(sonuc*2) --> bu sekilde döndürülen sonuc üzerinden işlemler de yapabiliriz.
//yani metot sonucu elde edilen deger döndürüldüğü için, bu deger üzerinde işlemler yapabilmemize olanak sağlar.
//Örneğin; bir banka sisteminde metot ile kullanıcının borcu, kredi ödemesi vs. hesaplanıyor ise 
//ve hesaplanan bu deger sistemin baska kısımlarında kullanılacaksa, metot içersinde hesaplanan bu değerin döndürülmesi gerekir ki ihtiyaç halinde kullanabilelim.
//program akısında kullanmamız gereken bir operasyon tanımlayacaksak bunu return etmemiz gerekir.
//void; operasyon sonucu elde edilen degeri gösterir, döndürmez. Bu nedenle baska bir yerde lazım oldugunda kullanamayız.

//mesela gelen ve giden paraya göre güncel bakiyeyi hesaplayıp bunu yazdıran bir metot düşünürsek
//bu güncel bakiye degerini baska bir yerde kullanmamız gerekiyorsa, metot içerisinde return etmemiz gerekir.