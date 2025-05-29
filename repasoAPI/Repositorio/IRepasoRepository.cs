namespace repasoAPI.Repositorio;
//Type generico
public interface IRepasoRepository<T>
    where T : class
{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();

    Task AddAsync(T entity);
    void Update(T entity);
    void Remove(T entity);

    Task<bool> ExistsAsync(int id);
    Task SaveChangesAsync();
    
    IQueryable<T> Query();
}