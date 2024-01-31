using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            string adi = "Melike";
            int yas = 22;

            Kurs kurs1 = new Kurs(); //tipi kurs
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "";
            kurs2.IzlenmeOrani = 4;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "";
            kurs3.IzlenmeOrani = 88;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi + " : " + item.IzlenmeOrani);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
