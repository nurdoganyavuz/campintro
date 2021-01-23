using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalFinanceCredit personalFinanceCredit = new PersonalFinanceCredit();
            personalFinanceCredit.Calculate();

            TransportCredit transportCredit = new TransportCredit();
            transportCredit.Calculate();

            MortgageCredit mortgageCredit = new MortgageCredit();
            mortgageCredit.Calculate();

            Console.WriteLine("-----Interface kullanarak istediğimiz kredi türünden obje oluşturabiliriz-----");
            //interface; onu implement eden(miras alan) class'lardan oluşturulan objelerin referanslarını tutabilir.

            ICreditManager personalFinanceCredit1 = new PersonalFinanceCredit(); //IcreditManager interface'i; ihtiyaç kredisi sınıfında olusturulan objenin bellekteki referans adresini tutuyor.
            personalFinanceCredit.Calculate();

            ICreditManager transportCredit1 = new TransportCredit();
            transportCredit.Calculate();

            ICreditManager mortgageCredit1 = new MortgageCredit();
            mortgageCredit.Calculate();

            Console.WriteLine("--------Başvuru Yap Operasyonu----------");

            ILoggerService databaseLoggerService = new DatabaseLoggerService(); //loglama objesi olusturduk, hangi loglamayı istiyorsak onun için olustururuz.
            ILoggerService fileLoggerService = new FileLoggerService();

            AppealManager appealManager = new AppealManager();
            appealManager.Appeal(mortgageCredit1, databaseLoggerService); //konut kredisi için basvuru yapıldı ve veritabanına loglandı.
            appealManager.Appeal(transportCredit, fileLoggerService );   //taşıt kredisi için basvuru yapıldı ve dosyaya loglandı.

            Console.WriteLine("------Ön Bilgilendirme Operasyonu-------");

            List<ICreditManager> credits = new List<ICreditManager>() { mortgageCredit, transportCredit };
            appealManager.Information(credits);
        }
    }
}
