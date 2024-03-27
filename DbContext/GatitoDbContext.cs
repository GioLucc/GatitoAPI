using GatitoAPI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace GatitoAPI;

public class GatitoDbContext : DbContext
{
    public GatitoDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Gatito>()
        .ToTable("Gatito");

    }

    public DbSet<Gatito>? Gatitos { get; set; }


}
