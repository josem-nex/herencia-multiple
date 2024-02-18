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
        printf("El estudiante cobra salario");
    }
};

class Trabajador : public Persona
{
public:
    Trabajador(const std::string &nombre) : Persona(nombre) {}
    void CobrarSalario() override
    {
        printf("El trabajador cobra salario");
    }
};

class AlumnoAyudante : public Estudiante, public Trabajador
{
public:
    AlumnoAyudante(const std::string &nombre) : Estudiante(nombre), Trabajador(nombre) {}
    void ImpartirClase() {}
    // void CobrarSalario() override
    // {
    //     printf("El alumno ayudante cobra salario");
    // }
};
int main(int argc, char const *argv[])
{
    AlumnoAyudante juanelo = AlumnoAyudante("Juanelo");
    juanelo.Trabajador::CobrarSalario();
    return 0;
}
