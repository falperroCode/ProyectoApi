    using BiblioDAM.Data.Models;
    using BiblioDAM.services.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    namespace BiblioDAM.services
    {
        public class ServiceAutores : IServiceAutores
        {
            public readonly BibliotecaDamContext _bbdd;
            public ServiceAutores(BibliotecaDamContext bbdd ) 
            { 
                _bbdd= bbdd;
            } 
            public (bool condicion, string message) AddAutor(Autore autor)
            {
                foreach (var a in _bbdd.Autores)
                {
                    if (a.Nombre.Trim() ==autor.Nombre.Trim())
                    {
                        return (false, "el autor ya existe");
                    }
                }
            
                _bbdd.Add(autor);
                _bbdd.SaveChanges();

                return (true,"Autor añadido correctamente");
            
            
            }

            public Autore GetAutor(string nombre)
            {
                var autor = _bbdd.Autores.FirstOrDefault(a => a.Nombre == nombre);
                if (autor != null) return autor;
                return null;
            
            }

            public string getNommbre(int id)
            {
            
                 var autor  = _bbdd.Autores.Find(id);
                if(autor != null)
                {
                    return autor.Nombre;
                }
                return "No se encontro el autor";
            }
        
       
        }

    
    }
