using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3 //Dependency Injection
{         
    class AppealManager //BaşvuruManager
    {               //bu methodun hangi kredi ile çalışacagını ve hangi loggerservice'i kullanacagını methoda enjekte ediyoruz -->dependency injections
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices) //Başvuru yapma operasyonu
        {           
            
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void Inform(List<ICreditManager> credits) //ön bilgilendirme operasyonu
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
                
            }
        }
        
    }
}
//MAKEAPPLICATION OPERASYONU
//buradaki operasyonların parametrelerini; konutkredisi, taşıt kredisi vs herhangi bir kredi vermiş olsaydık
//başvuran kim olursa olsun, bütün hesaplamaları o krediye göre yapacaktı.
//misal; operasyon -içerisinde- mortgageCredit.Calculate(); koymuş olsaydık, 
//MakeApplication operasyonunu transportCredit objesi için bile kullansak, MortgageCredit hesaplaması yapacaktı. Yani ona bağlı kalacaktı.
//yani tüm başvurular mortgageCredit üzerinden hesaplanırdı. bütün basvurular ona bağımlı hale gelmiş olurdu.
//BUNU YAPAMAYIZ.

//ICreditManager interface'inin, onu implemente eden bütün class'ların referansını tutabildiğini biliyoruz.
//bu yüzden bu operasyonlara parametre olarak ICreditManager veririz ki, bu interface'i kullanan bütün class'lar tanımlanan operasyonu "kendine uygun" kullanabilsin.
//yani mortgage objesi MakeApplication operasyonunu kullanıyorsa, bellekteki mortgage calculate operasyonunu çalışır, transport kullanıyor ise transport calculate çalışır vs.

//bankaya bir müşteri geldi diyelim; almak istediği krediyi memura söylüyor, misal taşıt kredisi.
//banka memuru ekrandan TransportCredit seçtiği takdirde, hesapla fonksiyonu seçilen krediye göre çalışıyor.

//bu operasyon içerisine parametre olarak bir de ILoggerService listesi ekledik.
//yine aynı mantıkla operasyon içerisine Iloggerservice interface'ini yazdık ki; bu interface'i kullanan bütün Logger classların objeleri parametre olarak girilebilsin.
//artık bu parametrede hangi loglama servisi ya da servisleri seçilmişse ona göre log operasyonu gerçekleştirecek.
//yani DatabaseLogger ile loglanmak istenilirse, operasyon içerisindaki listeye parametre olarak databaselogger girilecek.
//DatabaseLogger ve SmsLogger ile loglanmak istenilirse, operasyon içerisindaki list parametresine smslogger ve databaselogger girilecek.
//Log() işlemi ise seçilen sınıfa göre çalıştırılacak. 
//Yani parametre olarak databaselogger seçildiği takdirde, databaselogger sınıfına ait Log() operasyonu çalıştırılacak.
//listeye birden fazla loglama servisi girilebileceği için, foreach döngüsü olsuturarak liste içindeki bütün elemanları döndürürüz.
//liste içindeki objeler sırasıyla hangi sınıfa ait ise o sınıfın Log operasyonu çalıştırılır.

//INFORM OPERASYONU
//Diyelim ki bankaya bir müşteri geldi ve hangi krediyi çekerse ne kadar ödeme yapacagını merak ediyor, ona göre seçim yapacak
//bunun için; taşıt seçerse şu kadar ödeme yapar, konut seçerse bu kadar gibi hesapları listeleyen bir bilgilendirme operasyonuna ihtiyacımız var.
//burada ne kadar kredi listelenecegi belirsiz. Müşteri hem taşıt hem konut kredisi hesabını öğrenmek istiyorsa onları listeler. 
//taşıt, konut, ihtiyaç kredilerinin tamamı için de ön bilgilendirme isteyebilir.
//Aynı tipten istediğimiz kadar veriyi bir arada tutabilmek için list yapısını kullanıyorduk
//list içerisinde hangi tip verilerin tutulacagını ise; <int>, <string>, <product> gibi sınıfları <> içerisine ekliyorduk.

//Inform operasyonunun içerisinde parametre olarak ICreditManager list olusturacagız. --> tıpkı list<string> isimler, list<int> sayilar şeklinde olusturabildiğimiz gibi
//burada IcreditManager list olusturmamızın nedeni, ICreditManager interface'ini kullanan bütün class'ların objelerinin bu operasyona ulaşabilmesi için (***)
//list<MortgageCredit> demiş olsaydık, sadece MortgageCredit sınıfı objelerini kabul eden bir liste olurdu.
//oysa biz bu listeye istedigimiz krediyi eklemek istiyoruz.
//ön bilgilendirme yapılacak kredileri listeye ekledikten sonra, seçilen kredilerin hesabının yapılması lazım.
//dolayısıyla burada bir foreach döngüsü olusturarak, liste içindeki kredileri hesaplamaası için Calculate() fonk.unu çağırırız.
//listeye hangi kredi eklendiyse, Calculate fonk.u o kredi sınıfına ait olan Calculate'i çalıştırır. (***)
//yani listede mortgage kredisi varsa, MortgageCredit sınıfının Calculate'i çalıştırılır.

