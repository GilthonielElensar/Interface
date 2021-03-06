using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); --> aynı anlama gelir, aynı çıktıyı verir.
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); 
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService()); // Bu da farklı bir new'leme şeklidir. Bu şekilde de yapılabilir, üstteki gibi new'lenip alttaki gibi de çağrılabilir
            //basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService); //burdakini seçimli ekran gibi düşünün. şimdi ihtiyaçkredisi seçtim onunla ilgili işlemler gelecek. konut seçseydim onunla ilgili özellikler gelirdi.

            //List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager }; //şuan ihtiyaçKredisini gönderdim
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager }; //şuan hem ihtiyaçKredisini hemde  taşıtKredisini gönderdim. Hesapladım.            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
