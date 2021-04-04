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
            //CategoryTest();
            ProductManager productManager = new ProductManager(new EFProductDal());

            var result = productManager.GetAllProductDetail();
            if (result.Success)
            {
                Console.WriteLine(result.Message);
                Console.WriteLine();
                foreach (var productDetails in productManager.GetAllProductDetail().Data)
                {
                    Console.WriteLine($"{productDetails.ProductId} - {productDetails.ProductName} - {productDetails.UnitsInStock} - {productDetails.CategoryName}");
                }
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var product in productManager.GetAll().Data)
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var product in productManager.GetbyUnitPrice(20, 100).Data)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
