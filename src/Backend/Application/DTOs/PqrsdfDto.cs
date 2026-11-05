namespace PortalTransparencia.Application.DTOs
{
    public record CrearPqrsdfDto(
        string TipoSolicitud,
        string NombreSolicitante,
        string Email,
        string? Telefono,
        string Asunto,
        string Descripcion
    );

    public record PqrsdfResponseDto(
        string Radicado,
        string FechaRadicacion,
        string Mensaje,
        string Estado
    );
}