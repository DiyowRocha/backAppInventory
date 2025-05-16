namespace backAppInventory.Application.Services.Interfaces;

public interface IMapperService
{
    TDestination Map<TSource, TDestination>(TSource source);
}