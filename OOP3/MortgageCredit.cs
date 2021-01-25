using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3 //Konut Kredisi
{
    
    class MortgageCredit : ICreditManager 
    {
        
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void Add()
        {
            Console.WriteLine("Konut kredisi hesaba eklendi.");
        }
    }
}

//kamp 5. gün
//implemente ederiz, yani ICreditManager interface'ini kullanırız.
//çünkü bu kredinin içinde de hesapla ve ekleme operasyonunu kullanmak istiyoruz.
//her kredinin kendine has hesaplama operasyonu var; Calculate1, Calculate2... Ayrı ayrı hepsine yazmaya gerek yok. 
//böyle tek tek olusturmamak için; bir tane hesapla fonk.'unu bütün krediler için yeniden kullanırız. 
//hesapla ve ekleme fonk.unun imzası(void Calculate(), void Add() şeklinde) bütün kredilerde aynıdır, fakat içerikleri krediye özgü olusturulur.
//alternatif sistemlerde ***imzası aynı, içeriği farklı*** operasyonlar kullanacagımızda Interface olustururuz.