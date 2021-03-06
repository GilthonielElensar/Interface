using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager //(inheritance)/ Her kredi mutlaka bu interfaceteki metotları kullanmak zorunda
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");

        }
    }
}
