namespace RefugioAnimales.src
{
    internal class PerroFactory : AnimalFactory
    {
        public override Animal CrearAnimal(string nombre, int edad, bool adoptado)
        {
            return new Perro
            {
                Nombre = nombre,
                Edad = edad,
                Adoptado = adoptado
            };
        }
    }
}
