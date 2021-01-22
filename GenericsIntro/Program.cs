using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //<--> bunun içerisinde istediğimiz class'ı verebiliriz. (int,bool,string,customer,product..vs)
            //string türünde bir liste oluşturmak istiyoruz. O yüzden <string> yaptık. 
            
            MyList<string> isimler = new MyList<string>(); 
            isimler.Add("nur");






        }
    }
}
