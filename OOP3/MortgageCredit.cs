using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{         //Konut Kredisi
    class MortgageCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
