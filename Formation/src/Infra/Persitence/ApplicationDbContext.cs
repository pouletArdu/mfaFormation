using Microsoft.EntityFrameworkCore;

namespace Infra.Persitence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}
