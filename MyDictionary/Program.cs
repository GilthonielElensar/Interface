using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> personel = new MyDictionary<int, string>();
            personel.Add(101, "Ali Yıldırım");
            personel.Add(102, "Selin Demir");
            personel.Add(102, "Mehmet Can");
            personel.Add(102, "Ayşe Arslan");
            personel.Add(102, "Burak Toprak");

            personel.ToList();
        }
    }
}

