namespace PortalTransparencia.Domain.Entities
{
    public class DatasetPublico
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty; // Contratación, Presupuesto, Talento Humano
        public string Formato { get; set; } = "CSV";
        public string UrlDescarga { get; set; } = string.Empty;
        public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
    }
}