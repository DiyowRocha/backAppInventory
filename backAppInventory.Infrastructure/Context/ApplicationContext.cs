using backAppInventory.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace backAppInventory.Infrastructure.Context;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    public DbSet<Unit> Units { get; set; }
}