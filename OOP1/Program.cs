using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //product sınıfında obje olusturduk (1.yol)

            Product product1 = new Product(); 
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //product sınıfında obje olusturduk (2.yol)
            //iki şekilde de olusturabiliriz, istege baglı

            Product product2 = new Product {Id = 2, CategoryId=5, UnitsInStock=5, ProductName= "Kalem", UnitPrice=35};

            //ProductManager türünde productManager olusturduk.
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager(); //instance
            productManager.Add(product1);

        }
    }
}
