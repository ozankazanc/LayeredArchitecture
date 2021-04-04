using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryManager;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryManager = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryManager.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryManager.Get(x => x.CategoryId == categoryId);
        }
    }
}
