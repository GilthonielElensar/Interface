using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            Mylist<string> sehirler2 = new Mylist<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);

        }
        class Mylist<T> //Generic class: Burdaki T hangi tip verirsen ona dönüşüyor metodumuz. Örneğin yukarıda string girdik.
        {
            T[] _array;
            T[] _tempArray;
            public Mylist()  //constructor fonksiyonu
            {
                _array = new T[0];
            }
            public void Add(T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1]; //dizinin eleman sayısını 1 arttırır.
                for (int i = 0; i < _tempArray.Length; i++) //tempArray'in içi kadar aktar
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] = item;   //dizinin boyutunun 1 eksiği olan yere de yeni değer gir.
                                
            }

           
            public int Count
            {
                get { return _array.Length; }
                
            }

        }
    }
}
