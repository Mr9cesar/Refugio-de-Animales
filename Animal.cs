using System;
using System.Collections.Generic;
using System.Text;

namespace RefugioAnimales.src
{
    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
        }
    }
}
