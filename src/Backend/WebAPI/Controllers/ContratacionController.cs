using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

[Route("api/contratacion")]
[ApiController]
public class ContratacionController : ControllerBase
{
    [HttpGet("contratos")]
    public ActionResult<IEnumerable<Contrato>> GetContratos()
    {
        var contratos = new List<Contrato>
        {
            new Contrato 
            { 
                Id = 1, 
                NumeroContrato = "CO-2026-001", 
                Objeto = "Adquisición de licencias de software para la plataforma institucional", 
                Contratista = "TechSolutions S.A.S.", 
                Valor = 45000000, 
                FechaAdjudicacion = new DateTime(2026, 2, 15), 
                UrlDocumento = "#" 
            },
            new Contrato 
            { 
                Id = 2, 
                NumeroContrato = "CO-2026-002", 
                Objeto = "Mantenimiento preventivo y correctivo de infraestructura tecnológica", 
                Contratista = "Sistemas & Redes Ltda.", 
                Valor = 28000000, 
                FechaAdjudicacion = new DateTime(2026, 4, 10), 
                UrlDocumento = "#" 
            }
        };

        return Ok(contratos);
    }
}