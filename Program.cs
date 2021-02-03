using System;
using CoreEscuela.Entidades;

namespace etapaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Escuela C#", 1998, TipoEscuela.Primaria,
            ciudad: "Guadalajara");
            var arregloCursos = new Curso[3];
            //Varios objetos nuevos
            arregloCursos[0] = new Curso()
            {
                Nombre = "101"
            };
            arregloCursos[1] = new Curso()
            {
                Nombre = "201"
            };
            arregloCursos[2] = new Curso()
            {
                Nombre = "301"
            };
            escuela.Cursos = arregloCursos;
            // escuela.nombre = "Escuela Dos";
            escuela.Pais = "Mexico";
            // escuela.Ciudad="Guadalajara";
            //escuela.TipoEscuela=TipoEscuela.Primaria;
            Console.WriteLine(escuela);
            ImprimirCursosEscuela(escuela);
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                foreach (Curso i in escuela.Cursos)
                {
                    System.Console.WriteLine("====================");
                    Console.WriteLine(i.UniqueId, i.Nombre);
                }
            }
            else
            {
                return;
            }
        }
    }
}
