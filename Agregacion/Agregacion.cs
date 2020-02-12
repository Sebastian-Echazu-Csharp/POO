using System;
using System.Collections.Generic;
using System.Text;

namespace Agregacion
{
    class Edificio
    {
        private string Direccion { get; set; }
        private int Pisos { get; set; }

        public Edificio(string Direccion, int Pisos)
        {
            this.Direccion = Direccion;
            this.Pisos = Pisos;

        }
        public void Muestra()
        {
            Console.WriteLine("El edificio se encuentra en {0} y tiene {1} pisos", Direccion, Pisos);

        }
    }

    class Propietario
    {

        private string Nombre { get; set; }

        private Edificio edificio = null;

        public Propietario(string nombre)
        {
            this.Nombre = nombre;
        }

        public void MuestraPropiedad()
        {
            if (edificio != null)
            {
                Console.Write("{0} tiene ", Nombre);
                edificio.Muestra();
            }
            else
            {
                Console.WriteLine("{0} aun no tiene propiedades ", Nombre);
            }

        }
        public void AdicionaEdificio(Edificio edificio)
        {
            if (edificio != null)
            {
                this.edificio = edificio;

            }
        }

    }
}
