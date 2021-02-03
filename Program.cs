using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace etapaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Escuela C#", 1998, TipoEscuela.Primaria,
            ciudad: "Guadalajara");
            //Declaracion arreglo
            //var arregloCursos = new Curso[3];
            //Varios objetos nuevos
            var listaCursos = new List<Curso>(){
                new Curso()
            {
                Nombre = "101"
            },
            new Curso()
            {
                Nombre = "201"
            },
            new Curso()
            {
                Nombre = "301"
            }
            };
            escuela.Cursos = listaCursos;
            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });
            // escuela.nombre = "Escuela Dos";

            escuela.Pais = "Mexico";

            Curso tmp = new Curso
            {
                Nombre = "Verano",
                Jornada = TiposJornada.Noche
            };

            escuela.Cursos.Add(tmp);

            Console.WriteLine(escuela);
            ImprimirCursosEscuela(escuela);
            escuela.Cursos.RemoveAll((Predicate) => Predicate.Nombre == "301");
            Console.WriteLine("\nDESPUES\n");
            escuela.Cursos.Remove(tmp);
            ImprimirCursosEscuela(escuela);
        }

        // private static bool Predicate(Curso obj)
        // {
        //     return obj.Nombre == "301";
        // }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            if (escuela?.Cursos != null)
            {
                foreach (Curso i in escuela.Cursos)
                {
                    System.Console.WriteLine("====================");
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
