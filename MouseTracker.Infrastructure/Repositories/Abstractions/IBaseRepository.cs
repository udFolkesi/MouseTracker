namespace MouseTracker.Infrastructure.Repositories.Abstractions
{
    public interface IBaseRepository<T>
    {
        Task AddAsync(T entity);
    }
}
