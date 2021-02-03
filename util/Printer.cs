using System;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void dibujarLinea(int tam = 10)
        {
            var linea = "".PadRight(tam, '=');
            System.Console.WriteLine(linea);
        }

        public static void dibujarTitulo(string titulo,int tam = 10)
        {
            dibujarLinea(titulo.Length);
            Console.WriteLine(titulo);
            dibujarLinea(titulo.Length);
        }
    }
}