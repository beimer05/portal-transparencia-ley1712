namespace Domain.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string Dependencia { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string EscalaSalarial { get; set; } = string.Empty;
        public string FotoUrl { get; set; } = string.Empty;
    }
}