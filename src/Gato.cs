namespace RefugioAnimales.src
{
    internal class GatoFactory : AnimalFactory
    {
        public override Animal CrearAnimal(string nombre, int edad, bool adoptado)
        {
            return new Gato
            {
                Nombre = nombre,
                Edad = edad,
                Adoptado = adoptado
            };
        }
    }
}
