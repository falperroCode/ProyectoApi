using BiblioDAM.Data.Models;
namespace BiblioDAM.Api.Dtos
{
    public class DtoLibros
    {
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Fecha { get; set; }
        public string Autor { get; set; }

    }
}
