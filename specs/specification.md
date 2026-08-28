# Especificación del sistema — Refugio de Animales

## 1. Problema

Un refugio de animales recibe diferentes tipos de animales que necesitan ser registrados. Para este ejemplo, el refugio puede recibir perros, gatos y conejos.

Cuando llega un animal, el sistema debe crear un objeto que represente correctamente el tipo de animal recibido.

El problema se presenta porque existen diferentes tipos de animales y el programa necesita decidir qué objeto debe crear dependiendo del tipo seleccionado. Si esta responsabilidad se encuentra directamente en el programa principal, la lógica de creación puede volverse difícil de mantener cuando se agreguen nuevos tipos de animales.

El sistema será utilizado por un funcionario o encargado del refugio para registrar los animales que llegan.

La solución propuesta busca separar la creación de los objetos del resto de la lógica del programa.

## 2. Requisitos

### Requisitos funcionales

- **RF-01:** El sistema debe permitir registrar un animal.
- **RF-02:** El sistema debe permitir seleccionar el tipo de animal que se desea registrar.
- **RF-03:** El sistema debe permitir registrar el nombre del animal.
- **RF-04:** El sistema debe permitir registrar la edad del animal.
- **RF-05:** El sistema debe crear un objeto correspondiente al tipo de animal seleccionado.
- **RF-06:** El sistema debe permitir registrar perros, gatos y conejos.
- **RF-07:** El sistema debe mostrar la información del animal creado.

### Requisitos no funcionales

- **RNF-01:** La solución debe ser sencilla y estar enfocada en demostrar el patrón creacional seleccionado.
- **RNF-02:** La lógica de creación de los animales debe estar separada de la lógica principal del programa.
- **RNF-03:** El código debe ser comprensible y estar organizado en clases con responsabilidades claras.

## 3. Patrón seleccionado

### Factory Method

El patrón seleccionado es **Factory Method**.

Se eligió este patrón porque el sistema necesita crear diferentes tipos de animales dependiendo de la opción seleccionada por el usuario.

Sin utilizar un patrón creacional, el programa principal podría encargarse directamente de crear cada objeto:

- `Perro`
- `Gato`
- `Conejo`

Esto haría que el código principal conozca las clases concretas y sea responsable de decidir qué objeto crear.

Factory Method permite separar esta responsabilidad. La creación de los animales queda delegada a una clase especializada, mientras que el resto del programa puede trabajar con el concepto general de `Animal`.

### Ventaja

La principal ventaja es que la lógica de creación queda organizada y separada del código que utiliza los animales.

Además, si posteriormente se necesita agregar otro tipo de animal, como una tortuga, se puede incorporar una nueva clase relacionada con la creación sin modificar innecesariamente el resto del programa.

## 4. Diseño propuesto

La solución tendrá una clase general `Animal`, que representará las características comunes de los animales.

A partir de ella existirán diferentes tipos concretos:

```text
                 Animal
                    ▲
          ┌─────────┼─────────┐
          │         │         │
        Perro      Gato     Conejo
