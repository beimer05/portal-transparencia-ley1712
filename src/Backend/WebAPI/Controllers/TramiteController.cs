using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TramiteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Tramite>> GetTramites()
        {
            var tramites = new List<Tramite>
            {
                new Tramite
                {
                    Id = 1,
                    Nombre = "Expedición de Certificado de Residencia",
                    Descripción = "Solicitud oficial para la expedición del certificado que acredita la residencia del ciudadano en el municipio.",
                    Requisitos = "Cédula de ciudadanía escaneada, recibo de servicio público reciente.",
                    TiempoRespuesta = "3 días hábiles",
                    Costo = "Gratuito",
                    Modalidad = "En línea",
                    EnlaceTramite = "https://tramites.entidad.gov.co/residencia"
                },
                new Tramite
                {
                    Id = 2,
                    Nombre = "Licencia de Intervención de Espacio Público",
                    Descripción = "Permiso otorgado para la ocupación o intervención temporal del espacio público municipal.",
                    Requisitos = "Formulario único de solicitud, planimetría del área a intervenir, paz y salvo municipal.",
                    TiempoRespuesta = "15 días hábiles",
                    Costo = "$145,000 COP",
                    Modalidad = "Mixto",
                    EnlaceTramite = "https://tramites.entidad.gov.co/espacio-publico"
                },
                new Tramite
                {
                    Id = 3,
                    Nombre = "Concepto Uso de Suelo",
                    Descripción = "Dictamen escrito sobre la aptitud del uso del suelo para el desarrollo de actividades comerciales o urbanísticas.",
                    Requisitos = "Certificado de libertad y tradición, copia de cédula del propietario, matrícula inmobiliaria.",
                    TiempoRespuesta = "10 días hábiles",
                    Costo = "Gratuito",
                    Modalidad = "Presencial",
                    EnlaceTramite = ""
                }
            };

            return Ok(tramites);
        }
    }
}