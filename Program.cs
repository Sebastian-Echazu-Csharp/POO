using System;
using System.Collections.Generic;
using Herencia;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de clases");

            List<Persona> Personas = new List<Persona>();

            Personas.Add(new Profesor("Programacion","Sebastian","Echazu"));
            Personas.Add(new Alumno("5to C","Juan","Perez"));
            Personas.Add(new Alumno("5to C","Pedro","Gonzales"));

            foreach (var persona in Personas)
            {
                persona.EstaEnClase();
            }
        }
    }
}
