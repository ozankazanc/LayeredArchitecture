using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        readonly IProductDal _productManager;
        public ProductManager(IProductDal productDal)
        {
            _productManager = productDal;
        }

        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public List<Product> GetAll()
        {
            //buraya şartları yazıyoruz.
            //sonrasında getall dönüyoruz aslında.
            return _productManager.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productManager.GetAll(x => x.CategoryId == id);
        }

        public List<ProductDetailDto> GetAllProductDetail()
        {
            return _productManager.GetProductDetails();
        }

        public Product GetById(int productId)
        {
            return _productManager.Get(x => x.ProductId == productId);
        }

        public List<Product> GetbyUnitPrice(decimal min, decimal max)
        {
            return _productManager.GetAll(x=>x.UnitPrice<=max && x.UnitPrice>=  min);
        }
    }
}
