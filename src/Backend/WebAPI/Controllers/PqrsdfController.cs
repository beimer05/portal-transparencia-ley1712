using Microsoft.AspNetCore.Mvc;
using PortalTransparencia.Application.DTOs;
using PortalTransparencia.Application.Interfaces;
using PortalTransparencia.Domain.Entities;

namespace PortalTransparencia.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PqrsdfController : ControllerBase
    {
        private readonly IPqrsdfRepository _pqrsdfRepository;

        public PqrsdfController(IPqrsdfRepository pqrsdfRepository)
        {
            _pqrsdfRepository = pqrsdfRepository;
        }

        [HttpPost]
        public async Task<ActionResult<PqrsdfResponseDto>> Radicar([FromBody] CrearPqrsdfDto dto)
        {
            var entity = new Pqrsdf
            {
                TipoSolicitud = dto.TipoSolicitud,
                NombreSolicitante = dto.NombreSolicitante,
                Email = dto.Email,
                Telefono = dto.Telefono,
                Asunto = dto.Asunto,
                Descripcion = dto.Descripcion
            };

            var resultado = await _pqrsdfRepository.CrearAsync(entity);

            var response = new PqrsdfResponseDto(
                Radicado: resultado.Radicado,
                FechaRadicacion: resultado.FechaRadicacion.ToString("yyyy-MM-dd HH:mm:ss"),
                Mensaje: "Su solicitud ha sido radicada exitosamente y asignada para trámite institucional.",
                Estado: resultado.Estado
            );

            return Ok(response);
        }

        [HttpGet("{radicado}")]
        public async Task<ActionResult<PqrsdfResponseDto>> Consultar(string radicado)
        {
            var entity = await _pqrsdfRepository.ObtenerPorRadicadoAsync(radicado);

            if (entity == null)
            {
                return NotFound(new { mensaje = "No se encontró el número de radicado." });
            }

            var response = new PqrsdfResponseDto(
                Radicado: entity.Radicado,
                FechaRadicacion: entity.FechaRadicacion.ToString("yyyy-MM-dd HH:mm:ss"),
                Mensaje: "Consulta de estado exitosa.",
                Estado: entity.Estado
            );

            return Ok(response);
        }
    }
}