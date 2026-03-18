using BiblioDAM.services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BiblioDAM.Data.Models;
using Librobbdd = BiblioDAM.Data.Models.Libro;
using BiblioDAM.Api.Dtos;

namespace BiblioDAM.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibroController : Controller
    {
        private readonly IServiceLibro _IserviceLibro;

        public LibroController(IServiceLibro serviceLibro)
        {
            _IserviceLibro = serviceLibro;
        }


        /// //METODOS GET 

        [HttpGet]
        public ActionResult<List<DtoLibros>> GetLibros()
        {
            var libros = _IserviceLibro.GetLibros();
            var respuesta = libros.Select(l => new DtoLibros // equivale a recorrer con buclre foreach
            {
                Isbn = l.Isbn,
                Titulo = l.Titulo,
                Fecha = l.FechaPublicacion,
                Autor = l.IdAutorNavigation.Nombre // para acceder al nombre atraves del Id

            }).ToList();
            return Ok(respuesta);

        }

        [HttpGet("Autor/{autor}")]
        public ActionResult<List<DtoLibros>> GetLibroByAutor(string autor)
        {
            var libros = _IserviceLibro.GetLibrosByAutor(autor);
            if (libros.Count == 0) { return NotFound(); }

            var respuesta = libros.Select(l => new DtoLibros
            {
                Isbn = l.Isbn,
                Titulo = l.Titulo,
                Fecha = l.FechaPublicacion,
                Autor = l.IdAutorNavigation.Nombre
            }).ToList();
            return Ok(respuesta);

        }

        [HttpGet("Titulo/{titulo}")]
        public ActionResult<List<DtoLibros>> GetLibroByTitulo(string titulo)
        {
            var libro = _IserviceLibro.GetLibrosByTitulo(titulo);
            if (libro.Count == 0) { return NotFound(); }

            var respuesta = libro.Select(l => new DtoLibros
            {
                Isbn = l.Isbn,
                Titulo = l.Titulo,
                Fecha = l.FechaPublicacion,
                Autor = l.IdAutorNavigation.Nombre
            }).ToList();
            return Ok(respuesta);
        }

        [HttpGet("Isbn/{isbn}")]

        public ActionResult<DtoLibros> GetLibrobyIsbn(string isbn)
        {
            var libro = _IserviceLibro.GetLibrosIsbn(isbn);
            if (libro == null) { return NotFound(); }

            var respuesta = new DtoLibros
            {
                Isbn = libro.Isbn,
                Titulo = libro.Titulo,
                Fecha = libro.FechaPublicacion,
                Autor = libro.IdAutorNavigation.Nombre

            };
            return Ok(respuesta);


        }
        [HttpGet("Testear/")]
        public ActionResult<string> Testear()
        {
            bool inteto=_IserviceLibro.TestearConexion();
            if (!inteto)
            {
                return BadRequest("No se ha podido conectar a la base de datos");
            }
            return Ok("Funciona");
        }

        ////////// METODOS POST
        [HttpPost]

        public ActionResult AddLibro(DtoLibros dto)
        {
            var libros = new Libro
            {
                Isbn = dto.Isbn,
                Titulo = dto.Titulo,
                FechaPublicacion = dto.Fecha,


            };

            var agregar = _IserviceLibro.AddLibro(libros, dto.Autor); // no puedo darle valor a la propiedad al crear un libro

            if (!agregar.condicion)
            {
                return BadRequest(agregar.message);
            }
            return Ok(agregar.message);

        }

        //// metodos delete 
        /// <s


        [HttpDelete]
        public ActionResult DeleteLibro(string isbn)
        {
            var eliminar = _IserviceLibro.EliminarLibro(isbn);
            if (eliminar <= 0)
            {
                return BadRequest("No se pudo eliminar el libro");
            }
            return Ok("Libro Eliminado");


        }
    }
}
