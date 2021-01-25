using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ICreditManager //interface
    {
        void Calculate(); //Hesapla operasyonu
        void Add(); //ekleme operasyonu
    }
    
        
}

//Eğer interface kullanmazsak; if döngüsü ile eğer taşıt kredisi ise şöyle hesapla, konut kredisiyse böyle hesapla vs yüzlerce şart yazmamız gerekir.
//interface kullanarak cleancode yazmış oluruz, hem kullanışlı hem mantıklı.
//alternatif sistemlerde(konut kredisi, taşıt kredisi vs vs) aynı imzayı birden fazla kullanıyorsak
//mesela Calculate fonk. bütün krediler için var, bütün krediler de Calculate(); olarak tanımlanıyor (imza)
//fakat her birinin içerisinde o krediye özgü işlemler var. Yani bütün kredilerde hesapla fonk. var ama içinde o krediye has hesaplama yöntemleri var.
//bu tarz, opreasyon imzasının aynı içeriğinin ise farklı oldugu durumlarda; base class'ı (mirasçı) interface olarak oluştururuz. (***)

//Eğer bir class; bir interface'i kullanırsa, o interface de tanımlanmış olan bütün operasyonları içermek zorundadır.(!!!)
//Yani taşıt kredisi --> class TransportCredit : ICreditManager bu şekilde interface'i kullanacagını belirtmiş ise
//mutlaka o sınıf içerisinde interface'de yer alan Calculate ve Add operasyonlarını kullanmalıdır.
//interface bir şablonu belirtir ve interface'i kullanan mutlaka onun şablonuna uymalıdır.
