﻿using System;
using CoreEscuela.Entidades;

namespace etapaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Escuela C#",1998);
            // escuela.nombre = "Escuela Dos";
            escuela.Pais="Mexico";
            Console.WriteLine(escuela.Nombre);
        }
    }
}