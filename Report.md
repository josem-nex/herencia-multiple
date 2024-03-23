# Seminar 2: Inheritance

## C312 Team # 6

### Members:

- José Miguel Zayas Pérez
- Raimel Daniel Romaguera Puig
- Yoel Enriquez Sena

---

# Topics:

- Multiple Inheritance in C++ and Python
- Interface collision and implicit/explicit implementation in C#
- Visibility, Member Redefinition, Hiding, Representation in Memory, Polymorphism, Casting.

---

# Class Hierarchy

## C#, Simple Inheritance, Interfaces:

![alt text](/HerenciaMultiple/Images/JerarquiaClases.excalidraw.png)

---

###

> The implementation of the above class hierarchy is found in the [ClassLib](/Csharp/ClassLib/) folder.

- We have three interfaces that represent the main actions of our hierarchy, which would be `ChargeSalary`, `TeachClass`, and `ReceiveClass`.
- Since in C# multiple inheritance is not allowed (though it is allowed to inherit from a class that inherits from another), in cases where it would be intuitive to inherit from several classes like **Student Assistant** and **Trained Professor**, the interfaces are implemented to ensure they have the corresponding functionalities.
- Through _Polymorphism_ and inheritance, it is guaranteed that the classes lower in the hierarchy could be considered of the type of the base classes, in addition, their members are redefined using _override_, which will be explained later.

---

## Python, C++, Multiple Inheritance

![alt text](/HerenciaMultiple/Images/JerHerencMult.excalidraw.png)

###

> The implementation of the above class hierarchy for each language is found in the [Python](/Python/) and [Cpp/ClassLib/](/Cpp/ClassLib/) folders.

- When using Multiple Inheritance, the entire hierarchy is based on it, controlling ambiguity through method redefinition.
- In **C++**, just like in **C#**, polymorphism is managed through the keywords _virtual_ and _override_, in **Python** these do not exist, so it can bring more possibilities of errors.

# Ambiguity in Multiple Inheritance

In programming languages like **C++** and **Python**, Multiple Inheritance is allowed, meaning a Class can inherit behaviors and characteristics from more than one superclass. This functionality can cause ambiguity when base classes have methods or attributes with the same name.

## Python

```python
class Student():
    def __init__(self, name):
        self.name = name
    def ReceiveClass(self):
        print("The student " + self.name + " is receiving class")
    def ChargeSalary(self):
        print("The student " + self.name + " is charging salary")
class Professor():
    def __init__(self, name):
        self.name = name
    def ChargeSalary(self):
        print("The Professor " + self.name + " is charging salary")
    def TeachClass(self):
        print("The Professor " + self.name + " is teaching class")
class StudentAssistant(Student, Professor):
    def __init__(self, name):
        self.name = name
```

> The **StudentAssistant** class inherits from **Student** and **Professor** and both base classes have the method `def ChargeSalary(self)`, so what will it print when this function is called on an instance of **StudentAssistant**?

Python resolves this ambiguity problem using the Method Resolution Order (MRO) which basically follows the rule that the class most to the left in the inheritance list has priority over the others.

```python
student = StudentAssistant("Juan")
student.ChargeSalary() # output: The student Juan is charging salary
```

> Since the "first" base class of **StudentAssistant** is **Student**, then the method `ChargeSalary()` of **Student** has priority over the one of **Professor**.

There are different ways to manually solve this ambiguity, let's see some of them:

1. Redefine the `ChargeSalary()` method, in Python it is not necessary for the methods of the base classes to have the keyword `virtual` as in C#, so you can redefine the method:

```python
class StudentAssistant(Student, Professor):
    def __init__(self, name):
        self.name = name
    def ChargeSalary(self):
        print("The student assistant " + self.name + " is charging salary")
```

2. Redefining the method and specifying which method of the base classes you want to call:

```python
class StudentAssistant(Student, Professor):
    def __init__(self, name):
        self.name = name
    def ChargeSalary(self):
        Professor.ChargeSalary(self)
        # Student.ChargeSalary(self)
```

3. Regardless of the implementation that the `ChargeSalary()` method has in **StudentAssistant**, from an instance of the class you can call the method of one of the base classes:

```python
student = StudentAssistant("Juan")
Professor.ChargeSalary(student) # output: The professor Juan is charging salary
Student.ChargeSalary(student) # output: The student Juan is charging salary
```

