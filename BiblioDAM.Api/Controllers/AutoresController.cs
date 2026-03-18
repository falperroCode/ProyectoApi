using Microsoft.AspNetCore.Mvc;
using BiblioDAM.services.Interfaces;
using BiblioDAM.Data.Models;
using BiblioDAM.Api.Dtos;

namespace BiblioDAM.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AutoresController : Controller
    {
        private readonly IServiceAutores _serviceAutores;
        public AutoresController(IServiceAutores serviceAutores)
        {
            _serviceAutores = serviceAutores;

        }
        [HttpGet]

        public ActionResult<DtoLibros> GetAutores(string autor)
        {
            var resultado = _serviceAutores.GetAutor(autor);
            if (resultado == null)
            {
                return BadRequest(resultado);
            }
            return Ok(resultado);
        }


        [HttpPost]
        public ActionResult AddAutor([FromBody]DtoAutores dto)
        {
            var autor = new Autore { Nombre = dto.nombre };
            var resultado = _serviceAutores.AddAutor(autor);
            if (!resultado.condicion)
            {
                return BadRequest(resultado.message);
            }
            return Ok(resultado.message);



        }


    }
}
