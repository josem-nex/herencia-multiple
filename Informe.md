# Seminario 2 : Herencia

## C312 Equipo # 6

### Integrantes:

- José Miguel Zayas Pérez
- Raimel Daniel Romaguera Puig
- Yoel Enriquez Sena

---

# Temas:

- Herencia Múltiple en C++ y Python
- Colisión de interfaces e implementación implicita/explícita en C#
- Visibilidad, Redefinición de miembros, Ocultamiento, Representación en Memoria, Polimorfismo, Casteo.

---

# Jerarquía de Clases

## C#, Herencia Simple, Interfaces:

![alt text](/Images/JerarquiaClases.excalidraw.png)

---

###

> La implementación de la Jerarquía de clases anterior se encuentra en la carpeta [ClassLib](/Csharp/ClassLib/) .

- Tenemos tres interfaces que representan las acciones principales de nuestra Jerarquía las cuales serían CobrarSalario, ImpartirClase y RecibirClase.
- Como en C# no se permite herencia múltiple cada clase hereda de una única clase (aunque si se permite heredar de una clase que hereda de otra), entonces en los casos que pudiera ser intuitivo heredar de varias clases como **AlumnoAyudante** y **ProfesorAdiestrado** se implementan las interfaces que garantizan que tengan las funcionalidades correspondientes.
- Mediante el _Polimorfismo_ y la herencia se garantiza que las clases más bajas en la jerarquías pudieran ser consideradas del tipo de las clases base, además se redefinen sus miembros mediante el uso de _override_ que se explicará mas adelante.

---

## Python, C++, Herencia Múltiple

![alt text](/Images/JerHerencMult.excalidraw.png)

###

> La implementación de la Jerarquía de clases anterior para cada lenguaje se encuentra en la carpeta [Python](/Python/) y [Cpp](/Cpp/ClassLib/).

- Al usarse Herencia Múltiple toda la Jerarquía se basa en ella, controlando la ambigüedad mediante la redefinición de métodos.
- En **C++** al igual que en **C#** se maneja el _Polimorfismo_ mediante las palabras clave _virtual_ y _override_, en **Python** estas no existen por lo que puede traer más posibilidad de errores.

# Ambigüedad en Herencia Múltiple

En lenguajes de programación como **C++** y **Python** se permite la Herencia Múltiple, o sea que una Clase puede heredar comportamientos y características de más de una superclase. Esta funcionalidad puede causar ambigüedad cuando clases base tienen métodos o atributos con el mismo nombre.

## Python

```python
class Estudiante():
    def __init__(self, nombre):
        self.nombre = nombre
    def RecibirClase(self):
        print("El estudiante " + self.nombre + " está recibiendo clase")
    def CobrarSalario(self):
        print("El estudiante " + self.nombre + " está cobrando salario")
class Profesor():
    def __init__(self, nombre):
        self.nombre = nombre
    def CobrarSalario(self):
        print("El Profesor " + self.nombre + " está cobrando salario")
    def ImpartirClase(self):
        print("El Profesor " + self.nombre + " está impartiendo clase")
class AlumnoAyudante(Estudiante, Profesor):
    def __init__(self, nombre):
        self.nombre = nombre
```

> La clase **AlumnoAyudante** hereda de **Estudiante** y **Profesor** y ambas clases base tienen el método `def CobrarSalario(self)`, ¿entonces qué imprimirá cuando se llame dicha función en una instancia de **AlumnoAyudante**?

Python resuelve este problema de ambigüedad utilizando el orden de resolución de métodos (Method Resolution Order, MRO) que básicamente sigue la regla de que la clase más a la izquierda en la lista de herencia tiene prioridad sobre las demás.

```python
alumno = AlumnoAyudante("Juan")
alumno.CobrarSalario()  # output: El estudiante Juan está cobrando salario
```

