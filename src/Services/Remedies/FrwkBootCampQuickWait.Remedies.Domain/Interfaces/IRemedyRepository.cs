using FrwkBootCampQuickWait.Remedies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrwkBootCampQuickWait.Remedies.Domain.Interfaces
{
    public interface IRemedyRepository
    {
        Task<IEnumerable<Remedy>> GetAll();
        Task<Remedy> GetById(Guid id);
        Task<Remedy> Add(Remedy remedy);
        Task<bool> Update(Remedy remedy);
        Task<bool> RemoveById(Guid id);
        Task<bool> Remove(Remedy remedy);
    }
}
