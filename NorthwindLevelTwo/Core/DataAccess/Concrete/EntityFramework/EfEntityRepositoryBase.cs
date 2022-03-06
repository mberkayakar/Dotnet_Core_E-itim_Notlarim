using Core.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
    //GetList in return ünü halletsene bi
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()

    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var eklenen = context.Entry(entity);
                eklenen.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {

            using (TContext context = new TContext())
            {
                var silinen = context.Entry(entity);
                silinen.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }

        TEntity IEntityRepository<TEntity>.Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
      
            using (TContext contex = new TContext())
            {
                return contex.Set<TEntity>().ToList();
              
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var güncelle = context.Entry(entity);
                güncelle.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
