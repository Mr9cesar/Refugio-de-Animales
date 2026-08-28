using RefugioAnimales.src;

Console.WriteLine("=== REFUGIO DE ANIMALES ===");
Console.WriteLine("Seleccione el tipo de animal:");
Console.WriteLine("1. Perro");
Console.WriteLine("2. Gato");
Console.WriteLine("3. Conejo");

Console.Write("Opción: ");
string opcion = Console.ReadLine();

Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine());

AnimalFactory factory;

switch (opcion)
{
    case "1":
        factory = new PerroFactory();
        break;

    case "2":
        factory = new GatoFactory();
        break;

    case "3":
        factory = new ConejoFactory();
        break;

    default:
        Console.WriteLine("Opción no válida.");
        return;
}

Animal animal = factory.CrearAnimal(nombre, edad);

Console.WriteLine("\nAnimal registrado:");
animal.MostrarInformacion();