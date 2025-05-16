using System.Threading.Tasks;
using backAppInventory.Infrastructure.Context;
using backAppInventory.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backAppInventory.Infrastructure.Repositories.Services;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly ApplicationContext _context;

    public Repository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<T?> GetById(Guid id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
}