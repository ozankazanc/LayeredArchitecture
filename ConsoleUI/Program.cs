using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var product in productManager.GetbyUnitPrice(20, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
