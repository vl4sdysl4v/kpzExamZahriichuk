using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

internal class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.ToTable("Doctors");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();

        builder.HasMany(x => x.Patients)
            .WithOne(x => x.Doctor)
            .HasForeignKey(x => x.DoctorId);

        builder.HasMany(x => x.SicknessHistories)
            .WithOne(x => x.Doctor)
            .HasForeignKey(x => x.DoctorId);
    }
}
