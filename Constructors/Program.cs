using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer customer = new Customer(); //newleme yaptığımızda constructor çalışır.
            Customer customer1 = new Customer { Id=1, FirstName="Engin",LastName="Demiroğ",City="Ankara"};
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }
    } 
    
    class Customer
    {
        public Customer(int id, string firstName, string lastName, string city)
        {
            //constructor da değerlerimi aşağıdaki gibi set ediyorum.
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        //default constructor: parametresi olmayan constructora denir.
        public Customer()  //ctor+tab+tab dediğimizde constructor oluşur
        {
            
        }
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string City { get; set; }

    }
}
