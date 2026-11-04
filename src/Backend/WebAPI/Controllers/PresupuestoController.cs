using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PresupuestoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Presupuesto>> GetPresupuesto()
        {
            var presupuestos = new List<Presupuesto>
            {
                new Presupuesto 
                { 
                    Id = 1, 
                    CodigoRubro = "RUB-2026-01", 
                    DescripcionConcepto = "Gastos de Personal y Nómina Institucional", 
                    ValorAprobado = 1500000000m, 
                    ValorEjecutado = 1125000000m, 
                    VigenciaFiscal = 2026 
                },
                new Presupuesto 
                { 
                    Id = 2, 
                    CodigoRubro = "RUB-2026-02", 
                    DescripcionConcepto = "Adquisición de Bienes y Servicios Tecnológicos", 
                    ValorAprobado = 850000000m, 
                    ValorEjecutado = 620000000m, 
                    VigenciaFiscal = 2026 
                },
                new Presupuesto 
                { 
                    Id = 3, 
                    CodigoRubro = "RUB-2026-03", 
                    DescripcionConcepto = "Infraestructura Física y Mantenimiento de Sedes", 
                    ValorAprobado = 400000000m, 
                    ValorEjecutado = 310000000m, 
                    VigenciaFiscal = 2026 
                }
            };

            return Ok(presupuestos);
        }
    }
}