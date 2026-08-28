namespace RefugioAnimales.src
{
    internal class ConejoFactory : AnimalFactory
    {
        public override Animal CrearAnimal(string nombre, int edad, bool adoptado)
        {
            return new Conejo
            {
                Nombre = nombre,
                Edad = edad,
                Adoptado = adoptado
            };
        }
    }
}