> Como la "primera" clase base de **AlumnoAyudante** es **Estudiante** entonces el método `CobrarSalario()` de **Estudiante** tiene prioridad sobre el de **Profesor**.

Hay diferentes maneras de solucionar esta ambigüedad de forma manual, veamos algunas de ellas:

1. Redefinir el método `CobrarSalario()`, en Python no es necesario que los métodos de las clases base tengan la palabra clave `virtual` como en C#, por lo que se puede redefinir el método:

```python
class AlumnoAyudante(Estudiante, Profesor):
    def __init__(self, name):
        self.nombre = name
    def CobrarSalario(self):
        print("El alumno ayudante " + self.nombre + " está cobrando salario")

```

2. Redefiniendo el método y especificando a cuál de los métodos de las clases base se desea llamar:

```python
class AlumnoAyudante(Estudiante, Profesor):
    def __init__(self, name):
        self.nombre = name
    def CobrarSalario(self):
        Profesor.CobrarSalario(self)
        # Estudiante.CobrarSalario(self)
```

3. Independientemente de la implementación que tenga el método `CobrarSalario()` en **AlumnoAyudante** desde una instancia de la clase se puede llamar al método de una de las clases base:

```python
alumno = AlumnoAyudante("Juan")
Profesor.CobrarSalario(alumno)  # output: El profesor Juan está cobrando salario
Estudiante.CobrarSalario(alumno)  # output: El estudiante Juan está cobrando salario
```

## C++

En C++ un ejemplo similar al anterior de _Python_ se maneja diferente. El compilador de C++ lanza error al detectar dicho problema de ambigüedad que _Python_ resolvió mediante el **MRO**

```Cpp
    AlumnoAyudante *alumno = new AlumnoAyudante("Juan");
    alumno->CobrarSalario();     // Error de ambigüedad
```

> Véase el código completo en: [Ambigüedad/Cpp](/Ambigüedad/Cpp/)

En C++ al igual que en C# existen los modificadores **virtual** y **override** (veremos más adelante en profundidad) que, aunque no son necesarios para modificar un método de una clase base sí son considerados una buena práctica y brindan mucha más legibilidad al código. Para solucionar el problema en **C++** funciona de manera "similar" a **Python**, redefinir el método o especificar a cuál método de clase base se desea llamar.

```Cpp
    void CobrarSalario() override{
        printf("El alumno ayudante cobra salario");
        // Profesor::CobrarSalario();
        // Estudiante::CobrarSalario();
    }
```

```Cpp
    AlumnoAyudante *alumno = new AlumnoAyudante("Juan");
    alumno->Estudiante::CobrarSalario(); // output: El estudiante Juan cobra salario
    alumno->Profesor::CobrarSalario(); // output: El Profesor Juan cobra salario
```

---

# "Ambigüedad" en C#, Soluciones

**C#** no presenta Herencia Múltiple como **C++** y **Python**, sin embargo, sí permite heredar de una clase que a su vez hereda de otra clase. Además se puede "simular" un comportamiento un tanto parecido a la Herencia Múltiple a través de las Interfaces. Las interfaces en **C#** son contratos que especifican un conjunto de métodos y propiedades que una clase debe implementar. Dicho lo anterior veamos los casos en los que se pudiera generar "ambigüedad".

### Implementación de Interfaz Explícita vs Implícita

```Csharp
public interface IProfesor{
    void CobrarSalario();
}
public interface IEstudiante{
    void CobrarSalario();
}
public class AlumnoAyudante : IProfesor, IEstudiante{
    public void CobrarSalario(){
        Console.WriteLine("AlumnoA cobra su salario");
    }
}
```

En el ejemplo anterior se muestra una implementación "_implícita_" de las interfaces _IProfesor_ e _IEstudiante_, pues al usar una instancia de la clase **AlumnoAyudante** como una interfaz de las anteriores ambas utilizarán el método `CobrarSalario()` que implementó **AlumnoAyudante**.

