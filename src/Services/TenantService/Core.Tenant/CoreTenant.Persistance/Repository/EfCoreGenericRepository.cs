using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTenant.Persistance.Repository
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
                   where TEntity : class
                   where TContext : DbContext, new()
    {

        private readonly TContext context;
        public EfCoreGenericRepository(TContext context)
        {
            this.context = context;
        }
        public async Task<TEntity> Create(TEntity t)
        {
            using (var context = new TContext())
            {

                var addedEntity = context.Set<TEntity>().Entry(t);
                addedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
                return t;
            }
        }

        public async Task Delete(TEntity t)
        {
            using (var context = new TContext())
            {
              
                context.Set<TEntity>().Remove(t);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAll()
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().ToListAsync();

            }
        }

        public async Task<TEntity> GetElemanById(int id)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().FindAsync(id);

            }
        }

        public async Task<TEntity> Update(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Entry(t).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return t;
            }
        }
    }
}
