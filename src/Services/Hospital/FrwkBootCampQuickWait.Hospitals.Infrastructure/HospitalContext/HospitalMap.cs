using FrwkBootCampQuickWait.Hospitals.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FrwkBootCampQuickWait.Hospitals.Infrastructure.HospitalContext
{
    public class HospitalMap : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.ToTable("Hospital");
            builder.HasKey(x => x.Id);
        }
    }
}
