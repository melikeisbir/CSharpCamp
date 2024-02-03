using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); // Tüm basvurular konutkredisine bagımlı oldu
            //konutKrediManager.Hesapla();
            //Console.WriteLine();

            krediManager.Hesapla();
        }
        public void KrediOnBilgilendirme(List<IKrediManager> krediler) //birden fazla kredinin hesabı için
        {
            foreach (var item in krediler)
            {
                item.Hesapla(); //listedeki her bir kredinin hesabını yap
            }
        }
    }
}
