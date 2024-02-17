#include "Profesor.h"
#include "IRecibeClase.h"

class ProfesorAdiestrado : public Profesor, public IRecibeClase
{
protected:
    int horasClaseRecibidas;

public:
    ProfesorAdiestrado(std::string nombre, double salario, int horasClaseImpartidas, int horasClaseRecibidas) : Profesor(nombre, salario, horasClaseImpartidas), horasClaseRecibidas(horasClaseRecibidas) {}
    void RecibirClase() override
    {
        // Implementación de RecibirClase
    }
};