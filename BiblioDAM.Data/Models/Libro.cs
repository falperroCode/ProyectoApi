using System;
using System.Collections.Generic;

namespace BiblioDAM.Data.Models;

public partial class Libro
{
    public string Isbn { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public int IdAutor { get; set; }

    public string? FechaPublicacion { get; set; }

    public virtual Autore IdAutorNavigation { get; set; } = null!;
}
