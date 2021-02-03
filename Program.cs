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
            escuela.Cursos.Add(new Curso(){ Nombre="102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso(){ Nombre="202", Jornada = TiposJornada.Tarde });
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
                    Console.WriteLine(i.UniqueId+ ", "+ i.Nombre);
                }
            }
            else
            {
                return;
            }
        }
    }
}
