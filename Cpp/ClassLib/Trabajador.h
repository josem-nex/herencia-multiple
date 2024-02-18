#ifndef TRABAJADOR_H
#define TRABAJADOR_H

#include "Persona.h"

class Trabajador : public Persona
{
public:
    Trabajador(std::string nombre, double salario) : Persona(nombre, salario) {}
    void CobrarSalario() override
    {
        printf("El trabajador %s cobra el salario\n", nombre.c_str());
    }
};

#endif