using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint-IEntityRepository<T> T'ye ne olabileceği belirtme işlemi
    //class : referans tip - (class olabilir demek değildir, referans tipi classtır demek)
    //T sadece IEntity ve ya IEntity implement eden classlar olabilir.
    //Yani Sadece Class olarak tanımlamak yetmez. 
    //IEntity 'de tek başına bir şey ifade etmez. Bu yüzden new() ifadesi ekliyoruz. (IEntity New()lenemez).
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        /// <summary>
        /// Expression<Func<T,bool>> filter = null ---> "-predicate-" diye geçer, delegedir
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // null olmasının sebebi bütün veriyi çekerken filtre vermedende çekebilme ihtimalimizdir.
        T Get(Expression<Func<T, bool>> filter); // Amaç zaten spesifik bir kaydı çekmek olduğu için filtre mecburen veriyoruz bu yüzden null geçmiyoruz.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
