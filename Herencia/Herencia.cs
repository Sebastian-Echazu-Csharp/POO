using System;

namespace Herencia
{
    class Persona

    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        public virtual void EstaEnClase()
        {
            Console.WriteLine(nombre + " " + apellido + " se encuentra en clase");
        }

    }

    class Alumno : Persona
    {
        public string grado { get; set; }
        public Alumno(string grado, string nombre, string apellido)
        {
            this.grado = grado;
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }

    class Profesor : Persona
    {
        public string materia { get; set; }
        public Profesor(string materia, string nombre, string apellido)
        {
            this.materia = materia;
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }

}