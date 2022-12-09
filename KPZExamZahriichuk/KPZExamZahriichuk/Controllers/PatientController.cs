using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using KPZExamZahriichuk.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KPZExamZahriichuk.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class PatientController : ControllerBase
{
    private readonly IGenericRepository<Patient> _patientsRepository;
    private readonly IMapper _mapper;

    public PatientController(IGenericRepository<Patient> patientsRepository, IMapper mapper)
    {
        _patientsRepository = patientsRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetPatientsForDoctorAsync()
    {
        var patients = (await _patientsRepository.GetAllAsync()).ToList();

        var result = _mapper.Map<List<PatientDto>>(patients);

        return Ok(result);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreatePatientAsync([FromBody] CreatePatientDto model)
    {
        var patient = _mapper.Map<Patient>(model);

        var result = await _patientsRepository.CreateAsync(patient);

        return Ok(result);
    }
}
