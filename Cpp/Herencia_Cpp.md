# Sistema de Herencias e Interfaces Cpp

## Clase Persona

La clase `Persona` es la clase base. Tiene dos atributos protegidos: `nombre` y `salario`. Define un método virtual puro `CobrarSalario()`.

## Clase Trabajador

La clase `Trabajador` hereda de la clase `Persona`. Sobreescribe el método `CobrarSalario()`.

## Clase Estudiante

La clase `Estudiante` también hereda de la clase `Persona`. Tiene un atributo protegido adicional `horasClaseRecibidas` y define un nuevo método `RecibirClase()`. También sobreescribe el método `CobrarSalario()`.

## Clase Profesor

La clase `Profesor` hereda de la clase `Trabajador`. Tiene un atributo protegido adicional `horasClaseImpartidas` y define un nuevo método `ImpartirClase()`.

## Clase AlumnoAyudante

La clase `AlumnoAyudante` hereda de las clases `Estudiante` y `Profesor`. Sobreescribe los métodos `ImpartirClase()` y `RecibirClase()`.

## Clase ProfesorAdiestrado

La clase `ProfesorAdiestrado` hereda de las clases `Profesor` y `Estudiante`. Sobreescribe los métodos `ImpartirClase()` y `RecibirClase()`.
