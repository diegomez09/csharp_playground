namespace CoreEscuela.Entidades
{
    class Escuela
    {
        //Defino la propiedad
        string nombre;
        //Encapsulamiento de nombre añadiendo get y set
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }
        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TipoEscuela TipoEscuela { get; set; }
        public Curso[] Cursos { get; set; }
        //Constructor básico
        public Escuela(string nombre,
         int añoCreacion,
          TipoEscuela tipo,
           string pais = "",
            string ciudad = "")
        {
            (Nombre, AñoCreacion) = (nombre, añoCreacion);
            Pais = pais;
            Ciudad = ciudad;
        }

        public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}