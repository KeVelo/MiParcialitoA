namespace MiparcialitoB.Models
{
    public class Cursos
    {

        public int CursoID { get; set; }  // Clave primaria
        public string NombreCurso { get; set; }

        // Relación uno a muchos con Inscripciones
        public ICollection<Inscripciones> Inscripcion { get; set; }
    }
}