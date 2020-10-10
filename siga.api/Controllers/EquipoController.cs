using Microsoft.AspNetCore.Mvc;
using siga.domain.Services.Equipo;

namespace siga.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {

        private readonly IEquipoService _service;

        public EquipoController(IEquipoService service)
        {
            _service = service;
        }

        /// <summary>
        /// Obtiene lista de equipos por faena y tipo
        /// </summary>
        /// <param name="idArea">id de area seleccionada</param>
        /// /// <param name="idTipoEquipo">tipos de equipos a listar</param>
        /// <returns>retorno lista de equipos</returns>
        /// <response code="200">retorna de lista de equipos</response>
        /// <response code="204">No encuentra datos</response>
        [HttpGet("{idArea}/{idTipoEquipo}")]
        public IActionResult Get(int idArea, int idTipoEquipo)
        {
            var equipos = _service.GetEquipos(idArea, idTipoEquipo);
            if (equipos.Count == 0)
            {
                return new NoContentResult();
            }
            return Ok(equipos);

        }

    }
}
