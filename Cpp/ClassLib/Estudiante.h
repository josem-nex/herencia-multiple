#ifndef ESTUDIANTE_H
#define ESTUDIANTE_H

#include "Persona.h"

class Estudiante : public Persona
{
protected:
    int horasClaseRecibidas;

public:
    Estudiante(std::string nombre, double salario, int horasClaseRecibidas) : Persona(nombre, salario), horasClaseRecibidas(horasClaseRecibidas) {}
    virtual void RecibirClase()
    {
        printf("El estudiante %s recibe %i horas clase\n", nombre.c_str(), horasClaseRecibidas);
    }
    virtual void CobrarSalario() override
    {
        printf("El estudiante %s cobra salario\n", nombre.c_str());
    }
};

#endif