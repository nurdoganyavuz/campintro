using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2  //INHERITANCE
{   //BASE CLASS
    class Customer 
    { 
        
        public int Id { get; set; }

        public string CustomerNo { get; set; }

    }
}

//gerçek ve tüzel müşterilerin ortak özelliklerini tutugumuz class        
//bu özellikleri hem LegalCustomer da hem IndividualCustomer da tutmak yerine Customer'da tutarız
//ardından bu class'ı inherit ederek, her iki sınıfında kullanmasını olanak sağlarız. Yani Customer sınıfı ebeveyndir.
//IndividualCustomer : Customer, LegalCustomer : Customer şeklinde inherit ettik.
//yani gerçek ve tüzel müşteriler, bu(Customer) sınıftaki özellikleri miras aldılar, kullanabilirler.