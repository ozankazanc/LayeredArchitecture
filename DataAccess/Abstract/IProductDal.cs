using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface'in kendisi public değildir, methodları publictir.
    public interface IProductDal : IEntityRepository<Product>
    {
        

    }
}
