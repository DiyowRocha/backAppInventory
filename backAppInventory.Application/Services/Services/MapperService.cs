using AutoMapper;
using backAppInventory.Application.Services.Interfaces;

namespace backAppInventory.Application.Services.Services;

public class MapperService : IMapperService
{
    private readonly IMapper _mapper;

    public MapperService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public TDestination Map<TSource, TDestination>(TSource source)
    {
        return _mapper.Map<TDestination>(source);
    }
}