using FrwkBootCampQuickWait.Hospitals.Domain.Contracts;
using FrwkBootCampQuickWait.Hospitals.Domain.Entities;
using FrwkBootCampQuickWait.Hospitals.Infrastructure.Repositories;

namespace FrwkBootCampQuickWait.Hospitals.Infrastructure.HospitalContext
{
    public sealed class HospitalRepository : BaseRepository<Hospital>
    {
        public HospitalRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
