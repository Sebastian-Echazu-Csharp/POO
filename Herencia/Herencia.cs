using System;

namespace Herencia
{
    class Persona

    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //se le agrega virtual al metodo para que las clases hijos puedad heredar y sobre escribir
        public virtual void EstaEnClase()
        {
            Console.WriteLine(Nombre + " " + Apellido + " se encuentra en clase");
        }

    }

    class Alumno : Persona
    {
        public string grado { get; set; }
        public Alumno(string grado, string nombre, string apellido)
        {
            this.grado = grado;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        //utiliza el metodo EstaEnClase que hereda de la clase base

    }

    class Profesor : Persona
    {
        public string materia { get; set; }
        public Profesor(string materia, string nombre, string apellido)
        {
            this.materia = materia;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public override void EstaEnClase()
        {
            Console.WriteLine(Nombre + " " + Apellido + " se encuentra en clase y es profesor");

        }

    }

}