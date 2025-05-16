using backAppInventory.Application.DTOs.Unit;
using backAppInventory.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace backAppInventory.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UnitController : ControllerBase
{
    private readonly IUnitService _unitService;

    public UnitController(IUnitService unitService)
    {
        _unitService = unitService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateUnitAsync([FromBody] CreateUnitDTO unitDto)
    {
        var createdUnit = await _unitService.CreateUnitAsync(unitDto);
        return Ok(createdUnit);
    }
}