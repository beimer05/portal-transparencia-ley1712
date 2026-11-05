using Microsoft.AspNetCore.Mvc;
using PortalTransparencia.Domain.Entities;

namespace PortalTransparencia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatosAbiertosController : ControllerBase
    {
        // Lista estática simulada de datasets institucionales (puedes migrarla a SQLite fácilmente)
        private static readonly List<DatasetPublico> _datasets = new()
        {
            new DatasetPublico { Id = 1, Titulo = "Contratos Suscritos 2026", Descripcion = "Detalle completo de contratación pública bajo Ley 1712.", Categoria = "Contratación", Formato = "CSV", UrlDescarga = "/api/datosabiertos/descargar/contratos-2026.csv" },
            new DatasetPublico { Id = 2, Titulo = "Ejecución Presupuestal Vigencia Actual", Descripcion = "Informe de apropiaciones, compromisos y pagos.", Categoria = "Presupuesto", Formato = "JSON", UrlDescarga = "/api/datosabiertos/descargar/presupuesto-2026.json" },
            new DatasetPublico { Id = 3, Titulo = "Nómina y Talento Humano", Descripcion = "Escala salarial, directivos y personal de planta.", Categoria = "Talento Humano", Formato = "CSV", UrlDescarga = "/api/datosabiertos/descargar/nomina-2026.csv" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<DatasetPublico>> ObtenerDatasets()
        {
            return Ok(_datasets);
        }

        [HttpGet("descargar/{nombreArchivo}")]
        public IActionResult DescargarDataset(string nombreArchivo)
        {
            // Simulación de descarga de archivo en formato abierto
            var contenidoSimulado = "Id,Entidad,Valor,Fecha\n1,Contrato 001,15000000,2026-01-15\n2,Contrato 002,32000000,2026-02-10";
            var bytes = System.Text.Encoding.UTF8.GetBytes(contenidoSimulado);
            
            return File(bytes, "text/csv", nombreArchivo);
        }
    }
}