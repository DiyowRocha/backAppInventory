using AutoMapper;
using backAppInventory.Application.DTOs.Unit;
using backAppInventory.Application.ViewModels.Unit;
using backAppInventory.Domain.Models;

namespace backAppInventory.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUnitDTO, Unit>();
        CreateMap<Unit, UnitViewModel>();
    }
}