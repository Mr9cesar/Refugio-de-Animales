using System;

namespace RefugioAnimales.src
{
    internal class Perro : Animal
    {
        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo: Perro");
            base.MostrarInformacion();
        }
    }
}
