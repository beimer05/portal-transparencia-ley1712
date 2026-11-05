using Microsoft.EntityFrameworkCore;
using PortalTransparencia.Domain.Entities;

namespace PortalTransparencia.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pqrsdf> Pqrsdfs => Set<Pqrsdf>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pqrsdf>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Radicado).IsRequired().HasMaxLength(50);
                entity.Property(e => e.TipoSolicitud).IsRequired().HasMaxLength(50);
                entity.Property(e => e.NombreSolicitante).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Asunto).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Descripcion).IsRequired();
            });
        }
    }
}