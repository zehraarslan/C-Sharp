using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // Başvuru bilgilerini değerlendirme
            krediManager.Hesapla();
            foreach (ILoggerService logger in loggerServices)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediManagers)
        {
            foreach (IKrediManager krediManager in krediManagers)
            {
                krediManager.Hesapla();
            }
        }
    }
}
