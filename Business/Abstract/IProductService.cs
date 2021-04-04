using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int productId);
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetbyUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetAllProductDetail();
        void Add(Product product);

    }
}
