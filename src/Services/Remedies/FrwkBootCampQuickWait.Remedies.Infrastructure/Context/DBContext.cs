using FrwkBootCampQuickWait.Remedies.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrwkBootCampQuickWait.Remedies.Infrastructure.Context
{
    public class DBContext : DbContext//, IDbContext
    {

        public DBContext()
        {

        }

        public DBContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        public virtual DbSet<Remedy> Remedies { get; set; }


    }
}
