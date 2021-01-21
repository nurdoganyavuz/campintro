using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    //SepetManager sınıfına birden fazla method ekleyebiliriz. 
    //Mesela Ekle diye bir methodumuz var Ekle2 diye baska method da olustururuz istersek.

    class SepetManager //ortak operasyon tutucu method
    {                  //sepete ekle methodu örneğini düşün
                       //birden fazla sayfada mevcut

        //naming convention--isimlendirme kuralı, method isimleri büyük harflerle baslar.
        //  () bu parantezlerin oldugu yerlerde method çalıştıgını anla

        public void Ekle(Product product) //sepete ürün ekleme methodu (pythondaki def ile aynı)
        {
            Console.WriteLine("Tebrikler, sepete eklendi : " + product.Id); //Ekle methodunun içerisinde Product tipindeki product objesi çalıştırılacak.
                                                                            // o yüzden product diye çağırdıgımızda, Product sınıfının tüm özelliklerine ulaşabilir.
                                                                            //mesela burada Ekle methodu çalıştırıldıgında, eklediğimiz ürünün Id'sini yazdırmasını istedik.
                                                                            //methodun yapmasını istediğimiz işlem, buradaki bloklar arasına yazılır.
        }

        
    }
}

//Encapsulation (kapsülleme)
//dinamik yazılım geliştirme de olmazsa olmazdır.
//özellikleri ayrı ayrı belirtmek yerine class ile tanımlarız.
//ve olusturdugumuz methodlarda KAPSÜL olarak bu sınıfı alırız. Bu örnekte kapsülümüz --> Product class'ı
//method içerisindeki değişkenler, bu kapsülün içerisindeki özelliklere sahip olmus olur.


//mesela methodu şu şekilde olustursaydık;

//public void Ekle2(string urunAdi, int fiyat){
// console.writeline("sepete eklendi:" + urunAdi); }


//bu sekilde yaparsak(yapmamalıyız), herhangi bir sayfada methodu cagırırken sepetmanager.Ekle2("armut", 12) şeklinde çağıracaktık.
//Ekle2'nin içerisine mesela int stokadedi diye baska bir değişken eklememiz istenirse
//bu methodu çağırdıgımız bütün sayfalara gidip, eklediğimiz değişkeni yazacaktık sepetmanager.Ekle2("armut", 12, 5) gibi.. 
//bu dinamik programlamaya aykırıdır.
//ama encapsulation ile sadece class'ın içerisine özellik ekleriz,
//metod içerisinde class ile değişken tanımlayınca, o class'a ait bütün özellikler otomatik olarak değişkene atanır.
//kamp 3. gün 1:55 dk.sında anlatıyor.