## C++

In C++, a similar example to the previous **Python** one is handled differently. The C++ compiler throws an error when detecting this ambiguity problem that **Python** resolved through the **MRO**

```Cpp
    StudentAssistant *student = new StudentAssistant("Juan");
    student->ChargeSalary();     // Ambiguity error
```

> See the complete code in: [Ambiguity/Cpp](/Ambiguity/Cpp/)

In C++, just like in C#, there are the **virtual** and **override** modifiers (we will see more in depth later) that, although not necessary to modify a method of a base class, are considered good practice and greatly increase code readability. To solve the problem in **C++** it works "similarly" to **Python**, by redefining the method or specifying which method of the base class you want to call.

```Cpp
    void ChargeSalary() override{
        printf("The student assistant charges salary");
        // Professor::ChargeSalary();
        // Student::ChargeSalary();
    }
```

```Cpp
    StudentAssistant *student = new StudentAssistant("Juan");
    student->Student::ChargeSalary(); // output: The student Juan charges salary
    student->Professor::ChargeSalary(); // output: The professor Juan charges salary
```

---

# "Ambiguity" in C#, Solutions

**C#** does not present Multiple Inheritance as **C++** and **Python**, however, it allows inheriting from a class that in turn inherits from another class. Additionally, a somewhat similar behavior to Multiple Inheritance can be "simulated" through Interfaces. Interfaces in **C#** are contracts that specify a set of methods and properties that a class must implement. Given the above, let's see the cases in which "ambiguity" could be generated.

### Explicit vs Implicit Interface Implementation

```Csharp
public interface IProfessor{
    void ChargeSalary();
}
public interface IStudent{
    void ChargeSalary();
}
public class StudentAssistant : IProfessor, IStudent{
    public void ChargeSalary(){
        Console.WriteLine("StudentAssistant charges salary");
    }
}
```

In the example above, we show an "_implicit_" implementation of the interfaces _IProfessor_ and _IStudent_, since when using an instance of the **StudentAssistant** class as one of the above, both will use the `ChargeSalary()` method that **StudentAssistant** implemented.

```csharp
StudentAssistant studentA = new StudentAssistant();
studentA.ChargeSalary();   //output: "StudentAssistant charges salary"
((IStudent)studentA).ChargeSalary(); //output: "StudentAssistant charges salary"
((IProfessor)studentA).ChargeSalary(); //output: "StudentAssistant charges salary"
```

However, in some cases, it is necessary for both Interfaces to behave differently and for this **C#** allows for an "_explicit_" implementation.

```Csharp
public class StudentAssistant : IProfessor, IStudent{
    public void ChargeSalary(){
        Console.WriteLine("StudentAssistant charges salary");
    }
    void IStudent.ChargeSalary(){
        Console.WriteLine("The student charges salary");
    }
    void IProfessor.ChargeSalary(){
        Console.WriteLine("The professor charges salary");
    }
}
```

These explicit implementations are not accessible from an instance of the class, only through it as the corresponding interface, that is, through a "cast", either implicit or explicit.

```csharp
StudentAssistant studentA = new StudentAssistant();
studentA.ChargeSalary();   //output: "StudentAssistant charges salary"
((IStudent)studentA).ChargeSalary(); //output: "The student charges salary"    (explicit cast)
IProfessor professorA = studentA; // implicit cast
professorA.ChargeSalary(); //output: "The professor charges salary"
```

> Implicit casting occurs automatically when assigning an object of a derived type to a variable of a base type. Explicit casting requires an explicit conversion and must be done with caution to ensure the validity of the conversion.

### Hiding in Class Inheritance

Another problem that can cause ambiguity in inheritance in **C#** is hiding, this occurs when implementing a method with the same name as one that is already implemented in the base class.

```Csharp
class Worker{
    public void ChargeSalary(){
        Console.WriteLine("The worker charges salary");
    }
}
class Employee : Worker{
    public /* new */ void ChargeSalary(){
        Console.WriteLine("The employee charges salary");
    }
}
```

> In this case, C# issues a warning and treats the method as if the keyword "new" were present, that is, it hides the base method.

To solve problems of this type and fully utilize **Polymorphism** **C#** offers different options:

- If the method of the derived class is not preceded by the keywords new or override, the compiler emits a warning and the method behaves as if the keyword new were present.
- If the method of the derived
