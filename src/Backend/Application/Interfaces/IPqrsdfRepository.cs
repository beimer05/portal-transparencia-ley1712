using PortalTransparencia.Domain.Entities;

namespace PortalTransparencia.Application.Interfaces
{
    public interface IPqrsdfRepository
    {
        Task<Pqrsdf> CrearAsync(Pqrsdf pqrsdf);
        Task<Pqrsdf?> ObtenerPorRadicadoAsync(string radicado);
    }
}