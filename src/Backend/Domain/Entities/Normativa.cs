namespace Domain.Entities
{
    public class Normativa
    {
        public int Id { get; set; }
        public string TipoNorma { get; set; } = string.Empty; // Ley, Decreto, Resolución, etc.
        public string NumeroNorma { get; set; } = string.Empty;
        public int Anio { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public string EnlaceDocumento { get; set; } = string.Empty;
        // Nuevas propiedades requeridas por la vista del Home
        public string FechaPublicacion { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
    }
}