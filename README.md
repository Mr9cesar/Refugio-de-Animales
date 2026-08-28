# Refugio de Animales

## Descripción

Este proyecto presenta una solución sencilla para el registro de animales que llegan a un refugio.

El sistema permite registrar tres tipos de animales:

- Perros
- Gatos
- Conejos

El usuario selecciona el tipo de animal, ingresa su nombre y edad, y el sistema crea el objeto correspondiente y muestra su información.

El objetivo principal del proyecto es demostrar el uso de un patrón de diseño creacional.

## Patrón utilizado

### Factory Method

El patrón utilizado es **Factory Method**.

Se eligió este patrón porque el sistema necesita crear diferentes tipos de animales dependiendo de la opción seleccionada por el usuario.

En lugar de que el programa principal cree directamente cada tipo de animal, la responsabilidad de creación se delega a fábricas especializadas:

- `PerroFactory` crea objetos `Perro`.
- `GatoFactory` crea objetos `Gato`.
- `ConejoFactory` crea objetos `Conejo`.

Todas las fábricas heredan de `AnimalFactory`, que define el método `CrearAnimal()`.

De esta manera, la lógica de creación se mantiene separada del resto del programa.

## Estructura del proyecto

```text
RefugioAnimales/
├── README.md
├── specs/
│   └── specification.md
└── src/
    ├── Animal.cs
    ├── AnimalFactory.cs
    ├── Perro.cs
    ├── PerroFactory.cs
    ├── Gato.cs
    ├── GatoFactory.cs
    ├── Conejo.cs
    ├── ConejoFactory.cs
    └── Program.cs
