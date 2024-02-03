using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager, new FileLoggerService); //böylede yazılabilir
            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()});  //List<ILoggerService> yapsaydık 
            //List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLogerService()}); böylede yazılabilir


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirme(krediler);
        }
    }
}
