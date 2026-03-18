using BiblioDAM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librobbdd = BiblioDAM.Data.Models.Libro; // creo un alias para disternir de las dos capas,me lo anoto para futuro diferenciar nombres

namespace BiblioDAM.services.Interfaces
{
    public interface IServiceLibro
    {

        public (bool condicion, String message) AddLibro(Librobbdd libro, string autor);
        public Librobbdd GetLibrosIsbn(String isbn);
        public List<Librobbdd> GetLibros();
        public List<Librobbdd> GetLibrosByAutor(String nombre);
        public List<Librobbdd> GetLibrosByTitulo(String nombre);
        public int EliminarLibro(String isbn);
        public bool TestearConexion();
    }
}
