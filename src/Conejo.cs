using System;

namespace RefugioAnimales.src
{
    internal class Conejo : Animal
    {
        public override void MostrarInformacion()
        {
            Console.WriteLine("Tipo: Conejo");
            base.MostrarInformacion();
        }
    }
}
