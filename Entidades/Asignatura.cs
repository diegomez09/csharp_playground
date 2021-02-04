using System;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string nombre { get; set; }
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString("N");
        public Asignatura()
        {
        }
    }
}