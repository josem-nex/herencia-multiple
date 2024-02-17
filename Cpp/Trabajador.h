#include "Persona.h"

class Trabajador : public Persona
{
public:
    Trabajador(std::string nombre, double salario) : Persona(nombre, salario) {}
    void CobrarSalario() override
    {
        // Implementación de CobrarSalario
    }
};