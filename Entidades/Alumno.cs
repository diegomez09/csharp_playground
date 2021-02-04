using System;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string nombre { get; set; }
        public string UniqueId { get; private set; }
        public Alumno()
        {
            UniqueId = Guid.NewGuid().ToString("N");
        }
    }
}