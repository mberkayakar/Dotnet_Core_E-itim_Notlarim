using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        // Generic repository altyapısı kurulduğundan ötürü buraya gerçey generic olarak yazılmaktadır.
        List<T> GetList(Expression <Func <T,bool>> filter = null);

        // Tek bir eleman çekme için kullanılmaktadır
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
