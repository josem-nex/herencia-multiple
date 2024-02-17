#include "Estudiante.h"
#include "IImparteClase.h"

class AlumnoAyudante : public Estudiante, public IImparteClase
{
protected:
    int horasClaseImpartidas;

public:
    AlumnoAyudante(std::string nombre, double salario, int horasClaseRecibidas, int horasClaseImpartidas) : Estudiante(nombre, salario, horasClaseRecibidas), horasClaseImpartidas(horasClaseImpartidas) {}
    void ImpartirClase() override
    {
        // Implementación de ImpartirClase
    }
};