using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //Test amaçlıdır. Bir veritabanı simule edilmektedir.
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Test amaçlıdır. Bir veritabanı simule edilmektedir.
            _products = new List<Product>()
            {
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ProductName="Bardak",
                    UnitPrice=15,
                    UnitsInStock=20
                }
                ,new Product
                {
                    ProductId=2,
                    CategoryId=1,
                    ProductName="Kamera",
                    UnitPrice=500,
                    UnitsInStock=3
                }
                ,new Product
                {
                    ProductId=3,
                    CategoryId=2,
                    ProductName="Telefon",
                    UnitPrice=1500,
                    UnitsInStock=2
                }
                ,new Product
                {
                    ProductId=4,
                    CategoryId=2,
                    ProductName="klavye",
                    UnitPrice=150,
                    UnitsInStock=85
                }
                ,new Product
                {
                    ProductId=5 ,
                    CategoryId=2,
                    ProductName="fare",
                    UnitPrice=85,
                    UnitsInStock=1
                }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //_products.Remove(product);
            //Bu şekilde bir silme işlemi gerçekleştiremeyiz. 
            //Parametre olarak gelen product'ın bellekteki referansı ile, tanımladığımız productların bellekteki referansları farklıdır.

            Product productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
