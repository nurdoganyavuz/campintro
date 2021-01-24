using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{         //Gerçek Müşteri
    class IndividualCustomer : Customer
    { 
        public string CustomerId { get; set; } //TcNo gerçek müşteriye ait bir özelliktir.

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

    }
}
//IndividualCustomer aynı zamanda bir Customer'dır.
//gerçek müşteri sınıfı Customer sınıfını inherit aldı. (MİRAS)
//yani IndividualCustomer ebeveyni olan Customer sınıfındaki özellikleri miras aldı.
//dolayısıyla IndividualCustomer sınıfında olusturulan objeler; hem IndividualCustomer sınıfının hem de Customer sınıfının özelliklerini kullanabilirler.