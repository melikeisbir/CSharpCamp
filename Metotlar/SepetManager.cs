using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun var)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi: " + var.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //böyle de yazılabilir
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi: " + urunAdi);
        }
    }
}
