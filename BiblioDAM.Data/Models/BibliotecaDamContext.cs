using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BiblioDAM.Data.Models;

public partial class BibliotecaDamContext : DbContext
{
    public BibliotecaDamContext()
    {
    }

    public BibliotecaDamContext(DbContextOptions<BibliotecaDamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autore> Autores { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-B36FG5KJ;Database=BibliotecaDAM;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autore>(entity =>
        {
            entity.HasKey(e => e.IdAutor).HasName("PK__Autores__9AE8206AE56EF6EF");

            entity.Property(e => e.IdAutor).HasColumnName("idAutor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__Libros__99F9D0A51043E641");

            entity.Property(e => e.Isbn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("isbn");
            entity.Property(e => e.FechaPublicacion)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("fechaPublicacion");
            entity.Property(e => e.IdAutor).HasColumnName("idAutor");
            entity.Property(e => e.Titulo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("titulo");

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdAutor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Libros__idAutor__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
