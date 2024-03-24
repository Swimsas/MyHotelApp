namespace MyHotelApp.Infrastructure.Common
{
    public interface IRepository
    {
        Task<T?> GetByIdAsync<T>(object id) where T : class;
        IQueryable<T> All<T>() where T : class; 
        IQueryable<T> AllReadOnly<T>() where T : class;
        Task AddAsync<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
    }
}
