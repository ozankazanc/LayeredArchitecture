using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface'in kendisi public değildir, methodları publictir.
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int Id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
