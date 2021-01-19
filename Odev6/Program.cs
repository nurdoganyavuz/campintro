using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product0 = new Products();

            product0.Category = "Mutfak Eşyası";
            product0.ProductName = "Fincan Takımı";
            product0.Color = "Kırmızı";
            product0.Company = "Karaca";
            product0.Price = 90;
            product0.DiscountRate = 0.50;
            
            Products product1 = new Products();

            product0.Category = "Teknolojik Aletler";
            product0.ProductName = "Mouse";
            product0.Color = "Mavi";
            product0.Company = "Logitech";
            product0.Price = 65;
            product0.DiscountRate = 0.45;

            Products product2 = new Products();

            product0.Category = "Aksesuar";
            product0.ProductName = "Küpe";
            product0.Color = "Sarı";
            product0.Company = "Koton";
            product0.Price = 35;
            product0.DiscountRate = 0.60;

            Products product3 = new Products();

            product0.Category = "Ayakkabı";
            product0.ProductName = "Postal";
            product0.Color = "Siyah";
            product0.Company = "FLO";
            product0.Price = 120;
            product0.DiscountRate = 0.20;

            Products product4 = new Products();

            product0.Category = "Makyaj Ürünleri";
            product0.ProductName = "Likit Mat Ruj";
            product0.Color = "Bordo";
            product0.Company = "M.A.C.";
            product0.Price = 160;
            product0.DiscountRate = 0.25;

            Products product5 = new Products();

            product0.Category = "Çanta";
            product0.ProductName = "Sırt Çantası";
            product0.Color = "Lacivert";
            product0.Company = "H&M";
            product0.Price = 80;
            product0.DiscountRate = 0.10;


            Products[] products = new Products[] {product0, product1, product2, product3, product4, product5 };

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(products[i]);
            }
            

        }
    }






    class Products
    {
        public string Category { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public double DiscountRate { get; set; }
        
    }








}
