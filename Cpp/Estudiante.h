#include "Persona.h"
#include "IRecibeClase.h"

class Estudiante : public Persona, public IRecibeClase
{
protected:
    int horasClaseRecibidas;

public:
    Estudiante(std::string nombre, double salario, int horasClaseRecibidas) : Persona(nombre, salario), horasClaseRecibidas(horasClaseRecibidas) {}
    void RecibirClase() override
    {
        // Implementación de RecibirClase
    }
};