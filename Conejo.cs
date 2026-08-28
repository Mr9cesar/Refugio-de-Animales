using System;
using System.Collections.Generic;
using System.Text;

namespace RefugioAnimales.src
{
    public class Conejo : Animal
    {
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Conejo: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
        }
    }
}
