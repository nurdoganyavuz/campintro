using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //T -->type
    // list<string>, list<int> gibi tiplerle değil de
    //özel bir tip ile çalışacaksak, generic class kullanırız.
    //yani bir generics olusturuyorsak, o sınıfta özel bir tip kullanacagız demektir.
    //burada T kullanıyoruz. Genelde T kullanılır ama buna istediğimiz ismi verebiliriz a,b,c gibi.
    //<string> dediğimizde o sınıfta stringler ile çalışacagımızı belirtiyoruz. <int> dediğimizde int tipindeki değerlerle vs.
    //olusturdugumuz sınıfın hangi tiple çalışacagını belirttiğimizde, o sınıfa ait fonksiyonları kullanırken tipe bağlı kalmak zorundayız.
    //mesela string ile çalışacagımızı belirlemiş isek; Add() bu fonk. içerisine string ifade girmek zorundayız.
    //burada <T> yaptık, MyList class'ı içerisindeki fonk.larda fonk. içerisine hangi tipte veri girilirse ona uyum sağlasın istiyoruz.
    //mesela class içerisinde add operasyonu olusturursak; add(5) girildiğinde integer tipine uyum sağlar, add("nur") girildiğinde string'e uyum sağlar.
    //tıpkı var keywordü gibi düşün.
    //yani kullanıcı mylist kullanacagında; mylist sınıfını hangi tiple newlerse o tipe göre çalışır sınıf içerisindeki metotlar.
    //en basta kullanacagını belirttiği tip ne ise ona göre çalışacak.
    //mylist<string> isimler = mylist<string>(); şeklinde olusturursa; mylist sınıfındaki metotları string tipler ile kullanacagına söz vermiş olur bir nevi.


    class MyList<T> //Mylist class'ında T ile çalışacagız.
    {
        T[] items;   //MyList generic'imizin arkaplanında bir array tutuyoruz ve o array'i yönetiyoruz.
                    //bu array'i class içerisinde tanımlıyoruz ki; class içerisinde olusturdugumuz BÜTÜN metotlar bu array'e ulaşabilsin.
                    //string[] isim; gibi T tipinde bir dizi olusturduk. Ama bu diziyi new'lemiz gerekiyor ki bellekte bu dizi için bir adres oluşsun.
                    //yani new Mylist dediğimiz anda, bellekte bu koleksiyon için *boş* bir array adresi oluşturulmalı.

        public MyList(){   //ctor + tab*2 --> constructor --> bir class new'lendiğinde çalışan bloğa denir. 
                          //Yani MyList'i herhangi bir yerde new'lediğimiz anda bu blok OTOMATİK çalışır. (***)
        
            items = new T[0];  //MyList'i newlediğimizde; arkaplanda tutulan T tipindeki items dizisi 0 elemanlı olarak newlenir.(***)
                               
        }
        public void Add(T item){ //add(string item) demiş olsaydık, sadece string değerler ile çalışacaktı bu metot. Yani hep string tip ile çalışmak zorunda olacaktı. 
                                //Ama T, koleksiyon olusturulurken hangi tipe göre olusturulduysa ona uyum sağlar. string ise string, int ise int.
                                //burada dizimize eleman eklemek için Add metodunu olusturduk.

            T[] tempArray = items;
            items = new T[items.Length+1];  //mevcut dizinin eleman sayısını 1 artırmak istiyoruz. items.length --> dizinin boyutu(eleman sayısı)
                                            //bunun için mevcut diziyi newleriz ve boyutunu 1 arttırırız.
                                            //örnegin; 5 elemanlı bir diziye eleman eklemek istiyorsak o dizinin boyutunu 5+1 yaparız ki yeni elemana yer açılsın.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
//items = new T[items.Length+1]; yaptıgımız zaman, items dizimiz new'lenerek length+1 elemanlı bir diziyi tutan bellek adresine atanıyor.
//yani mevcut dizimiz artık length+1 boyutlu boş bir dizi olarak baska bir adreste tutuluyor. Çünkü new dediğimiz anda bellekte adres numarası değişir.
//newlendiği anda adres numarası değişir ve içindekiler eski adreste kalır, yeni adreste artık length+1 boyutlu boş dizi var.
//orijinal dizi elemanlarını geçici olarak bir dizide tutmak ve ekleme işleminden sonra oradan geri almak istiyoruz.
//bu yüzden newlemeden önce items dizisindeki elemanları geçiçi array'e emanet ederiz. --> T[] tempArray = items;
//temparray, mevcut dizinin adresini tutar. newlediğimizde dizinin adresi değişecek ve elemanlar eski adreste kalacak çünkü.
//newlemek bellekte adres numarasının değişmesi demek, adres değiştiğinde eski adresteki değerler uçar. Değerler uçmasın diye eski adresi geçiçi array'e tutturuyoruz.
// T[] tempArray = items; --> yani burada yaptıgımız şey, items dizisini newlemeden önce, bu dizinin adresini tempArray'e vermektir. 
//TempArray artık items dizisin adresini tutuyor. items ise newlendiği için yeni bir adreste tutuluyor.

//items ["a","b","c"] ---> bunun adresini tempArray'e verdi. Temparray artık bu diziyi tutan adreste.
//items.Length+1 olarak newlenince; 4 elemanlı boş bir diziyi tutmaya basladı bellekte.
//sonra geçici array'deki verilerini geri alacak
//bunun için for döngüsü ile, tempArray dizisinin elemanlarını index-index kendi üzerine yazdırır.
//items[0] = tempArray[0] --> items = ["a"," " ," " ," "]
//döngü sonlanınca items = ["a","b" ,"c" ," " ] olur. Son index boş. Buraya eklemek istediğimiz item'ı ekleyecegiz.
//items.Length = 4, items.Length-1 = 3; items dizisinin son indexi 3'tür. Boş olan bu sonuncu indexe item'ı eklemek istiyoruz.
//son indexe item'ı ekleyebilmek için --> items[items.Length - 1] = item; yaparız.
