namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtıyacKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();
            List<ILoggerService> loggers1 = new List<ILoggerService> { databaseLogger, new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers1);
            basvuruManager.BasvuruYap(konutKrediManager, new  List<ILoggerService> { new DatabaseLoggerService()});
            basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService()});
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() });

            List<IKrediManager> krediManagers = new List<IKrediManager>();
            krediManagers.Add(ihtiyacKrediManager);
            krediManagers.Add(tasitKrediManager);
            //basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);
        }
    }
}