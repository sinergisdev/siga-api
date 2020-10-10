using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using siga.domain.Services.Area;
using siga.domain.Services.Faena;

namespace siga.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    
    public class FaenaController : ControllerBase
    {

        private readonly IFaenaService _service;

        public FaenaController(IFaenaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Obtiene lista faena vigentes
        /// </summary>
        /// <returns>retorno lista de faenas con estado='V'</returns>
        /// <response code="200">retorna de lista de faenas</response>
        /// <response code="400">No encuentra datos</response> 
        [HttpGet("Get")]
        public IActionResult Get()
        {
            var faenas = _service.GetFaenas();
            //var usuario = _service.GetById(id);
            //if (usuario == null)
            //    return NotFound();
            //else
            //    return Ok(usuario);

            return Ok(faenas);

        }



    }
}
