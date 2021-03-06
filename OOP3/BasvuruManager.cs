using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection:bu metodun kullanacağı kerdimanagerin ne olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)  //(soyut haller)burdaki parametreyle hangi krediyi gönderirsem o kredinin hesaplası çelışır
        {
            //Basvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla(); //Tüm başvuruları konut kredisine bağımlı yaptık. Doğru değil

            krediManager.Hesapla();  // böylece hangi krediyi parametre olarak gönderirsek onun hesaplası çalışır.
            loggerService.Log(); //hangi loger service gönderilmişse onu logla
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //listedeki her bir kredinin hesabını yap
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
