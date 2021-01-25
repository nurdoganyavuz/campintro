using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{         //Taşıt Kredisi
    class TransportCredit : ICreditManager
    {
        
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void Add()
        {
            Console.WriteLine("Taşıt kredisi hesaba eklendi.");
        }
    }
}
