namespace BiblioDAM.Core.Models
{
    public class Libros
    {
        public String isbn { get; set; }
        public string titulo { get; set; }
        public string fechaPublicacion { get; set; }
        public int idAutor { get; set; }
        public string autorNombre { get; set; }

        public Libros()
        {

        }
    }
}
