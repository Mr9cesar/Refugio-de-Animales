using System;
using System.Collections.Generic;
using System.Text;

namespace RefugioAnimales.src
{
    public class Gato : Animal
    {
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Gato: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
        }
    }
}
