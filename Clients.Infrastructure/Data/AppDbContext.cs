using Clients.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clients.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients => Set<Client>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Client>(entity =>
           {
               entity.ToTable("Clients");
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Nombres).IsRequired().HasMaxLength(100);
               entity.Property(e => e.Apellidos).IsRequired().HasMaxLength(100);
               entity.Property(e => e.Identificacion).IsRequired().HasMaxLength(20);
               entity.Property(e => e.Correo).IsRequired().HasMaxLength(100);
               entity.Property(e => e.Telefono).IsRequired().HasMaxLength(20);
           });
        }
    }
}
