#include <string>

class Persona
{
public:
    Persona(const std::string &nombre) : nombre(nombre) {}
    virtual void CobrarSalario() = 0;

protected:
    std::string nombre;
};

class Estudiante : public Persona
{
public:
    Estudiante(const std::string &nombre) : Persona(nombre) {}
    void RecibirClase() {}
    void CobrarSalario() override
    {
        printf("El estudiante %s cobra salario", nombre.c_str());
    }
};

class Profesor : public Persona
{
public:
    Profesor(const std::string &nombre) : Persona(nombre) {}
    void CobrarSalario() override
    {
        printf("El Profesor %s cobra salario", nombre.c_str());
    }
};

class AlumnoAyudante : public Estudiante, public Profesor
{
public:
    AlumnoAyudante(const std::string &nombre) : Estudiante(nombre), Profesor(nombre) {}
    void ImpartirClase() {}
    // void CobrarSalario() override
    // {
    //     Profesor::CobrarSalario();
    //     printf("El alumno ayudante cobra salario");
    // }
};

int main(int argc, char const *argv[])
{
    AlumnoAyudante *alumno = new AlumnoAyudante("Juan");
    // alumno->CobrarSalario(); // Error de ambigüedad
    alumno->Estudiante::CobrarSalario();
    alumno->Profesor::CobrarSalario();
    return 0;
}
