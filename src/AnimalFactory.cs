namespace RefugioAnimales.src
{
    internal abstract class AnimalFactory
    {
        public abstract Animal CrearAnimal(string nombre, int edad, bool adoptado);
    }
}
