using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.dibujarTitulo(engine.Escuela.Nombre);
            ImprimirCursosEscuela(engine.Escuela);
            // engine.Cursos.RemoveAll((Predicate) => Predicate.Nombre == "301");
            // Console.WriteLine("\nDESPUES\n");
            // engine.Cursos.Remove(tmp);
            // ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                foreach (Curso i in escuela.Cursos)
                {
                    Printer.dibujarLinea(20);
                    Console.WriteLine(i.UniqueId + ", " + i.Nombre);
                }
            }
            else
            {
                return;
            }
        }
    }
}
