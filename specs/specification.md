# SDD - Sistema de Registro de Animales

## 1. Problema

Un refugio de animales recibe diferentes animales que deben ser registrados para llevar un control básico de los que se encuentran bajo su cuidado.

El sistema será utilizado por el encargado del refugio para registrar los animales que ingresan. Cada animal puede ser de un tipo diferente, como perro, gato o conejo, y debe conservar información básica como su nombre, edad y estado de adopción.

El problema se encuentra en la creación de los objetos que representan a cada animal. El programa necesita crear una clase diferente dependiendo del tipo de animal seleccionado. Si el programa principal se encargara directamente de crear cada objeto, tendría que conocer y manejar la creación de todas las clases concretas.

Se busca separar la responsabilidad de crear los animales del resto de la lógica del programa.

## 2. Requisitos

### Requisitos funcionales

- **RF-01:** El sistema debe permitir registrar un animal.
- **RF-02:** El sistema debe permitir seleccionar el tipo de animal: perro, gato o conejo.
- **RF-03:** El sistema debe permitir ingresar el nombre del animal.
- **RF-04:** El sistema debe permitir ingresar la edad del animal.
- **RF-05:** El sistema debe permitir indicar si el animal está adoptado o disponible para adopción.
- **RF-06:** El sistema debe crear un objeto correspondiente al tipo de animal seleccionado.
- **RF-07:** El sistema debe mostrar la información del animal registrado.
- **RF-08:** El sistema debe permitir comprobar que cada fábrica crea el tipo de animal que le corresponde.

### Requisitos no funcionales

- **RNF-01:** La solución debe ser sencilla y estar enfocada en demostrar el patrón Factory Method.
- **RNF-02:** La responsabilidad de crear los objetos debe estar separada del programa principal.
- **RNF-03:** El código debe estar organizado en clases con responsabilidades claras.
- **RNF-04:** La solución debe poder ejecutarse como una aplicación de consola en C#.

## 3. Patrón seleccionado

### Factory Method

El patrón seleccionado es **Factory Method**, uno de los patrones creacionales.

Se seleccionó porque el sistema necesita crear diferentes tipos de animales dependiendo de la opción seleccionada por el usuario.

Sin utilizar este patrón, el programa principal podría crear directamente los objetos mediante instrucciones como `new Perro()`, `new Gato()` o `new Conejo()`. Esto haría que el programa principal conociera las clases concretas y tuviera responsabilidad sobre su creación.

Con Factory Method, la creación se delega a fábricas concretas. `PerroFactory` crea perros, `GatoFactory` crea gatos y `ConejoFactory` crea conejos.

De esta manera, el código que utiliza los animales queda separado de la lógica específica utilizada para crearlos.

### Ventaja frente a crear los objetos directamente

La principal ventaja es la separación de responsabilidades. El programa principal no necesita conocer los detalles de creación de cada tipo de animal.

Además, si el refugio necesitara agregar otro tipo de animal en el futuro, se podría crear una nueva clase de animal y una fábrica correspondiente sin tener que modificar toda la lógica de creación existente.

## 4. Diseño propuesto

La solución utilizará una clase base llamada `Animal`, que contendrá la información común de los animales:

- Nombre
- Edad
- Estado de adopción

Las clases `Perro`, `Gato` y `Conejo` heredarán de `Animal`.

La estructura será:

```text
                 Animal
              /     |     \
             /      |      \
         Perro     Gato    Conejo
