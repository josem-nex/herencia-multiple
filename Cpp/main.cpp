#include <iostream>
#include "ClassLib/Persona.h"
#include "ClassLib/Trabajador.h"
#include "ClassLib/Estudiante.h"
#include "ClassLib/Profesor.h"
#include "ClassLib/AlumnoAyudante.h"
#include "ClassLib/ProfesorAdiestrado.h"

int main(int argc, char const *argv[])
{
    /*
    Persona (nombre, salario)
    Trabajador (nombre, salario)
    Estudiante (nombre, salario, HorasClaseRecibidas)
    Profesor (nombre, salario, HorasClaseImpartidas)
    AlumnoAyudante  (nombre, salario, HorasClaseRecibidas, HorasClaseImpartidas)
    ProfesorAdiestrado (nombre, salario, HorasClaseImpartidas, HorasClaseRecibidas)
     */
    Trabajador *trabajadorPepe = new Trabajador("Pepe", 2000);
    Estudiante *estudianteJuan = new Estudiante("Juan", 0, 10);
    Profesor *profesorLuis = new Profesor("Luis", 3000, 20);
    AlumnoAyudante *alumnoAyudanteAna = new AlumnoAyudante("Ana", 0, 10, 20);
    ProfesorAdiestrado *profesorAdiestradoMaria = new ProfesorAdiestrado("Maria", 3000, 20, 10);

    Trabajador *AlumnoAyudanteAsTrabajador = alumnoAyudanteAna;
    Estudiante *AlumnoAyudanteAsEstudiante = alumnoAyudanteAna;
    Trabajador *ProfesorAdiestradoAsTrabajador = profesorAdiestradoMaria;
    Estudiante *ProfesorAdiestradoAsEstudiante = profesorAdiestradoMaria;

    Estudiante *estudiante = dynamic_cast<Estudiante *>(alumnoAyudanteAna);
    if (estudiante)
    {
        printf("Es un estudiante\n");
    }
    else
    {
        printf("No es un estudiante\n");
    }
    Trabajador *trabajador = dynamic_cast<Trabajador *>(alumnoAyudanteAna);
    if (trabajador)
    {
        printf("Es un trabajador\n");
    }
    else
    {
        printf("No es un trabajador\n");
    }
    /*
     ! AlumnoAyudante != ProfesorAdiestrado
     En C++, no puedes asignar directamente objetos de dos tipos de clases diferentes,
     incluso si tienen los mismos métodos y heredan de las mismas clases base.
     C++ es un lenguaje de programación de tipado estático, lo que significa que el tipo de cada variable
     se conoce en tiempo de compilación y no puede cambiar en tiempo de ejecución.
     */
    return 0;
}
