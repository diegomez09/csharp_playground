namespace CoreEscuela.Entidades
{
    class Escuela
    {
        //Defino la propiedad
        // string nombre;
        //Encapsulamiento de nombre añadiendo get y set
        public string Nombre { get; set; }
        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        //Constructor básico
        // public Escuela(string nombre, int añoCreacion)
        // {
        //     this.nombre = nombre;
        //     this.añoCreacion = añoCreacion;
        // }

        public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);
    }
}