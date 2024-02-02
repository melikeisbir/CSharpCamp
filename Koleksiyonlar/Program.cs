using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Melike", "Zehra" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);

            //isimler = new string[3];
            //isimler[2] = "Esin";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Melike", "Zehra", "Esin" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Meli");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
