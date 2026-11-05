using PortalTransparencia.Application.Interfaces;
using PortalTransparencia.Domain.Entities;
using PortalTransparencia.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace PortalTransparencia.Infrastructure.Repositories
{
 public class PqrsdfRepository : IPqrsdfRepository
    {
        private readonly ApplicationDbContext _context;

        public PqrsdfRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Pqrsdf> CrearAsync(Pqrsdf pqrsdf)
        {
            int totalRegistros = await _context.Pqrsdfs.CountAsync() + 1;
            pqrsdf.Radicado = $"PQRS-{DateTime.UtcNow.Year}-{totalRegistros.ToString("D3")}";
            pqrsdf.FechaRadicacion = DateTime.UtcNow;

            _context.Pqrsdfs.Add(pqrsdf);
            await _context.SaveChangesAsync();
            return pqrsdf;
        }

        public async Task<Pqrsdf?> ObtenerPorRadicadoAsync(string radicado)
        {
            return await _context.Pqrsdfs
                .FirstOrDefaultAsync(p => p.Radicado == radicado);
        }
    }
}