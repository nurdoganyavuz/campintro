using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNo = "12345";
            customer1.CustomerName = "Engin";
            customer1.CustomerSurname = "Demiroğ";
            customer1.Id = 1;
            customer1.CustomerId = "12345678910";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new LegalCustomer();



        }
    }
}
