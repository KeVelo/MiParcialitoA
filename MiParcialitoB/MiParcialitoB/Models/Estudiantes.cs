namespace MiparcialitoB.Models
{
    public class Estudiantes
    {
        public int EstudianteID { get; set; }  // Clave primaria
        public string Nombre { get; set; }

        // Relación uno a muchos con Inscripciones
        public ICollection<Inscripciones> Inscripcion { get; set; }

    }
}