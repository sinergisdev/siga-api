using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using siga.domain.Services;
using siga.viewModel;

namespace siga.api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
     
        private readonly IUsuarioService _service;

        public UsuarioController ( IUsuarioService service)
        {
            _service = service;
        }

        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <param name="item"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response> 
        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById( int id )
        {
            var usuario = _service.GetById(id);
            if (usuario == null)
                return NotFound();
            else
                return Ok(usuario);
            
        }

    }
}
