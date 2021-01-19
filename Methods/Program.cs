using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product products1 = new Product();

            products1.Adi = "Elma";
            products1.Fiyati = 15;
            products1.Aciklama = "Amasya elması";

            Product products2 = new Product();
          
            products2.Adi = "Karpuz";
            products2.Fiyati = 80;
            products2.Aciklama = "Diyarbakır karpuzu";


            Product[] products = new Product[] {products1, products2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-------METOTLAR--------");

            //instance -- class örneği

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(products1); //1. sayfa
            sepetManager.Ekle(products2); //2.sayfa

            


        }
    }
}



//methodlar tekrar kullanılabilirliği sağlar. (sepete ekleme örneğini düşün)