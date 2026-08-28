using System;
using System.Collections.Generic;
using System.Text;

namespace RefugioAnimales.src
{
    public class GatoFactory : AnimalFactory
    {
        public override Animal CrearAnimal(string nombre, int edad)
        {
            return new Gato
            {
                Nombre = nombre,
                Edad = edad
            };
        }
    }
}
