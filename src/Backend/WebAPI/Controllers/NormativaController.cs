using Microsoft.AspNetCore.Mvc;
using Domain.Entities;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NormativaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Normativa>> GetNormativas()
        {
            var normativas = new List<Normativa>
            {
                new Normativa 
                { 
                    Id = 1, 
                    TipoNorma = "Ley", 
                    NumeroNorma = "1712", 
                    Anio = 2014, 
                    Descripcion = "Ley de Transparencia y del Derecho de Acceso a la Información Pública Nacional.", 
                    EnlaceDocumento = "https://www.funcionpublica.gov.co/eva/gestornormativo/norma.php?i=56882" ,
                    FechaPublicacion = "6 de Marzo de 2014",
                    Titulo = "Ley de Transparencia y Acceso a la Información"
                  
                },
                new Normativa 
                { 
                    Id = 2, 
                    TipoNorma = "Decreto", 
                    NumeroNorma = "1081", 
                    Anio = 2015, 
                    Descripcion = "Decreto Único Reglamentario del Sector Presidencia de la República (Capítulo Transparencia).", 
                    EnlaceDocumento = "https://www.funcionpublica.gov.co/eva/gestornormativo/norma.php?i=62502",
                    FechaPublicacion = "26 de Mayo de 2015",
                    Titulo = "Decreto Único Reglamentario Sector Presidencia"
                },
                new Normativa 
                { 
                    Id = 3, 
                    TipoNorma = "Resolución", 
                    NumeroNorma = "1519", 
                    Anio = 2020, 
                    Descripcion = "Estándares para la publicación de información en portales web institucionales.", 
                    EnlaceDocumento = "https://www.mintic.gov.co",
                    FechaPublicacion = "24 de Agosto de 2020",
                    Titulo = "Estándares de Publicación MinTIC"
                }
            };

            return Ok(normativas);
        }
    }
}