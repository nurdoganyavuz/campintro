using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{         //Tüzel Müşteri
    class LegalCustomer : Customer
    {     
        public string CompanyName { get; set; } //şiket adi

        public string TaxNo { get; set; } //vergi no
    }
}

//LegalCustomer aynı zamanda bir Customer'dır.
//tüzel müşteri sınıfı Customer sınıfını inherit aldı.
//yani LegalCustomer ebeveyni olan Customer sınıfındaki özellikleri miras aldı.
//dolayısıyla LegalCustomer sınıfında olusturulan objeler; hem LegalCustomer sınıfının hem de Customer sınıfının özelliklerini kullanabilirler.