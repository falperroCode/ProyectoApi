using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioDAM.Core.Models
{
    public class Autores

    {
        public int id { get; set; }
        public string nombre { get; set; }
        public  List<Libros>? listaLibros { get; set; }


        public Autores()
        {
            
        }   
    }
}
