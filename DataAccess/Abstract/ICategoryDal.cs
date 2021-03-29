using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        Product Get(int Id);
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        List<Product> GetAllbyCategorysProduct(int categoryId);
    }
}
