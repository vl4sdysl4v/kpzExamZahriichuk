using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Converters;
using Persistence.EntityConfigurations;

namespace Persistence;

public sealed class ApplicationContext: DbContext
{
    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<SicknessHistory> SicknessHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ConfigureEntities(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder modelBuilder)
    {
        modelBuilder.Properties<DateOnly>()
            .HaveConversion<DateOnlyConverter>()
            .HaveColumnType("date");
    }

    private void ConfigureEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PatientConfiguration());
        modelBuilder.ApplyConfiguration(new DoctorConfiguration());
        modelBuilder.ApplyConfiguration(new SicknessHistoryConfiguration());

        modelBuilder.SeedDoctors();
        modelBuilder.SeedPatients();
        modelBuilder.SeedSIcknessHistories();
    }
}
