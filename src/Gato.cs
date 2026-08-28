using System;

namespace RefugioAnimales.src
{
    internal class Gato : Animal
    {
        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo: Gato");
            base.MostrarInformacion();
        }
    }
}
