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
    AlumnoAyudante *alumnoAyudanteThalia = new AlumnoAyudante("Thalia", 0, 10, 20);
    ProfesorAdiestrado *profesorAdiestradoMaria = new ProfesorAdiestrado("Maria", 3000, 20, 10);

    Trabajador *AlumnoAyudanteAsTrabajador = alumnoAyudanteThalia;
    Estudiante *AlumnoAyudanteAsEstudiante = alumnoAyudanteThalia;
    Trabajador *ProfesorAdiestradoAsTrabajador = profesorAdiestradoMaria;
    Estudiante *ProfesorAdiestradoAsEstudiante = profesorAdiestradoMaria;
    printf("El estudiante imparte %i horas clase\n", alumnoAyudanteThalia->horasClaseImpartidas);

    Estudiante *estudiante = dynamic_cast<Estudiante *>(alumnoAyudanteThalia);
    if (estudiante)
    {
        printf("Es un estudiante\n");
        printf("El estudiante %s recibe %i horas clase\n", estudiante->nombre.c_str(), estudiante->horasClaseRecibidas);
        // printf("El estudiante imparte %i horas clase\n", estudiante->horasClaseImpartidas); error
    }
    else
    {
        printf("No es un estudiante\n");
    }
    Trabajador *trabajador = dynamic_cast<Trabajador *>(alumnoAyudanteThalia);
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
     */
    return 0;
}