```csharp
AlumnoAyudante alumnoA = new AlumnoAyudante();
alumnoA.CobrarSalario();   //output: "AlumnoA cobra su salario"
((IEstudiante)alumnoA).CobrarSalario(); //output: "AlumnoA cobra su salario"
((IProfesor)alumnoA).CobrarSalario(); //output: "AlumnoA cobra su salario"
```

Sin embargo, en algunos casos es necesario que ambas Interfaces se comporten de manera diferente y para ello **C#** nos permite realizar la implementación explícita.

```Csharp
public class AlumnoAyudante : IProfesor, IEstudiante{
    public void CobrarSalario(){
        Console.WriteLine("AlumnoA cobra su salario");
    }
    void IEstudiante.CobrarSalario(){
        Console.WriteLine("El estudiante cobra su salario");
    }
    void IProfesor.CobrarSalario(){
        Console.WriteLine("El profesor cobra su salario");
    }
}
```

Estas implementaciones explícitas no son accesibles desde una instancia de la clase, solo se "llega" a ellas al tratar una instancia como la interfaz correspondiente, o sea mediante un "casteo", ya sea implícito o explícito.

```csharp
AlumnoAyudante alumnoA = new AlumnoAyudante();
alumnoA.CobrarSalario();   //output: "AlumnoA cobra su salario"
((IEstudiante)alumnoA).CobrarSalario(); //output: "El estudiante cobra su salario"    (casteo explícito)
IProfesor profesorA = alumnoA;  // casteo implícito
profesorA.CobrarSalario(); //output: "El profesor cobra su salario"
```

> El casting implícito ocurre automáticamente cuando se asigna un objeto de un tipo derivado a una variable de un tipo base. El casting explícito requiere una conversión explícita y debe realizarse con precaución para garantizar la validez de la conversión.

### Ocultación en la Herencia de Clases

Otro problema que puede causar ambigüedad en la herencia en **C#** es la ocultación, esto ocurre al implementar un método con igual nombre a uno que ya está implementado en la clase base.

```Csharp
class Trabajador{
    public void CobrarSalario(){
        Console.WriteLine("El trabajador cobra su salario");
    }
}
class Empleado : Trabajador{
    public /* new */ void CobrarSalario(){
        Console.WriteLine("El empleado cobra su salario");
    }
}
```

> En este caso C# nos lanza una adevertencia y trata al método como si tuviera la palabra clave "new" es decir, oculta al método base.

Para solucionar problemas de este tipo y aprovechar al máximo el **Polimorfismo** **C#** nos brinda diferentes opciones:

- Si el método de la clase derivada no va precedido por las palabras clave new u override, el compilador emite una advertencia y el método se comporta como si la palabra clave new estuviese presente.
- Si el método de la clase derivada va precedido de la palabra clave new, el método se define como independiente del método de la clase base.
- Si el método de la clase derivada va precedido de la palabra clave override, los objetos de la clase derivada llamarán a ese método y no al método de la clase base.
- Para aplicar la palabra clave override al método de la clase derivada, se debe definir el método de clase base como virtual.
- El método de clase base puede llamarse desde dentro de la clase derivada mediante la palabra clave base.
- Las palabras clave override, virtual y new también pueden aplicarse a propiedades, indexadores y eventos.

### Visibilidad

La visibilidad de los diferentes tipos de datos es otro aspecto importante al trabajar con Programación Orientada a Objetos que en algunos casos puede provocar errores o ambigüeadad, para ello existen los modificadores de acceso. Se utilizan para la ocultación de datos y veamos las posibilidades que nos brinda **C#**:
![alt text](/Images/Visibilidad.png)

> Un ensamblado es un archivo .dll o .exe creado mediante la compilación de uno o varios archivos .cs en una sola compilación.

> En C++ y Python solo se encuentran public, protected y private y presentan un comportamiento similar a C#.

