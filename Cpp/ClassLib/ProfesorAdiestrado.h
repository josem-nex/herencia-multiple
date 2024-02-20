#ifndef PROFESORADIESTRADO_H
#define PROFESORADIESTRADO_H

#include "Profesor.h"
#include "Estudiante.h"

class ProfesorAdiestrado : public Profesor, public Estudiante
{
public:
    // int horasClaseRecibidas;
    ProfesorAdiestrado(std::string nombre, double salario, int horasClaseImpartidas, int horasClaseRecibidas) : Profesor(nombre, salario, horasClaseImpartidas), Estudiante(nombre, salario, horasClaseRecibidas) {}

    void RecibirClase() override
    {
        printf("El profesor adiestrado %s recibe %i horas clase\n", Profesor::nombre.c_str(), horasClaseRecibidas);
    }
    void ImpartirClase() override
    {
        printf("El profesor adiestrado %s imparte %i horas clase\n", Profesor::nombre.c_str(), horasClaseImpartidas);
    }
};

#endif