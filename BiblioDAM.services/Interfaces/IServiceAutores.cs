using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioDAM.Core.Models;
using BiblioDAM.Data.Models;

namespace BiblioDAM.services.Interfaces
{
    public interface IServiceAutores
    {

        public (bool condicion, String message) AddAutor(Autore autor);
        public Autore GetAutor(String nombre);
        public String getNommbre(int id);
    }
}
