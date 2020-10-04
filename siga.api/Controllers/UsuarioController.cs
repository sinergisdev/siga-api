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
