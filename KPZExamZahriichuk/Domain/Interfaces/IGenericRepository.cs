using System.Linq.Expressions;

namespace Domain.Interfaces;

public interface IGenericRepository<T>
{
    Task<IQueryable<T>> GetAllAsync();
    Task<IQueryable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition);
    Task<int> CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
