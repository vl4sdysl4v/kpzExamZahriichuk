using AutoMapper;
using Domain.Entities;
using KPZExamZahriichuk.Models.Dtos;

namespace Services.Mappers;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Patient, PatientDto>()
            .ForMember(x => x.DateOfBirth, g => g.MapFrom(p => p.DateOfBirth.ToString()))
            .ForMember(x => x.Doctor, g => g.MapFrom(p => p.Doctor.FirstName + " " + p.Doctor.LastName));

        CreateMap<CreatePatientDto, Patient>()
            .ForMember(x => x.DateOfBirth, g => g.MapFrom(p => DateOnly.Parse(p.DateOfBirth)));

        CreateMap<SicknessHistory, SicknessDto>()
            .ForMember(x => x.Date, g => g.MapFrom(s => s.Date.ToString()))
            .ForMember(x => x.Name, g => g.MapFrom(s => s.Patient.FirstName + " " + s.Patient.LastName));

        CreateMap<CreateSicknessDto, SicknessHistory>()
            .ForMember(x => x.Date, g => g.MapFrom(s => DateTime.Parse(s.Date)));
    }
}
