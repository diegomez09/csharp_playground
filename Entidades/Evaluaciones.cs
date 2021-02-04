using System;

namespace CoreEscuela.Entidades
{
    public class Evaluaciones
    {
        public string nombre { get; set; }
        public string UniqueId { get; private set; }
        public Alumno alumno { get; set; }
        public Asignatura asignatura { get; set; }
        public float calificacion { get; set; }
        Evaluaciones()
        {
            UniqueId = Guid.NewGuid().ToString("N");
        }
    }
}