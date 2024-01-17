using WebApplication1.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;


namespace WebApplication1.Core
{
    public abstract class CoreRepository<TEntity , Tcontext> : ICoreRepository<TEntity>
        where TEntity : class, IEntity
        where Tcontext : DbContext

    {
        protected readonly Tcontext context;
        public CoreRepository(Tcontext context)
        {
            this.context = context;
        }
        public async Task<TEntity?> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            if (await context.SaveChangesAsync() == 0)
                return null;
            return entity;
        }
        public void AddWithoutSavechanges(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }
        public async Task<TEntity> Delete(int id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity!;
            }

            context.Set<TEntity>().Remove(entity);
            if (await context.SaveChangesAsync() == 0) return entity;

            return null!;
        }
        public async Task<TEntity?> Get(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }
        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }
        public async Task<TEntity?> Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            if (await context.SaveChangesAsync() == 0) return null;
            return entity;
        }
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return this.context.Set<TEntity>().Where(expression).AsNoTracking();
        }

    }
}
