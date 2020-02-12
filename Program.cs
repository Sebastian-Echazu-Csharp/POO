using System;
using System.Collections.Generic;
using Agregacion;
using Herencia;


namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de Programacion Orientada a Objetos");

            //-------------------------------------------------------------------------------------
            //HERENCIA
            //-------------------------------------------------------------------------------------
            //Creaos una lista de personas
            List<Persona> Personas = new List<Persona>();
            //a esa lista de personas le agregamos alumnos y clases
            Personas.Add(new Profesor("Programacion", "Sebastian", "Echazu"));
            Personas.Add(new Alumno("5to C", "Juan", "Perez"));
            Personas.Add(new Alumno("5to C", "Pedro", "Gonzales"));
            //iteramos en la lista de persona mostrando la informacion
            foreach (var persona in Personas)
            {
                persona.EstaEnClase();
            }
            //-------------------------------------------------------------------------------------
            //AGREGACION
            //-------------------------------------------------------------------------------------
            //creamos un edificio
            Edificio ed = new Edificio("San martin 844", 8);
            //creamos un propietario
            Propietario pro = new Propietario("sebastian");
            //mostramos el la propiedades del edicifio
            pro.MuestraPropiedad();
            //agregamos la propiedad al propietario
            pro.AdicionaEdificio(ed);
            //mostramos las propiedades del propietario
            pro.MuestraPropiedad();



        }
    }
}
