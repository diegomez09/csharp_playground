using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }
        public void Inicializar()
        {
            Escuela = new Escuela("Escuela C#", 1998, TipoEscuela.Primaria,
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
            Escuela.Cursos = listaCursos;
            // escuela.nombre = "Escuela Dos";

            Escuela.Pais = "Mexico";
        }
    }

}