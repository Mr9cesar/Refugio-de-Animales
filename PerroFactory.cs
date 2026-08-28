using System;
using System.Collections.Generic;
using System.Text;

namespace RefugioAnimales.src
{
    public class PerroFactory : AnimalFactory
    {
        public override Animal CrearAnimal(string nombre, int edad)
        {
            return new Perro
            {
                Nombre = nombre,
                Edad = edad
            };
        }
    }
}
