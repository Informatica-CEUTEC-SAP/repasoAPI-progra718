using Microsoft.EntityFrameworkCore;
using repasoAPI.Data;

namespace repasoAPI.Repositorio;
// IR a la base de datos y obtener los datos
public class RepasoRepository<T>: IRepasoRepository<T>
    where T : class
{
    private readonly DbContextEstudiante _context;
    private readonly DbSet<T> _dbSet;
    
    public RepasoRepository(DbContextEstudiante context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<T>();
    }
    
    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _dbSet.FindAsync(id) != null;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public IQueryable<T> Query()
    {
        return _dbSet.AsQueryable();
    }
}