using System;
using CoreEscuela.Entidades;

namespace etapaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Escuela C#",1998,TipoEscuela.Primaria,
            ciudad:"Guadalajara");
            // escuela.nombre = "Escuela Dos";
            // escuela.Pais="Mexico";
            // escuela.Ciudad="Guadalajara";
            //escuela.TipoEscuela=TipoEscuela.Primaria;
            Console.WriteLine(escuela);
        }
    }
}
