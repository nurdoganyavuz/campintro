using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Business Class --> operasyon tutucu class
    class CustomerManager
    {
        public void Add(Customer customer) //ekleme operasyonu
        {
            //LegalCustomer ve IndividualCustomer sınıfları Customer'ı miras aldığı için
            //Add operasyonu içinde Customer parametresi verdik, çünkü LegalCustomer ve IndividualCustomer da zaten bir customer'dır.
            //yani gerçek ve tüzel müşteri sınıfından olusturulan objeler bu operasyonu kullanabilir. Bu bir polymorphism örneğidir.

            Console.WriteLine("Yeni müşteri eklendi!");

            //Console.WriteLine(((IndividualCustomer)customer).CustomerName + " müşterilere eklendi."); //BOXING
            //customer'a IndividualCustomer boxingi uyguladık. Bu sayede eğer girilen customer IndividualCustomer ise bu sınıftaki CustomerName özelliğini yazdırabilecek.
            //mesela bu blok yalnızca customer1 için çalışır.

        }
    }
}

//sınıflar özellik veya operasyon tutan yapılardır.
//operasyon tutucu sınıfları ayrı özellik tutucu sınıfları ayrı olustururuz.
//operasyon tuttugumuz bir classta özellik tutmayız
//özellik tuttugumuz bir classta ise operasyon tutmayız.