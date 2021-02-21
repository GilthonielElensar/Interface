using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35};
            
            //PascalCase=class isimlendirilirken kelimelerin baş harfleri büyük yazılır
            //camelCase=değişken isimlerinde ise kelimelerin ilk harfi küçük ile başlariki kelime ise ikinci kelime büyük harf ile başlar
            //case sensitive: java ve c# ta büyük/küçük harf duyarlılığı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1); //bu productı ProductManager'e gönderiyor
            Console.WriteLine(product1.ProductName);

            //
        }
    }
}
