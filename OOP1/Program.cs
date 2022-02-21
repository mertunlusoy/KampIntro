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

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 6,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            // ProductManager classında oluşturulan productManager değişkeni,
            // yeni bir referans numarası almış ProductManager'dır.
            // Stack(eşitliğin sol tarafı) --- Heap (eşitliğin sağ tarafı)

            productManager.Add(product1);



        }
    }
}
