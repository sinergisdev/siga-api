using Microsoft.AspNetCore.Mvc;
using siga.domain.Services.Area;

namespace siga.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {

        private readonly IAreaService _service;

        public AreaController(IAreaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Obtiene lista de areas por una faena
        /// </summary>
        /// <param name="idFaena">id de faena seleccionada</param>
        /// <returns>retorno lista de areas de una faena</returns>
        /// <response code="200">retorna de lista de areas</response>
        /// <response code="204">No encuentra datos</response>
        [HttpGet("{idFaena}")]
        public IActionResult Get(int idFaena)
        {
            var areas = _service.GetAreas(idFaena);
            if( areas.Count == 0)
            {
                return new NoContentResult();
            }
            return Ok(areas);

        }
    }
}
