#ifndef ALUMNOAYUDANTE_H
#define ALUMNOAYUDANTE_H

#include "Estudiante.h"
#include "Profesor.h"

class AlumnoAyudante : public Estudiante, public Profesor
{
public:
    AlumnoAyudante(std::string nombre, double salario, int horasClaseRecibidas, int horasClaseImpartidas) : Estudiante(nombre, salario, horasClaseRecibidas), Profesor(nombre, salario, horasClaseImpartidas) {}
    void ImpartirClase() override
    {
        printf("El alumno ayudante %s imparte %i horas clase\n", Estudiante::nombre.c_str(), horasClaseImpartidas);
    }
    void RecibirClase() override
    {
        printf("El alumno ayudante %s recibe %i horas clase\n", Estudiante::nombre.c_str(), horasClaseRecibidas);
    }
};

#endif