using Microsoft.EntityFrameworkCore;
using MiparcialitoB.Models;

namespace MiParcialitoB.Models
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=qa.negociostecnologicos.net;Database=mg101121;User Id=desarrolloWebUfg;Password=<BTj$jrrLV2~-4Yp1vT-;Port=3306;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inscripciones>()
                .HasKey(i => new { i.EstudianteID, i.CursoID });

            modelBuilder.Entity<Inscripciones>()
                .HasOne(i => i.Estudiante)
                .WithMany(e => e.Inscripcion)
                .HasForeignKey(i => i.EstudianteID);

            modelBuilder.Entity<Inscripciones>()
                .HasOne(i => i.Curso)
                .WithMany(c => c.Inscripcion)
                .HasForeignKey(i => i.CursoID);

            modelBuilder.Entity<Cursos>()
                .HasKey(c => c.CursoID);

            modelBuilder.Entity<Estudiantes>()
                .HasKey(e => e.EstudianteID);
        }

        public DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<Inscripciones> Inscripcion { get; set; }
        public DbSet<Cursos> Curso { get; set; }
    }
}