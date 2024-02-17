#include "Trabajador.h"
#include "IImparteClase.h"

class Profesor : public Trabajador, public IImparteClase
{
protected:
    int horasClaseImpartidas;

public:
    Profesor(std::string nombre, double salario, int horasClaseImpartidas) : Trabajador(nombre, salario), horasClaseImpartidas(horasClaseImpartidas) {}
    void ImpartirClase() override
    {
        // Implementación de ImpartirClase
    }
};