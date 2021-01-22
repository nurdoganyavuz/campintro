using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //KAMP 4. GÜN 2. DERS
            //stack            //heap
            //string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);

            //bu sekilde diziye yeni eleman ekleyemeyiz. hata alırız.
            //çünkü istediğimiz index(4), olusturdugumuz string array'in range'inin dısında kalır.
            //arraylar olusturdugumuz sınırlar içerisinde kalır, dışına çıkmaz.
            //mesela isimler array'i 4 elemanlı 0,1,2,3 indexlerinden oluşan bir array ve hep böyle kalır. Sınırları dısında calısmaz.

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);

            //bu şekilde yaptıgımızda 5 elemanlı string array olustururuz.
            //Bunun 4. indexine ilker'i atabiliriz.
            //ama "new dediğimiz anda" bellekte(heap kısmında) isimler dizisi için yeni bir adres oluşur.(***)
            //yani artık isimler dizisi {"engin", "murat", "kerem", "halil"} 'i tutan adreste değil.
            //5 elemanlı boş bir diziyi tutan adreste artık.
            //yani 0,1,2,3 indexleri bomboş, 4.indexe ilker atandı.
            //bu işlemle yeni eleman eklemiş olmuyoruz. Array'in bellekteki adresini değiştirmiş olduk yalnızca.

            //Özetle; bir dizi olusturdugumuzda o diziyi genişletemiyoruz, yeni eleman ekleyemiyoruz.
            //arraylerde sabitlik söz konusudur. En fazla yukarıdaki gibi new'leyip genişletiriz. Ancak o zaman baştaki diziyi kaybederiz, yeni boş bir dizi oluşur.
            //bunun için farklı bir yapı kullanırız. 
            //Bu yapılar koleksiyonlardır.

            //listeler koleksiyon yapısındadır.
            //string list olusturduk;
            // <..> bunun içerisine string, int, bool, Product, sepet vs gibi sınıfları koyabiliriz.
            // <string> dediğimizde; list sınıfında stringler ile çalışacagımızı belirtiyoruz.
            //o yüzden list sınıfına ait fonksiyonları kullanırken, ***başta belirttiğimiz tip ne ise*** ona uyum sağlamak zorundayız.
            //yani isimler2.Add(5) dersek hata alırız, çünkü fonk. içerisine string değer girmeliyiz.

            List<string> isimler2 = new List<string> {"nur", "büşra", "kübra", "su" };
            

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            //listeye yeni eleman ekleme (listenin sonuna ekler.)
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
