using AutoMapper;
using backAppInventory.Application.DTOs.Unit;
using backAppInventory.Application.Services.Interfaces;
using backAppInventory.Application.ViewModels.Unit;
using backAppInventory.Domain.Models;
using backAppInventory.Infrastructure.Repositories.Interfaces;

namespace backAppInventory.Application.Services.Services;

public class UnitService : IUnitService
{
    private readonly IUnitRepository _unitRepository;
    private readonly IMapper _mapper;

    public UnitService(IUnitRepository unitRepository, IMapper mapper)
    {
        _unitRepository = unitRepository;
        _mapper = mapper;
    }

    public async Task<UnitViewModel> CreateUnitAsync(CreateUnitDTO unitDto)
    {
        var unit = _mapper.Map<CreateUnitDTO, Unit>(unitDto);

        await _unitRepository.Add(unit);

        return _mapper.Map<Unit, UnitViewModel>(unit);
    }
}