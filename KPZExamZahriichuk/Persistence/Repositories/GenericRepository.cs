using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseEntity
{
    protected ApplicationContext _appContext;

    public GenericRepository(ApplicationContext context) => _appContext = context;

    public async Task<int> CreateAsync(T entity)
    {
        await _appContext.Set<T>().AddAsync(entity);
        await _appContext.SaveChangesAsync();
        return entity.Id;
    }

    public async Task DeleteAsync(T entity)
    {
        _appContext.Set<T>().Remove(entity);
        await _appContext.SaveChangesAsync();
    }

    public async Task<IQueryable<T>> GetAllAsync()
    {
        return (await _appContext.Set<T>().ToListAsync()).AsQueryable();
    }

    public async Task<IQueryable<T>> GetByConditionAsync(Expression<Func<T, bool>> condition)
    {
        return (await _appContext.Set<T>().Where(condition).ToListAsync()).AsQueryable();
    }

    public async Task UpdateAsync(T entity)
    {
        _appContext.Set<T>().Update(entity);
        await _appContext.SaveChangesAsync();
    }
}
