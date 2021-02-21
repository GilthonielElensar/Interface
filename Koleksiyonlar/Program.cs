using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin","Murat","Kerem","Halil"}; //4 elemanlı bir dizi
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ////Bu diziye yeni bir eklemek mümkün değildir.
            //isimler = new string[5];//Burada 5 elemanlı yeni bir dizi oluşturmuş oluyoruz. yukarıdaki diziyi 5 elemana çıkartmış olmuyoruz.
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); // bu boş sonuç döndürecektir. Çünkü be yeni dizinin ilk elemanını tanımlamadık. Sadece 5. elemana "ilker" değerini atadık.

            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker");  //isimler listesine/koleksiyonuna yeni bir eleman ekledik. Aynı adres üzerinde. Burdaki Add() List'in bir fonksiyonudur.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
