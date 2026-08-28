using System;

namespace RefugioAnimales.src
{
    internal class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Adoptado { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Estado: {(Adoptado ? "Adoptado" : "Disponible para adopción")}");
        }
    }
}
