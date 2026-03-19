  
    using BiblioDAM.Data.Models;
    using BiblioDAM.services.Interfaces;
using Microsoft.EntityFrameworkCore;
    using Librobbdd = BiblioDAM.Data.Models.Libro;

    namespace BiblioDAM.services
    {
        public class ServiceLibro : IServiceLibro
        {
            public BibliotecaDamContext _bbdd;
            public ServiceLibro(BibliotecaDamContext bbdd) 
            {
                _bbdd = bbdd; 
            }
            public (bool condicion, string message) AddLibro(Librobbdd libro, string autor)
            {
                if(_bbdd.Libros.Find(libro.Isbn) != null)
            
                {
                    return (false, "El libro ya existe con ese ISBN");

                }
                if (_bbdd.Autores.FirstOrDefault(a => a.Nombre == autor) == null) 
                {
                    Autore anhadido=new Autore();
                    anhadido.Nombre = autor;
                    _bbdd.Autores.Add(anhadido);
                    _bbdd.SaveChanges();
            
                }
                var escritor = _bbdd.Autores.FirstOrDefault((a => a.Nombre == autor)); // ??  se debe poder  optimizar y hacer la consulta arriba y utilizar para todo
                if (escritor != null)
                {
                    libro.IdAutor = escritor.IdAutor;
                libro.IdAutorNavigation = escritor;
                }
               _bbdd.Add(libro);
                int verificacion = _bbdd.SaveChanges();

                return verificacion > 0 ? (true, "Guardado correctamente") : (false, "No se ha podido guardar");


            }

            public int EliminarLibro(string isbn)
            {
                var libro = _bbdd.Libros.Find(isbn);
                if(libro!=null )
                {
                    _bbdd.Libros.Remove(libro);
                    _bbdd.SaveChanges();
                    return 1;
                }
                return 0;
            }

            public List<Librobbdd> GetLibros()
            {
                return  _bbdd.Libros.Include(l=>l.IdAutorNavigation).ToList();
            }

            public List<Librobbdd> GetLibrosByAutor(string nombre)
            {
                var  autor  = _bbdd.Autores .FirstOrDefault(a=>a.Nombre==nombre); //
               ;
                 if (autor==null)
                  {
                    return new List<Librobbdd>();

                  }
                 var libros = _bbdd.Libros
                .Include(l => l.IdAutorNavigation)
                .Where(l=>l.IdAutor==autor.IdAutor).ToList();
                return libros;
             
            }

            public List<Librobbdd> GetLibrosByTitulo(string nombre)
            {
               var libro = _bbdd.Libros
                .Include(l => l.IdAutorNavigation)
                .Where(l=>l.Titulo==nombre).ToList();
                return libro;
            
            }

            public Librobbdd GetLibrosIsbn(string isbn)
            {
                var libro = _bbdd.Libros
                .Include(l => l.IdAutorNavigation)
                .FirstOrDefault(l => l.Isbn == isbn);
                return libro;
            }

            public bool TestearConexion()
            {
                return _bbdd.Database.CanConnect();
            }
        }
    }
