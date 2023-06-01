using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infra.Persitence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<Book>()
        //       .HasOne(b => b.Author)
        //       .WithMany(a => a.Books)
        //       .OnDelete(DeleteBehavior.Cascade);
    }


    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.UpdatedDate = DateTime.Now;
                    break;

                case EntityState.Modified:
                    entry.Entity.UpdatedDate = DateTime.Now;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

}
