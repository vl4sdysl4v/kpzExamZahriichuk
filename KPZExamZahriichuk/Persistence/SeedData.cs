using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public static class SeedData
{
    public static void SeedDoctors(this ModelBuilder builder)
    {
        builder.Entity<Doctor>().HasData(
            new Doctor
            {
                Id = 1,
                FirstName = "John",
                LastName = "Jackson"
            },
            new Doctor
            {
                Id = 2,
                FirstName = "Jesse",
                LastName = "Cailari"
            });
    }

    public static void SeedPatients(this ModelBuilder builder)
    {
        builder.Entity<Patient>().HasData(
            new Patient
            {
                Id = 1,
                FirstName = "Vlad",
                LastName = "Zahriichuk",
                DateOfBirth = new DateOnly(2003, 12, 22),
                DoctorId = 2
            },
            new Patient
            {
                Id = 2,
                FirstName = "Vitalii",
                LastName = "Havryliuk",
                DateOfBirth = new DateOnly(2003, 1, 12),
                DoctorId = 1
            },
            new Patient
            {
                Id = 3,
                FirstName = "Nyx",
                LastName = "Ting",
                DateOfBirth = new DateOnly(2000, 7, 13),
                DoctorId = 2
            },
            new Patient
            {
                Id = 4,
                FirstName = "Andrii",
                LastName = "Vytak",
                DateOfBirth = new DateOnly(1995, 5, 2),
                DoctorId = 2
            },
            new Patient
            {
                Id = 5,
                FirstName = "Bohdan",
                LastName = "Balytskii",
                DateOfBirth = new DateOnly(1990, 8, 17),
                DoctorId = 1
            });
    }

    public static void SeedSIcknessHistories(this ModelBuilder builder)
    {
        builder.Entity<SicknessHistory>().HasData(
            new SicknessHistory
            {
                Id = 1,
                Description = "Headache",
                DoctorId = 2,
                PatientId = 1,
                Date = new DateTime(2022, 9, 12, 14, 0, 0)
            },
            new SicknessHistory
            {
                Id = 2,
                Description = "Tsyroz",
                DoctorId = 1,
                PatientId = 2,
                Date = new DateTime(2022, 10, 3, 22, 0, 0)
            },
            new SicknessHistory
            {
                Id = 3,
                Description = "Strange thing",
                DoctorId = 2,
                PatientId = 3,
                Date = new DateTime(2022, 7, 21, 13, 0, 0)
            },
            new SicknessHistory
            {
                Id = 4,
                Description = "Insomnia",
                DoctorId = 2,
                PatientId = 4,
                Date = new DateTime(2022, 11, 13, 9, 0, 0)
            },
            new SicknessHistory
            {
                Id = 5,
                Description = "Broken arm",
                DoctorId = 1,
                PatientId = 5,
                Date = new DateTime(2022, 10, 5, 16, 0, 0)
            });
    }
}
