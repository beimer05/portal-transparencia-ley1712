namespace Domain.Entities
{
    public class Presupuesto
    {
        public int Id { get; set; }
        public string CodigoRubro { get; set; } = string.Empty;
        public string DescripcionConcepto { get; set; } = string.Empty;
        public decimal ValorAprobado { get; set; }
        public decimal ValorEjecutado { get; set; }
        public int VigenciaFiscal { get; set; }
    }
}