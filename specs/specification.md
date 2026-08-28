# Refugio de Animales

## Descripción

Este proyecto consiste en una solución sencilla para registrar animales que ingresan a un refugio.

El sistema permite registrar tres tipos de animales:

* Perros
* Gatos
* Conejos

Para cada animal se registra la siguiente información:

* Nombre
* Edad
* Tipo de animal
* Estado de adopción

El usuario selecciona el tipo de animal, ingresa sus datos y el sistema crea el objeto correspondiente.

El proyecto fue desarrollado para demostrar el uso de un patrón de diseño creacional.

## Problema

En un refugio pueden ingresar diferentes tipos de animales y cada uno debe estar representado por un objeto diferente dentro del programa.

El problema se presenta cuando el sistema necesita decidir qué objeto crear dependiendo del tipo de animal seleccionado.

Una forma directa de solucionar esto sería crear los objetos desde el programa principal utilizando `new Perro()`, `new Gato()` o `new Conejo()`. Sin embargo, esto haría que el programa principal tuviera que conocer directamente las clases concretas y encargarse de su creación.

Para solucionar este problema se utiliza el patrón **Factory Method**, que permite separar la creación de los objetos de la lógica principal del programa.

## Patrón utilizado: Factory Method

**Factory Method** es un patrón creacional que permite delegar la creación de objetos a clases especializadas.

En este proyecto se utiliza una clase abstracta llamada `AnimalFactory`, que define el método `CrearAnimal()`.

Las fábricas concretas son:

* `PerroFactory`, que crea objetos `Perro`.
* `GatoFactory`, que crea objetos `Gato`.
* `ConejoFactory`, que crea objetos `Conejo`.

La estructura es:

```text
AnimalFactory
     │
     ├── PerroFactory → Perro
     ├── GatoFactory → Gato
     └── ConejoFactory → Conejo
```

La ventaja de utilizar este patrón es que el programa principal no tiene que encargarse directamente de crear cada tipo de animal. La responsabilidad de creación queda separada y organizada en las fábricas correspondientes.

## Diseño

El proyecto está compuesto por una clase base `Animal` y tres clases que heredan de ella:

```text
                 Animal
                /  |  \
               /   |   \
           Perro  Gato  Conejo
```

La clase `Animal` contiene la información común de los animales:

* `Nombre`
* `Edad`
* `Adoptado`

Las clases `Perro`, `Gato` y `Conejo` representan los diferentes tipos de animales.

Para la creación de los objetos se utilizan las fábricas:

```text
                AnimalFactory
               /      |       \
              /       |        \
     PerroFactory  GatoFactory  ConejoFactory
          |            |             |
          ↓            ↓             ↓
        Perro         Gato         Conejo
```

El programa principal permite seleccionar el tipo de animal, ingresar sus datos y utilizar la fábrica correspondiente para crear el objeto.

## Funcionamiento

El programa solicita al usuario el tipo de animal:

```text
=== REFUGIO DE ANIMALES ===

Seleccione el tipo de animal:

1. Perro
2. Gato
3. Conejo
```

Después solicita los datos del animal:

```text
Nombre: Max
Edad: 3

¿El animal está adoptado?

1. Disponible para adopción
2. Adoptado
```

Finalmente, muestra la información del animal registrado:

```text
=== ANIMAL REGISTRADO ===

Tipo: Perro
Nombre: Max
Edad: 3 años
Estado: Disponible para adopción
```

## Estructura del proyecto

```text
RefugioAnimales/
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
```

## Requisitos

Para ejecutar el proyecto se necesita:

* Visual Studio Community
* .NET
* C#

## Ejecución

1. Abrir el proyecto `RefugioAnimales` en Visual Studio Community.
2. Compilar la solución.
3. Ejecutar el programa.
4. Seleccionar el tipo de animal.
5. Ingresar el nombre.
6. Ingresar la edad.
7. Seleccionar el estado de adopción.
8. El sistema mostrará la información del animal creado.

También se puede ejecutar utilizando:

```text
Ctrl + F5
```

## Objetivo académico

Este proyecto fue desarrollado como una actividad académica para comprender y demostrar el funcionamiento del patrón creacional **Factory Method**, aplicándolo a un problema sencillo de registro de animales en un refugio.
