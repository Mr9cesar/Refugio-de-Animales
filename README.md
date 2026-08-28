# Refugio de Animales

## Descripción

Este proyecto consiste en un ejemplo sencillo de un sistema para registrar animales que ingresan a un refugio.

El sistema permite registrar tres tipos de animales:

- Perros
- Gatos
- Conejos

Para cada animal se registra:

- Nombre
- Edad
- Tipo de animal
- Estado de adopción

El usuario selecciona el tipo de animal, proporciona sus datos y el sistema crea el objeto correspondiente.

El objetivo principal del proyecto es demostrar el funcionamiento de un patrón de diseño creacional.

## Problema

Un refugio de animales recibe diferentes animales que deben ser registrados para llevar un control básico de los animales que se encuentran bajo su cuidado.

El problema aparece cuando el sistema necesita crear un objeto diferente dependiendo del tipo de animal seleccionado.

Una forma directa de resolverlo sería crear los objetos desde el programa principal utilizando instrucciones como:

```csharp
new Perro()
new Gato()
new Conejo()

Sin embargo, esto haría que el programa principal tuviera que conocer directamente las clases concretas y encargarse de su creación.

Para solucionar este problema se utiliza el patrón Factory Method, que permite delegar la creación de los objetos a fábricas especializadas.

Patrón utilizado
Factory Method

El patrón utilizado es Factory Method, un patrón creacional.

Se eligió este patrón porque el sistema necesita crear diferentes tipos de animales dependiendo de la opción seleccionada por el usuario.

Existe una clase abstracta llamada AnimalFactory, que define el método CrearAnimal().

Las fábricas concretas son:

PerroFactory
GatoFactory
ConejoFactory

Cada fábrica se encarga de crear su respectivo tipo de animal:

PerroFactory   → Perro
GatoFactory    → Gato
ConejoFactory  → Conejo

De esta manera, Program no necesita encargarse directamente de construir cada tipo de animal.

Ventaja

La principal ventaja es separar la responsabilidad de creación de los objetos de la lógica principal del programa.

Además, si en el futuro se necesita agregar otro tipo de animal, se puede crear una nueva clase y su fábrica correspondiente sin modificar innecesariamente la estructura existente.

Diseño

La solución utiliza una clase base llamada Animal, de la cual heredan:

              Animal
             /  |  \
            /   |   \
        Perro  Gato  Conejo

Para la creación de los objetos se utiliza:

                    AnimalFactory
                   /      |       \
                  /       |        \
       PerroFactory   GatoFactory   ConejoFactory
             |             |              |
             ↓             ↓              ↓
           Perro          Gato          Conejo

Clases principales
Animal

Es la clase base de los animales.

Contiene:

Nombre
Edad
Estado de adopción
Perro

Representa un perro y hereda de Animal.

Gato

Representa un gato y hereda de Animal.

Conejo

Representa un conejo y hereda de Animal.

AnimalFactory

Es la clase abstracta que define el método CrearAnimal().

PerroFactory

Se encarga de crear objetos de tipo Perro.

GatoFactory

Se encarga de crear objetos de tipo Gato.

ConejoFactory

Se encarga de crear objetos de tipo Conejo.

Program

Contiene el flujo principal del programa y permite al usuario registrar un animal.

Funcionamiento

El programa solicita al usuario el tipo de animal:

=== REFUGIO DE ANIMALES ===

Seleccione el tipo de animal:

1. Perro
2. Gato
3. Conejo

Después solicita los datos:

Nombre: Max
Edad: 3

¿El animal está adoptado?

1. Disponible para adopción
2. Adoptado

Finalmente muestra la información registrada:

=== ANIMAL REGISTRADO ===

Tipo: Perro
Nombre: Max
Edad: 3 años
Estado: Disponible para adopción

El objeto fue creado utilizando la fábrica correspondiente.

Estructura del proyecto

Refugio-de-Animales/
│
├── README.md
│
├── specs/
│   └── specification.md
│
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
    Requisitos

Para ejecutar el proyecto se necesita:

Visual Studio Community
.NET
C#
Ejecución
Descargar o clonar el repositorio.
Abrir el proyecto en Visual Studio Community.
Compilar la solución.
Ejecutar el programa.
Seleccionar el tipo de animal.
Ingresar el nombre.
Ingresar la edad.
Seleccionar el estado de adopción.
Revisar la información del animal registrado.

También se puede ejecutar utilizando:
Ctrl + F5

Ejemplo de ejecución
=== REFUGIO DE ANIMALES ===

Seleccione el tipo de animal:

1. Perro
2. Gato
3. Conejo

Opción: 1

Nombre: Max
Edad: 3

¿El animal está adoptado?

1. Disponible para adopción
2. Adoptado

Opción: 1

=== ANIMAL REGISTRADO ===

Tipo: Perro
Nombre: Max
Edad: 3 años
Estado: Disponible para adopción

Objetivo académico

Este proyecto fue desarrollado como una actividad académica para comprender y demostrar el uso del patrón creacional Factory Method.

La solución muestra cómo la responsabilidad de crear diferentes tipos de objetos puede ser delegada a clases especializadas, manteniendo el programa principal organizado y facilitando la incorporación de nuevos tipos de animales.
