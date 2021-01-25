using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService
    {
        void Log(); //imza
    }
}


//LOGLAMA
//Mesela bir müşteri kredi çekti; kredi çektiğini veritabanına, dosyaya, e-maille, sms'le loglayabiliriz. Çeşitli loglama ***alternatifleri*** var.
//email ya da sms gönderdiğimizde veya veritabanımıza, dosyaya vs logladıgımızda hepsinde yaptıgımız işlem LOGLAMAKTIR.
//fakat dosyaya loglama işleminde farklı kodlar çalışır, veritabanına loglarken baska kodlar, sms'te farklı kodlar...
//hepsinde imza aynıdır --> Log(); operasyonudur. Fakat içerik farklıdır.
//loglama işlemi yapmak için, Log() imzasını bütün class'larda aynı şekilde kullanıyoruz
//fakat class'ların bu operasyon içerisinde tuttugu işlemler farklıdır. 
//Yani bu operasyon için hepsi aynı imzayı kullansa da hepsi kendine özgü olan farklı bi içerik kullanır. 
//Bu yüzden tıpkı kredi hesaplama kısmında oldugu gibi,  alternatif  sistemler söz konusu old. için interface olustururuz.