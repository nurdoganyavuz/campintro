using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Döngüler

            //step size'ı aşagıdaki gibi farklı şekillerde kullanabiliriz;
            // i++   --> i = i + 1 (1'er artırma)
            //i += 2 --> i = i + 2 (2'şer artırma) 
            
            for (int i = 1; i <=10; i+=2)
            {
                Console.WriteLine(i); 
            }

            //Diziler

            string[] kurslar = new string[] {"Yazılım Geliştirici Kampı",
                "Programlamaya Başlangıc", "Java" , "C#"};

            for (int i = 0;  i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for döngüsü sonu");
            foreach (string kurs in kurslar) //pythondaki for yapısıyla aynı işlevde
                                             //dizileri tek tek döndürmemize olanak sağlar.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");





        }
    }
}
