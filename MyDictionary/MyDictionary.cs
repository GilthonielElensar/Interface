using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<S, A>
    {
        S[] sicilNo;
        A[] adSoyad;
        public MyDictionary()
        {
            sicilNo = new S[0];
            adSoyad = new A[0];
        }
        public void Add(S SN, A AS)
        {
            S[] tempsicilNo = sicilNo;
            A[] tempadSoyad = adSoyad;

            sicilNo = new S[sicilNo.Length + 1];
            adSoyad = new A[adSoyad.Length + 1];

            for (int i = 0; i < tempsicilNo.Length; i++)
            {
                sicilNo[i] = tempsicilNo[i];
            }
            sicilNo[sicilNo.Length - 1] = SN;

            for (int i = 0; i < tempadSoyad.Length; i++)
            {
                adSoyad[i] = tempadSoyad[i];
            }
            adSoyad[adSoyad.Length - 1] = AS;

        }
        public void ToList()
        {
            Console.WriteLine("==================PERSONELLER======================");
            for (int i = 0; i < sicilNo.Length; i++)
            {
                Console.WriteLine("Sicil No= " + sicilNo[i] + " <---> " + "Adı Soyadı= " + adSoyad[i]);

            }
            Console.WriteLine("====================================================");
        }
    }
}