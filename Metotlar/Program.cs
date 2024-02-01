using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "ELma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Muz";
            urun2.Fiyati = 45;
            urun2.Aciklama = "Yerli";

            Urun[] urunler = new Urun[] { urun1, urun2, };

            foreach(var item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("------------");
            }
            Console.WriteLine("---------Metotlar----------");

            //instance
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //Ekle2(string urunAdi, string aciklama, double fiyat) içindekiler aşağıda isteniyor
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 200);
            sepetManager.Ekle2("Elma", "Yeşil elma", 22, 3000);
            sepetManager.Ekle2("Karpuz", "Sulu", 32, 100);
        }
    }
}
