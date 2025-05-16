using backAppInventory.Application.DTOs.Unit;
using backAppInventory.Application.ViewModels.Unit;

namespace backAppInventory.Application.Services.Interfaces;

public interface IUnitService
{
    Task<UnitViewModel> CreateUnitAsync(CreateUnitDTO unit);
}