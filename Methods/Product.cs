using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    { 
        //Property - özellik
        //olusturdugumuz sınıfın içerdiği özellikler
        //bu sınıfa ait bir obje olusturdugumuzda, o obje burada tanımladıgımız özellikleri içerecek.
        //yani class'lar olusturacagımız objelerin özelliklerini tanımlayan yapılardır.
        //bir ürün olusturdugumuzda; o ürünün adını, fiyatını, acıklamasını vs. vererek tanımlarız.
        //class'lar bu tanımlamaları yapmamıza olanak sağlar.
        //int, string, double vs gibi tipler de aslında classlardır. int dediğimiz zaman girilen ifadenin bir tam sayı olacagı daha önceden belirlenmiştir mesela.

        public int Id { get; set; }

        public string Adi { get; set; }

        public double Fiyati  { get; set; }

        public string Aciklama { get; set; }


    }
}
