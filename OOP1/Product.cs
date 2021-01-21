using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //*** bu tip class'larda sadece özellikler olur. Fiyatı,kategorisi, ıd vs. ***
                 //***method ve operasyon içeren class'lar ayrı olur.***
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

    }
}
