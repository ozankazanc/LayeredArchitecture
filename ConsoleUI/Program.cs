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
            ProductManager productManager = new ProductManager(new EFProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            foreach (var product in productManager.GetbyUnitPrice(40,20))
            {
                Console.WriteLine(product.ProductName);
            }

          


            Console.WriteLine("Hello World!");
        }
    }
}
