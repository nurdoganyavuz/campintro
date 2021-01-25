using System;

namespace OOP3
{          
    class ArtisanCredit : ICreditManager //Esnaf Kredisi
    {
        
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı.");
        }

        public void Add()
        {
            Console.WriteLine("Esnaf kredisi hesaba eklendi.");
        }
    }
}
