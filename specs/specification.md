# SDD - Sistema de Registro de Animales para un Refugio

## 1. Problema

Un refugio de animales recibe perros, gatos y conejos que deben ser registrados para llevar un control básico de los animales que se encuentran bajo su cuidado.

El sistema será utilizado por el encargado del refugio para registrar los animales que ingresan. Para cada animal se necesita almacenar información básica como su nombre, edad, tipo de animal y estado de adopción.

El problema principal está relacionado con la creación de los objetos que representan a los diferentes animales. Dependiendo del tipo seleccionado, el sistema debe crear un objeto diferente: un perro, un gato o un conejo.

Si el programa principal se encargara directamente de crear cada objeto, tendría que conocer las clases concretas y contener la lógica necesaria para decidir cuál objeto construir.

Por esta razón, se propone separar la responsabilidad de creación de los animales del resto del programa mediante un patrón creacional.

---

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

---

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
