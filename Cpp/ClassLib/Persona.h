#ifndef PERSONA_H
#define PERSONA_H

#include <string>

class Persona
{
public:
    std::string nombre;
    double salario;
    Persona(std::string nombre, double salario) : nombre(nombre), salario(salario) {}
    virtual void CobrarSalario() = 0;
    // abstract method
};

#endif