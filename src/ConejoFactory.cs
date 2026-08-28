using System;
using System.Collections.Generic;
using System.Text;

namespace RefugioAnimales.src
{
    public class ConejoFactory : AnimalFactory
    {
        public override Animal CrearAnimal(string nombre, int edad)
        {
            return new Conejo
            {
                Nombre = nombre,
                Edad = edad
            };
        }
    }
}