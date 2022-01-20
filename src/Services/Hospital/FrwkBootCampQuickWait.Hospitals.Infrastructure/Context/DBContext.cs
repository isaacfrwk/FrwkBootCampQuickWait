using FrwkBootCampQuickWait.Hospitals.Domain.Contracts;
using FrwkBootCampQuickWait.Hospitals.Domain.Entities;
using FrwkBootCampQuickWait.Hospitals.Infrastructure.HospitalContext;
using Microsoft.EntityFrameworkCore;

namespace FrwkBootCampQuickWait.Hospitals.Infrastructure.Context
{
    public class DBContext : DbContext, IDbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public virtual DbSet<Hospital> Hospitals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new HospitalMap());
        }
    }
}