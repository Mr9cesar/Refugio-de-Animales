````markdown
# SDD - Sistema de Registro de Animales para un Refugio

## 1. Problema

Un refugio de animales recibe diferentes animales que deben ser registrados para llevar un control básico de los que se encuentran bajo su cuidado.

El sistema será utilizado por el encargado del refugio para registrar los animales que ingresan. Para cada animal se necesita almacenar información básica como su nombre, edad, tipo de animal y estado de adopción.

El problema principal está en la creación de los objetos que representan a los diferentes animales. Dependiendo del tipo seleccionado, el sistema debe crear un objeto diferente: un perro, un gato o un conejo.

Si el programa principal se encargara directamente de crear cada objeto, tendría que conocer las clases concretas y contener la lógica necesaria para decidir cuál objeto construir.

Por esta razón, se propone separar la responsabilidad de crear los animales del resto del programa mediante un patrón creacional.

## 2. Requisitos

### 2.1 Requisitos funcionales

- **RF-01:** El sistema debe permitir registrar un animal en el refugio.
- **RF-02:** El sistema debe permitir seleccionar el tipo de animal que se desea registrar.
- **RF-03:** El sistema debe permitir registrar perros, gatos y conejos.
- **RF-04:** El sistema debe permitir ingresar el nombre del animal.
- **RF-05:** El sistema debe permitir ingresar la edad del animal.
- **RF-06:** El sistema debe permitir indicar el estado de adopción del animal.
- **RF-07:** El estado de adopción debe permitir identificar si el animal está disponible para adopción o si ya fue adoptado.
- **RF-08:** El sistema debe crear un objeto correspondiente al tipo de animal seleccionado.
- **RF-09:** El sistema debe mostrar la información del animal registrado.
- **RF-10:** La creación del objeto debe realizarse mediante el método definido por las fábricas del sistema.

### 2.2 Requisitos no funcionales

- **RNF-01:** La solución debe ser sencilla y estar enfocada en demostrar el funcionamiento del patrón Factory Method.
- **RNF-02:** La responsabilidad de crear los diferentes tipos de animales debe estar separada de la lógica principal del programa.
- **RNF-03:** El código debe estar organizado en clases con responsabilidades claras.
- **RNF-04:** La aplicación debe poder ejecutarse como un programa de consola desarrollado en C#.
- **RNF-05:** La solución debe ser comprensible para facilitar su explicación y mantenimiento.

## 3. Patrón seleccionado

### Factory Method

El patrón creacional seleccionado para este proyecto es **Factory Method**.

Se eligió este patrón porque el sistema necesita crear diferentes tipos de animales dependiendo de la opción seleccionada por el usuario.

Los animales comparten características generales, pero pertenecen a diferentes clases concretas:

- `Perro`
- `Gato`
- `Conejo`

Una solución directa podría consistir en crear estos objetos directamente desde el programa principal utilizando instrucciones como:

```csharp
new Perro()
new Gato()
new Conejo()
````

Sin embargo, de esta manera el programa principal tendría que conocer directamente las clases concretas y decidir cómo crear cada objeto.

Con Factory Method, esta responsabilidad se delega a clases especializadas llamadas fábricas.

Cada fábrica se encarga de crear un tipo específico de animal:

* `PerroFactory` crea objetos `Perro`.
* `GatoFactory` crea objetos `Gato`.
* `ConejoFactory` crea objetos `Conejo`.

La clase `AnimalFactory` define el método `CrearAnimal()`, mientras que las fábricas concretas implementan este método según el objeto que deben crear.

### Ventaja frente a crear los objetos directamente

La principal ventaja es la separación de responsabilidades.

El programa principal no necesita encargarse directamente de construir cada tipo de animal. La responsabilidad de creación se encuentra en las fábricas correspondientes.

Esto también facilita la ampliación del sistema. Si en el futuro el refugio necesitara registrar otro tipo de animal, se podría crear una nueva clase que herede de `Animal` y una fábrica encargada de crearla.

De esta manera, la lógica existente se mantiene más organizada.

## 4. Diseño propuesto

La solución estará compuesta por una clase base llamada `Animal` y tres clases concretas:

* `Perro`
* `Gato`
* `Conejo`

La clase `Animal` contendrá los datos comunes de todos los animales:

* Nombre
* Edad
* Estado de adopción

La relación entre estas clases será:

```text
                 Animal
                /  |  \
               /   |   \
           Perro  Gato  Conejo
```

Para implementar Factory Method se utilizará una clase abstracta llamada `AnimalFactory`.

Esta clase definirá el método:

```text
CrearAnimal()
```

Las fábricas concretas serán:

```text
              AnimalFactory
             /      |       \
            /       |        \
   PerroFactory  GatoFactory  ConejoFactory
         |            |             |
         ↓            ↓             ↓
       Perro         Gato         Conejo
```

Cada fábrica implementará `CrearAnimal()` y devolverá el tipo de animal que le corresponde.

### Clases principales

#### Animal

Clase base que representa las características comunes de los animales.

Contendrá:

* `Nombre`
* `Edad`
* `Adoptado`

También tendrá un método para mostrar la información del animal.

#### Perro

Clase que representa un perro y hereda de `Animal`.

#### Gato

Clase que representa un gato y hereda de `Animal`.

#### Conejo

Clase que representa un conejo y hereda de `Animal`.

#### AnimalFactory

Clase abstracta que define el método `CrearAnimal()`.

Su función es establecer la estructura que deberán seguir las fábricas concretas.

#### PerroFactory

Implementa `CrearAnimal()` y crea objetos de tipo `Perro`.

#### GatoFactory

Implementa `CrearAnimal()` y crea objetos de tipo `Gato`.

#### ConejoFactory

Implementa `CrearAnimal()` y crea objetos de tipo `Conejo`.

#### Program

Contiene el flujo principal de la aplicación.

Permite al usuario:

1. Seleccionar el tipo de animal.
2. Ingresar el nombre.
3. Ingresar la edad.
4. Indicar el estado de adopción.
5. Crear el animal mediante la fábrica correspondiente.
6. Mostrar la información del animal.

## 5. Criterios de aceptación

* **CA-01:** Al seleccionar la opción correspondiente a perro, el sistema debe crear correctamente un objeto `Perro`.
* **CA-02:** Al seleccionar la opción correspondiente a gato, el sistema debe crear correctamente un objeto `Gato`.
* **CA-03:** Al seleccionar la opción correspondiente a conejo, el sistema debe crear correctamente un objeto `Conejo`.
* **CA-04:** El objeto creado debe conservar correctamente el nombre ingresado por el usuario.
* **CA-05:** El objeto creado debe conservar correctamente la edad ingresada por el usuario.
* **CA-06:** El objeto creado debe conservar correctamente el estado de adopción seleccionado.
* **CA-07:** El sistema debe mostrar el tipo, nombre, edad y estado de adopción del animal registrado.
* **CA-08:** La creación de cada animal debe realizarse mediante el método `CrearAnimal()` de la fábrica correspondiente.
* **CA-09:** Las fábricas deben crear únicamente el tipo de animal que les corresponde.
* **CA-10:** El programa debe funcionar correctamente para perros, gatos y conejos.

```
```
