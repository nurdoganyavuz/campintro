using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{          //İhtiyaç Kredisi
    class PersonalFinanceCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
