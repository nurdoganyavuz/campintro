using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //methodun çalışması için ihtiyacı olan seyleri buraya yazıyoruz.
        //toplama için iki sayıya ihtiyaç var dolayısıyla buraya 2 sayı değişkeni koyduk.
        //sepete ekleme methodu için, eklenecek bir ürüne ihtiyacımız vardı, method içerisine urun degiskenini attık.
        //yani o method çalışırken neyi kullanacaksa onu vermeliyiz.
        public void Topla(int sayi1, int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuc : " + toplam);
        }
    }
}


//DortIslem sınıfına Topla methodu eklediğimiz gibi; çıkarma, çarpma, bölme gibi farklı methodlar da ekleriz istersek.
//Yani bir class'ın içerisinde birden fazla method olusturabiliriz.