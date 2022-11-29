namespace Manage.Touristic.Plan.Infraestructure.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
    }
}
