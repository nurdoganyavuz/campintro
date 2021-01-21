using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //nasıl ki int numara = 15; dediğimizde int sınıfında numara diye bir değişken olusturuyorsak, classlar'da da aynı işlemi gerçekleştirebiliriz.

            Product products1 = new Product(); //Product sınıfında products1 diye bir obje olusturduk. 
                                               //Bu obje; Product sınıfında olusturdugumuz bütün özelliklere sahip artık (adi, fiyatı, acıklaması vs.)
            products1.Id = 101;
            products1.Adi = "Elma";
            products1.Fiyati = 15;
            products1.Aciklama = "Amasya elması";

            Product products2 = new Product(); //Nasıl ki int, string gibi sınıflarda istedigimiz kadar obje tanımlayabiliyorsak, sınıflarda da tanımlayabiliriz.
                                               //Product sınıfında products2 diye bir obje olusturduk.
            products2.Id = 102;
            products2.Adi = "Karpuz";
            products2.Fiyati = 80;
            products2.Aciklama = "Diyarbakır karpuzu";

            //string[] abc = new string[] {"a", "b", "c"}; --> şeklinde abc isimli string array olusturabildiğimiz gibi, Product array'i de olusturabiliriz.
            //yani olusturdugumuz sınıftan da array olusturabiliriz.
            //Product sınıfından products isimli bir array olustururuz 
            //ve bu array'in içine sınıfta olusturdugumuz products1 ve products2 objelerini atarız;

            Product[] products = new Product[] {products1, products2 };

            //type safe-- c# tip güvenli bir dil 
            //bu yüzden değişken isimlendirmelerinden önce tipini belirtiriz. int sayi, string adi vs gibi.
            //foreach içerisinde Product class'ı ile olusturdugumuz verilerle işlem yapacagımız için, tip olarak Product'ı belirtiriz.

            //foreach ile yukarıda olusturdugumuz products dizisindeki her bir elemanı döndürmek istiyoruz (python'da ki for mantıgı)
            //products dizisinde döndüğümüz HER BİR elemanı, product isimli değişkene atıyoruz. 
            //Artık dizi içerisinde dönülen her elemanı product ismiyle çağırabiliyoruz. Çünkü bu değişkenin(product) içine attık.
            //Aynı zamanda Product sınıfının özelliklerini de product değişkeni ile çağırabiliyoruz.
            //product.name --> foreach'in döndürdüğü her eleman için çalışır. 
            //Mesela dizi içerisindeki ilk eleman products1; bu elemanı döndürürken adını, fiyatını açıklamasını yazdırır.
            //ardından products2 döndürülürken, aynı özellikleri onun için de yazdırır.

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("-------METOTLAR--------");

            
            //Sepetmanager'ı buradan cagırıyoruz
            //Sepetmanager sınıfında sepetmanager objesi olusturduk.
            //Sepetmanager class'ı içinde Ekle methodu olusturmustuk. Olusturulan obje bu methodu kullanabilir, çağırdıgımız her yerde.
            //birden fazla sayfada olması gerekiyorsa bile bu şekilde çağırdıgımız her yere gelir.

            SepetManager sepetManager = new SepetManager(); //instance -- class örneği olusturmak
            sepetManager.Ekle(products1); //1. sayfa
            sepetManager.Ekle(products2); //2.sayfa

            

        }
    }
}

//methodlar tekrar kullanılabilirliği sağlar. (sepete ekleme örneğini düşün)