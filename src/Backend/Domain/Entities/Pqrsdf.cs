namespace PortalTransparencia.Domain.Entities
{
    public class Pqrsdf
    {
        public int Id { get; set; }
        public string Radicado { get; set; } = string.Empty;
        public string TipoSolicitud { get; set; } = string.Empty; // Peticion, Queja, Reclamo, etc.
        public string NombreSolicitante { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public string Asunto { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Estado { get; set; } = "Radicado"; // Radicado, En Proceso, Respondido
        public DateTime FechaRadicacion { get; set; } = DateTime.UtcNow;
    }
}