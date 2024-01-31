using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    public class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici";
            string kurs2 = "Yazılım";
            string kurs3 = "Java";
            string kurs4 = "JavaScript";

            //array - dizi

            string[] kurslar = new string[]
            {
                "Yazılım geliştirici", "Yazılım", "Java", "JavaScript"
            };

            for (int i = 0; i < kurslar.Length; i++) //birer artır   i=i+2 -->2 2 arttır   i+=2 böyle de yazılabilir
                //kurslar.Length eleman sayısı
            {
                Console.WriteLine(kurslar[i]); //kursların i'ninci elemanını yazdır
            }

            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar) //dizi yapılı temelleri tek tek dönmeye yarar
            {
                Console.WriteLine(kurs);
            }

            

            Console.WriteLine("Sayfa Sonu");
        }
    }
}
