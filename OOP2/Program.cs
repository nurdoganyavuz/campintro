using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IndividualCustomer sınıfından customer1 objesi olusturduk
            //bu obje hem IndividualCustomer sınıfındaki özellikleri hem de miras aldıgı ebeveyn sınıfın(Customer) özelliklerini kullanabilir.
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNo = "12345";
            customer1.CustomerName = "Engin";
            customer1.CustomerSurname = "Demiroğ";
            customer1.Id = 1;
            customer1.CustomerId = "12345678910";

            //LegalCustomer sınıfından customer2 objesi olusturduk
            //bu obje hem LegalCustomer sınıfındaki özellikleri hem de miras aldıgı ebeveyn sınıfın(Customer) özelliklerini kullanabilir.
            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            //Base(ebeveyn, mirasçı) sınıftan oluşturulan objelere; 
            //bu sınıfı miras alan sınıfların ve bu sınıflarda olusturulan objelerin
            //bellekteki referans adreslerini atayabiliriz. Tıpkı asagıda oldugu gibi.
            //Customer sınıfından customer3 objesi olusturduk ve newleyerek IndividualCustomer sınıfının bellek adresine atadık.
            //Customer sınıfından bir obje olusturup, bu objenin adresini; Customer sınıfının mirasçısı olan sınıflardan oluşturulmuş objelere de atayabilirdik
            //Customer customer4 = customer2; //mesela customer4 objesini LegalCustomer'da olusturulmus customer2 objesinin bellek adresine atadık.
            //(***)Yani Customer class'ı; hem LegalCustomer'ın hem de IndividualCustomer'ın bellekteki referansını tutabilir.(***)
            
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new LegalCustomer();

            //(!!!)BASE CLASS ONU INHERIT EDEN CLASS'LARIN REFEREANSINI TUTABİLİR(!!!)

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);



        }
    }
}
