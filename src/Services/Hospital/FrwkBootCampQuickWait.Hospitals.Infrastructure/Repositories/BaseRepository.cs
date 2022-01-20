using FrwkBootCampQuickWait.Hospitals.Domain.Contracts;
using FrwkBootCampQuickWait.Hospitals.Domain.Entities;
using FrwkBootCampQuickWait.Hospitals.Domain.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FrwkBootCampQuickWait.Hospitals.Infrastructure.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        private readonly IDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        protected BaseRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual void DeleteSync(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual void DeleteManySync(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync(bool asNoTracking = true)
        {
            return await _dbSet.AsNoTracking(asNoTracking).ToListAsync();
        }

        public IEnumerable<TEntity> FindSync(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = true)
        {
            return _dbSet.Where(predicate).AsNoTracking(asNoTracking);
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
           return await _dbSet.FindAsync(id);              
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public virtual void UpdateSync(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
