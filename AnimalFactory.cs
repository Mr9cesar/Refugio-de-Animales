using System;
using System.Collections.Generic;
using System.Text;

namespace RefugioAnimales.src
{
    public abstract class AnimalFactory
    {
        public abstract Animal CrearAnimal(string Nombre, int Edad);
    }
}
