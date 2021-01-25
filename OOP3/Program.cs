using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Class'lardan instance/obje oluşturma----------------");
            PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
            personalFinanceCredit.Calculate();

            TransportCredit transportCredit = new TransportCredit();
            transportCredit.Calculate();

            MortgageCredit mortgageCredit = new MortgageCredit();
            mortgageCredit.Calculate();

            Console.WriteLine("-----Interface'i kullanarak; o interface'i implemente eden class'lardan obje oluşturabiliriz-----");
            //interface; onu implement eden(kullanan) class'lardan oluşturulan objelerin referanslarını tutabilir. (***)
            //yani IcreditManager interface'i; onu uygulayan class'ların(PersonalFinanceCredit,TransportCredit,MortgageCredit) bellekteki referansını tutabiliyor.

            ICreditManager personalFinanceCredit1 = new PersonalFinanceCredit(); //IcreditManager interface'i; ihtiyaç kredisi sınıfında olusturulan objenin bellekteki referans adresini tutuyor.
            personalFinanceCredit.Calculate();

            ICreditManager transportCredit1 = new TransportCredit();
            transportCredit.Calculate();

            ICreditManager mortgageCredit1 = new MortgageCredit();
            mortgageCredit.Calculate();


            Console.WriteLine("----------------Başvuru Yapma ve Loglama Operasyonu-------------------");

            ILoggerService databaseLoggerService = new DatabaseLoggerService(); //loglama objesi(instance) olusturduk, hangi loglamayı istiyorsak onun için olustururuz.
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> logers = new List<ILoggerService> {databaseLoggerService, fileLoggerService };
            

            //appealManager objesi MakeApplication operasyonu içerisinde hangi class'ı kullanırsa, operasyon o class'a göre çalışır.
            //mortgageCredit1 MortgageCredit sınıfından olusturuldugu için; o sınıda ait Calculate operasyonu çalıştırılacak.

            AppealManager appealManager = new AppealManager();
            appealManager.MakeApplication(mortgageCredit1, logers);      //konut kredisi için basvuru yapıldı ve veritabanı + dosyaya loglandı.
            appealManager.MakeApplication(transportCredit, logers );   //taşıt kredisi için basvuru yapıldı ve veritabanı + dosyaya ile loglandı.
                                                                       

            appealManager.MakeApplication(new ArtisanCredit(), new List<ILoggerService> {databaseLoggerService, new SmsLoggerService() }); 
             //listeyi ve AsistanCredit'i direkt bu şekilde de olusturabiliriz. yukarıdaki gibi instance da olusturabiliriz.
            //bu krediyi sisteme sonradan ekledik
           //sonradan eklediğimizde kodu bozmadı (SOLID İlkeleri)
          //aynı zamanda hiç uğraşmadan sisteme kolayca entegre edebildik.

            Console.WriteLine("-----------------------Ön Bilgilendirme Operasyonu------------------");

            List<ICreditManager> credits = new List<ICreditManager>() { mortgageCredit, transportCredit }; //ön bilgilendirme almak istenilen krediler mortgage ve transport old. için listeye onları ekledik.
            appealManager.Inform(credits);                                                                //daha fazla ya da daha az fark etmez istedigimiz kadar krediyi ekleyebiliriz listeye.

            
        }
    }
}
