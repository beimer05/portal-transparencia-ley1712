using PortalTransparencia.Application.Interfaces;
using PortalTransparencia.Domain.Entities;
using System.Collections.Concurrent;

namespace PortalTransparencia.Infrastructure.Repositories
{
    public class PqrsdfRepository : IPqrsdfRepository
    {
        // Almacén temporal en memoria hasta conectar SQL Server con EF Core
        private static readonly ConcurrentDictionary<string, Pqrsdf> _storage = new();

        public async Task<Pqrsdf> CrearAsync(Pqrsdf pqrsdf)
        {
            pqrsdf.Radicado = $"PQRS-{DateTime.UtcNow.Year}-{(_storage.Count + 1).ToString("D3")}";
            pqrsdf.FechaRadicacion = DateTime.UtcNow;
            
            _storage[pqrsdf.Radicado] = pqrsdf;
            return await Task.FromResult(pqrsdf);
        }

        public async Task<Pqrsdf?> ObtenerPorRadicadoAsync(string radicado)
        {
            _storage.TryGetValue(radicado, out var pqrsdf);
            return await Task.FromResult(pqrsdf);
        }
    }
}