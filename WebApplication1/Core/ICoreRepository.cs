using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace WebApplication1.Core
{
    public interface ICoreRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T?> Get(int id);
        Task<T?> Add(T entity);
        Task<T?> Update(T entity);
        Task<T> Delete(int id);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

    }
}
