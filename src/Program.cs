using System;

namespace RefugioAnimales.src
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REFUGIO DE ANIMALES ===");
            Console.WriteLine();
            Console.WriteLine("Seleccione el tipo de animal:");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Gato");
            Console.WriteLine("3. Conejo");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();

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

            Console.WriteLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("¿El animal está adoptado?");
            Console.WriteLine("1. Disponible para adopción");
            Console.WriteLine("2. Adoptado");
            Console.Write("Opción: ");

            string estado = Console.ReadLine();
            bool adoptado;

            if (estado == "1")
            {
                adoptado = false;
            }
            else if (estado == "2")
            {
                adoptado = true;
            }
            else
            {
                Console.WriteLine("Opción no válida.");
                return;
            }

            Animal animal = factory.CrearAnimal(nombre, edad, adoptado);

            Console.WriteLine();
            Console.WriteLine("=== ANIMAL REGISTRADO ===");
            animal.MostrarInformacion();
        }
    }
}
