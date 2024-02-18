#ifndef PROFESOR_H
#define PROFESOR_H

#include "Trabajador.h"

class Profesor : public Trabajador
{
public:
    int horasClaseImpartidas;
    Profesor(std::string nombre, double salario, int horasClaseImpartidas) : Trabajador(nombre, salario), horasClaseImpartidas(horasClaseImpartidas) {}
    virtual void ImpartirClase()
    {
        printf("El profesor %s imparte %i horas clase\n", nombre.c_str(), horasClaseImpartidas);
    }
};

#endif