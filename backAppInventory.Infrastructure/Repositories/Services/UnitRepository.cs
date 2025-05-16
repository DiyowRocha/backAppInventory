using backAppInventory.Domain.Models;
using backAppInventory.Infrastructure.Context;
using backAppInventory.Infrastructure.Repositories.Interfaces;

namespace backAppInventory.Infrastructure.Repositories.Services;

public class UnitRepository : Repository<Unit>, IUnitRepository
{
    public UnitRepository(ApplicationContext context) : base(context)
    {
    }
}