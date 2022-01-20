using FrwkBootCampQuickWait.Hospitals.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrwkBootCampQuickWait.Hospitals.Domain.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<TEntity> AsNoTracking<TEntity>(this IQueryable<TEntity> items, bool asNoTracking) where TEntity : Entity
        {
            if (!asNoTracking)
                return items;

            return items.AsNoTracking();
        }
    }
}
