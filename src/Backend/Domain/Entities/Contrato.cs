namespace Domain.Entities;

public class Contrato
{
    public int Id { get; set; }
    public string NumeroContrato { get; set; } = string.Empty;
    public string Objeto { get; set; } = string.Empty;
    public string Contratista { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public DateTime FechaAdjudicacion { get; set; }
    public string UrlDocumento { get; set; } = string.Empty;
}