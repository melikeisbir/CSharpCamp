using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
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
