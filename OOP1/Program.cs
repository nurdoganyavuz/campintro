using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product sınıfında product1 isimli bir obje olusturduk (1.yol)

            Product product1 = new Product(); 
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //Product sınıfında product2 isimli bir obje olusturduk (2.yol)
            //iki şekilde de obje olusturabiliriz, istege baglı.

            Product product2 = new Product {Id = 2, CategoryId=5, UnitsInStock=5, ProductName= "Kalem", UnitPrice=35};

            //ProductManager türünde productManager olusturduk.
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager(); //instance creation (örnek olusturma); ProductManager sınıfında productManager isimli instance olusturduk. 
            productManager.Add(product1);                         //productManager instance'ı, ProductManager sınıfındaki metodları(add, update vs.) kullanabilmemize olanak sağlar.
                                                                  //Yani ProductManager tipinde bir değişken tanımladık diyebiliriz. tıpkı string isim = "engin"; gibi..
        }
    }
}

//classlar referans tipler oldugu için, olusturdugumuz objenin heap'te bir adreste tutulması lazım.
//Olusturulan objenin heap'te bir adreste tutulması için;  new'lememiz gerekir. (***)

 //***stack'te tutulan kısım***   ***heap'te tutulan kısım***
 //ProductManager productManager = new ProductManager();