No todos los modificadores de acceso son válidos para todos los tipos o miembros de todos los contextos. En algunos casos, la accesibilidad de un miembro de tipo está restringida por la accesibilidad de su tipo contenedor.

![alt text](/Images/Accesibilidad.png)

Es importante al crear una Jerarquía de Clases tener en cuenta los diferentes modificadores de acceso, pues podríamos estar dando acceso público a información delicada.

---

# Representación de los objetos en memoria.

## Un objeto perteneciente a una clase que no herede de ninguna otra:

Tanto en **C#** como en **Python** al crear un objeto de una clase sin herencia se reserva en el _heap_ la memoria necesaria para almacenar sus campos y métodos, así como un puntero al tipo de objeto.

En **C++** si el objeto se crea mediante el operador **new** se maneja similar a los anteriores, pero si se hace por una asignación se almacena en el **stack**, o sea que su tiempo de vida está vinculado al alcance en el que se declara.

```Cpp
class MyClass {
public:
    int field;
};

int main() {
    MyClass obj; // Se almacena en el stack
    obj.field = 10;
    MyClass *ptr = new MyClass(); // Se almacena en el heap
    ptr->field = 10;
    return 0;
}
```

## Un objeto perteneciente a una clase que muestre una herencia simple

Similar a lo anterior, tanto en **C#** como en **Python** cuando se crea un objeto de una clase que hereda de otra clase, la memoria se reserva para los campos y métodos de ambas clases, es decir el objeto que se crea en el **heap** contiene tanto los atributos de la clase derivada como de la clase base. Veamos un ejemplo en Python:

```Python
class Animal:
    def __init__(self, name):
        self.name = name
class Dog(Animal):
    def Ladrar(self):
        print("Woof!")

dog = Dog("Max")   #Se almacena en el heap
dog.Ladrar()
```

En **C++** nos encontramos en el mismo caso del ejemplo anterior, depende de la manera en que creemos el objeto.

## Un objeto perteneciente a una clase que utilice herencia múltiple

Ya sabemos que en **C#** no está permitida la herencia múltiple y ello se maneja a través de _Interfaces_, por otro lado en **C++** y **Python** al crear dicho objeto se reserva suficiente memoria en el heap para contener todos los miembros de las clases base y de la clase derivada. Lo anterior pasa siemre que en **C++** se cree el objeto mediante el operador _new_, en caso contrario se almacenaría en el Stack. Veamos un ejemplo en **Python**:

```Python
class Animal:
    def move(self):
        print("Animal is moving.")
class Flyable:
    def fly(self):
        print("Flying.")
class Bird(Animal, Flyable):
    pass

bird = Bird()  # Se almacena en el heap
bird.move()
bird.fly()
```

> En C++, la administración de memoria es manual, lo que brinda un control total y permite un uso eficiente de los recursos, pero también introduce la posibilidad de errores y agrega complejidad al desarrollo. En contraste, Python y C# tienen administración automática de memoria, lo que reduce el riesgo de errores y facilita el desarrollo, aunque puede haber una sobrecarga de rendimiento y menos control directo sobre la gestión de memoria. La elección entre los enfoques depende de los requisitos del proyecto y las preferencias del programador.

## Conclusiones, Herencia Múltiple vs Herencia ssimple e Interfaces

En la comunidad de programación hay un amplio debate sobre si la herencia múltiple puede ser implementada de forma simple y sin ambigüedad pregúntandose si esta es más fácil que usar herencia simple y patrones de diseño de software.

La herencia múltiple proporciona flexibilidad al permitir que una clase herede de múltiples clases base y por otro lado, la herencia simple es más sencilla y fácil de entender, pero limita la capacidad de combinar características de diferentes clases, problema que pudieran solucionar las interfaces al promover la modularidad y el diseño orientado a contratos.

La elección entre estos enfoques depende de los requisitos específicos del diseño y la estructura de la jerarquía de clases, buscando un equilibrio entre flexibilidad y simplicidad.
