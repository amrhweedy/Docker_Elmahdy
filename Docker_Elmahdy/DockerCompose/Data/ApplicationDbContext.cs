using DockerCompose.Entities;
using Microsoft.EntityFrameworkCore;

namespace DockerCompose.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>().HasData(

       new Employee { Id = 1, Name = "Alice Johnson", Email = "alice@example.com" },
            new Employee { Id = 2, Name = "Bob Smith", Email = "bob@example.com" },
            new Employee { Id = 3, Name = "Charlie Brown", Email = "charlie@example.com" }

            );

    }
}
