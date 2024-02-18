# Sistema de Herencias e Interfaces Csharp

## Clases y Herencia

1. `Persona`: Esta es la clase base para todos los roles en la universidad. Implementa la interfaz `ICobraSalario`.

2. `Estudiante`: Esta clase hereda de `Persona` e implementa la interfaz `IRecibeClase`.

3. `Profesor`: Esta clase hereda de `Trabajador` e implementa la interfaz `IImparteClase`.

4. `AlumnoAyudante`: Esta clase hereda de `Estudiante` e implementa la interfaz `IImparteClase`. Representa a un estudiante que también puede impartir clases.

5. `ProfesorAdiestrado`: Esta clase hereda de `Profesor` e implementa la interfaz `IRecibeClase`. Representa a un profesor que todavía está recibiendo formación.

## Interfaces

1. `ICobraSalario`: Esta interfaz se implementa en cualquier clase que represente a alguien que recibe un salario.

2. `IImparteClase`: Esta interfaz se implementa en cualquier clase que represente a alguien que puede impartir clases.

3. `IRecibeClase`: Esta interfaz se implementa en cualquier clase que represente a alguien que puede recibir clases.

## Herencia Múltiple

En C#, la herencia múltiple de clases no está permitida. Sin embargo, puedes implementar múltiples interfaces, lo que te permite modelar la herencia múltiple. En nuestro código, `AlumnoAyudante` y `ProfesorAdiestrado` son ejemplos de esto, ya que implementan múltiples interfaces.

## Polimorfismo

El polimorfismo se logra a través de la implementación de interfaces. Por ejemplo, un objeto de la clase `AlumnoAyudante` puede ser tratado como `Estudiante`, `IImparteClase` o `ICobraSalario`.
