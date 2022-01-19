using FrwkBootCampQuickWait.Remedies.Domain.Entities;
using FrwkBootCampQuickWait.Remedies.Domain.Interfaces;

namespace FrwkBootCampQuickWait.Remedies.Infrastructure.Repository
{
    public class RemedyRepository : IRemedyRepository
    {
        public Task<Remedy> Add(Remedy remedy)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Remedy>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Remedy> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(Remedy remedy)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Remedy remedy)
        {
            throw new NotImplementedException();
        }
    }
}
