using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; //array'i metotun dışında ama classın içinde yazdık. Çünkü class içindeki tüm metotlar bu diziye ulaşabilsin istiyorum.
        //constructor: Bir class new'lendiğinde çalışan bloğa denir.
        public MyList()      //ctor+tab+tab dediğimizde bu yapı oluştu. Buna constructor denir. constructor ile class'ın ismi daima aynı olur. 
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //Geçici dizi, refaransımı tutuyor.
            items = new T[items.Length + 1];  //Dizideki eleman sayım 1 arttı
            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
