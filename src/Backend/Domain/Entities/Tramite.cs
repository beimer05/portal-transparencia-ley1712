namespace Domain.Entities
{
    public class Tramite
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripción { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public string TiempoRespuesta { get; set; } = string.Empty;
        public string Costo { get; set; } = string.Empty;
        public string Modalidad { get; set; } = string.Empty; // En línea, Presencial, Mixto
        public string EnlaceTramite { get; set; } = string.Empty;
    }
}