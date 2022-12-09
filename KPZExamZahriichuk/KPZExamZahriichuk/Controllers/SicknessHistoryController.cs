using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using KPZExamZahriichuk.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace KPZExamZahriichuk.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class SicknessHistoryController : ControllerBase
{
    private readonly IGenericRepository<SicknessHistory> _sicknessRepository;
    private readonly IMapper _mapper;

    public SicknessHistoryController(IGenericRepository<SicknessHistory> sicknessRepository, IMapper mapper)
    {
        _sicknessRepository = sicknessRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetSicknessHistoryAsync()
    {
        var sicknessHistories = (await _sicknessRepository.GetAllAsync()).ToList();

        var result = _mapper.Map<List<SicknessDto>>(sicknessHistories);

        return Ok(result);
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateSicknessAsync([FromBody] CreateSicknessDto model)
    {
        var sickness = _mapper.Map<SicknessHistory>(model);

        var result = await _sicknessRepository.CreateAsync(sickness);

        return Ok(result);
    }
}
