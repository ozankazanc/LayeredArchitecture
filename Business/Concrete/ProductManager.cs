using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Product product)
        {
            
           if(product.ProductName.Length<2)
            {
                //magic strings // aslında bu şekilde direk string göndermek iyi değildir.
                return new ErrorResult(message: Messages.ProductNameInValid);
            }
            
            _productManager.Add(product);
            return new SuccessResult(message: Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if(DateTime.Now.Hour==10)
            {
                return new ErrorDataResult<List<Product>>(Messages.ProductsListedOutHours);
            }
           
            return new SuccessDataResult<List<Product>>(_productManager.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productManager.GetAll(x => x.CategoryId == id), Messages.ProductsListed);
        }

        public IDataResult<List<ProductDetailDto>> GetAllProductDetail()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productManager.GetProductDetails(), Messages.ProductsListed);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productManager.Get(x => x.ProductId == productId), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetbyUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productManager.GetAll(x => x.UnitPrice <= max && x.UnitPrice >= min), Messages.ProductsListed);
        }
    }
}
