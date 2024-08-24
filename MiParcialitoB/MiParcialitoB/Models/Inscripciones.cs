namespace MiparcialitoB.Models
{
    public class Inscripciones
    {
        public int EstudianteID { get; set; }  // Clave primaria y extranjera
        public int CursoID { get; set; }       // Clave primaria y extranjera

        // Relaciones
        public Estudiantes Estudiante { get; set; }  // Relación con la clase Estudiante
        public Cursos Curso { get; set; }            // Relación con la clase Curso

    }
}