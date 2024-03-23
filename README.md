# Seminar 2 (Multiple Inheritance)

The requirements for each exercise in the seminar will be presented from both a practical and theoretical perspective; that is, for its presentation, each team will base itself on the practical case in question to introduce and explain the required theoretical element. The presentation is not merely a statement of code. Questions such as: _Why?, Based on what?, How is this achieved in language X?_ among others, must be asked.

All team members must participate in solving the exercise and be prepared to present all the work. **The person to present** is decided on the day of the presentation. Whoever is not present at the presentation of their team gets `0` in the evaluation. (Note that these grades are averaged and there is a distinction between `0` and `2`).

---

At the University, a person (identified by their Name) is a template if they receive any type of payment and can represent different roles:

- Student (Action: `ReceiveClass()` and `ChargeSalary()`)
- Professor (Action: `TeachClass()`)
- Student Assistant (Student who is not a professor but acts as such at a given moment, that is, can perform `TeachClass()`, in addition, can charge a salary as a separate worker from the salary as a student)
- Worker (not every worker is a professor, but all professors are workers. Action: `ChargeSalary()`)
- Trained Professor (Professor who still receives training courses, Action: `ReceiveClass()`)

The values of salary and class hours (time in which classes are received or taught) must be configurable in any entity.

Illustrate how this class design could be implemented in `C#`, `C++`, and `Python`.

1. Design a hierarchy in `C#` that represents/models the roles above and their relationships. Use some tool to illustrate this model (Example: class designer of Visual Studio)

1. In what cases can multiple inheritance cause ambiguity? Illustrate.
1. How can we solve these cases? Analyze and compare the different solutions. What is the proposed solution in `C#`?
1. Explain how objects are represented in memory. Provide an example of:
   1. An object belonging to a class that does not inherit from any other
   1. An object belonging to a class that shows simple inheritance
   1. An object belonging to a class that uses multiple inheritance

> Analyze: Multiple Inheritance in C++ and Python. Interface collision and implicit/explicit implementation in C#. Visibility, Member Redefinition, Hiding, Representation in Memory, Polymorphism, Casting.

# Seminario 2 (Herencia Múltiple)

Los requerimientos de cada ejercicio del seminario serán expuestos desde el punto de vista práctico y teórico; es decir, para su exposición, cada equipo se basará en el caso práctico en cuestión para introducir y explicar el elemento teórico requerido. La exposición no es una mera enunciación de código. Preguntas como: _¿Por qué?, ¿Basándose en qué?, ¿Cómo se logra esto en el lenguaje X?_ entre otras, deben hacerse.

Todos los miembros del equipo deben participar en la solución del ejercicio y estar preparados para exponer todo el trabajo. **La persona a exponer**. se decide el día de la exposición. Quién no esté presente en la exposición de su equipo tiene `0` en la evaluación. (Note que estas notas se promedian y hay distinción entre `0` y `2`).

---

En la Universidad, una persona (que se identifica por su Nombre) es plantilla si recibe algún tipo de pago y puede representar diferentes roles:

- Estudiante (Acción: `RecibirClase()` y `CobrarSalario()`)
- Profesor (Acción: `ImpartirClase()`)
- Alumno Ayudante (Estudiante que no es profesor pero actúa como tal en un momento dado, es decir, puede realizar `ImpartirClase()`, además puede cobrar un salario como trabajador separado del salario como estudiante)
- Trabajador (no todo trabajador es profesor, pero sí todos los profesores son trabajadores. Acción: `CobrarSalario()`)
- Profesor Adiestrado (Profesor que aún recibe cursos de adiestramiento, Acción: `RecibirClase()`)

Los valores de salario y horas clase (tiempo en que se recibe o imparte clases) debe poder ser configurable en cualquier entidad.

Ilustre cómo podría ser implementado este diseño de clases en lenguajes `C#`, `C++` y `Python`.

1. Diseñe una jerarquía en `C#` que represente/modele los roles anteriores y sus relaciones. Utilice alguna herramienta para ilustrar dicho modelo (Ejemplo: diseñador de clases de Visual Studio)

1. ¿En qué casos la herencia múltiple puede causar ambigüedad? Ejemplifique.
1. ¿Cómo podemos solucionar estos casos? Analice y compare las distintas soluciones. ¿Cuál es la solución propuesta en `C#`?
1. Explique cómo se representan los objetos en memoria. Ponga un ejemplo de:
   1. Un objeto perteneciente a una clase que no herede de ninguna otra
   1. Un objeto perteneciente a una clase que muestre una herencia simple
   1. Un objeto perteneciente a una clase que utilice herencia múltiple

> Analizar: Herencia Múltiple en C++ y Python. Colisión de interfaces e implementación implicita/explícita en C#. Visibilidad, Redefinición de miembros, Ocultamiento, Representación en Memoria, Polimorfismo, Casteo.
