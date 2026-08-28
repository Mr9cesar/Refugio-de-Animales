using System;
using System.Collections.Generic;
using System.Text;

namespace RefugioAnimales.src
{
    public class Perro : Animal
    {
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Perro: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
        }
    }
}
