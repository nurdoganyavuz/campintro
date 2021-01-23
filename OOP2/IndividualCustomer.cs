using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{         //Gerçek Müşteri
    class IndividualCustomer : Customer 
    {
        public string CustomerId { get; set; } //TcNo

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

    }
}
