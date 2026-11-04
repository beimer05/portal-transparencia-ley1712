using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Funcionario>> GetFuncionarios()
        {
            var funcionarios = new List<Funcionario>
            {
                new Funcionario
                {
                    Id = 1,
                    NombreCompleto = "Carlos Alberto Mendoza",
                    Cargo = "Director General",
                    Dependencia = "Despacho de la Dirección",
                    Correo = "direccion@entidad.gov.co",
                    Telefono = "+57 (601) 555-0101",
                    EscalaSalarial = "Grado 05 - $12,500,000 COP",
                    FotoUrl = "https://images.unsplash.com/photo-1560250097-0b93528c311a?auto=format&fit=crop&q=80&w=200"
                },
                new Funcionario
                {
                    Id = 2,
                    NombreCompleto = "Ana María Gutiérrez",
                    Cargo = "Jefe de Tecnologías de la Información",
                    Dependencia = "Oficina de TIC",
                    Correo = "sistemas@entidad.gov.co",
                    Telefono = "+57 (601) 555-0102",
                    EscalaSalarial = "Grado 03 - $8,900,000 COP",
                    FotoUrl = "https://images.unsplash.com/photo-1573496359142-b8d87734a5a2?auto=format&fit=crop&q=80&w=200"
                },
                new Funcionario
                {
                    Id = 3,
                    NombreCompleto = "Roberto Silva Orozco",
                    Cargo = "Coordinador Financiero y Presupuesto",
                    Dependencia = "Dirección Financiera",
                    Correo = "financiera@entidad.gov.co",
                    Telefono = "+57 (601) 555-0103",
                    EscalaSalarial = "Grado 02 - $6,400,000 COP",
                    FotoUrl = "https://images.unsplash.com/photo-1519085360753-af0119f7cbe7?auto=format&fit=crop&q=80&w=200"
                }
            };

            return Ok(funcionarios);
        }
    }
}