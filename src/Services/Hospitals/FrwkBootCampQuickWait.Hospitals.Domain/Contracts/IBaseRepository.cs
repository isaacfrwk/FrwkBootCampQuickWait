using FrwkBootCampQuickWait.Hospitals.Domain.Entities;
using System.Linq.Expressions;

namespace FrwkBootCampQuickWait.Hospitals.Domain.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task AddAsync(TEntity entity);

        void DeleteSync(TEntity entity);

        void DeleteManySync(IEnumerable<TEntity> entities);

        Task<IEnumerable<TEntity>> FindAllAsync(bool asNoTracking = true);

        IEnumerable<TEntity> FindSync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = true);

        Task<TEntity> GetByIdAsync(Guid id);

        Task<int> SaveChangesAsync();

        void UpdateSync(TEntity entity);
    }
}
