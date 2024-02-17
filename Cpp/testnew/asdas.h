#include <string>

class Persona
{
protected:
    std::string nombre;
    double salario;

public:
    Persona(std::string nombre, double salario) : nombre(nombre), salario(salario) {}
    virtual void CobrarSalario()
    {
    }
};

class Trabajador : public Persona
{
public:
    Trabajador(std::string nombre, double salario) : Persona(nombre, salario) {}
    void CobrarSalario() override
    {
        printf("El trabajador %s cobra el salario\n", nombre.c_str());
    }
};

class IImparteClase
{
public:
    virtual void ImpartirClase() = 0;
};

class Profesor : public Trabajador, public IImparteClase
{
protected:
    int horasClaseImpartidas;

public:
    Profesor(std::string nombre, double salario, int horasClaseImpartidas) : Trabajador(nombre, salario), horasClaseImpartidas(horasClaseImpartidas) {}
    void ImpartirClase() override
    {
        printf("El profesor %s imparte %i horas clase\n", nombre.c_str(), horasClaseImpartidas);
    }
};

class IRecibeClase
{
public:
    virtual void RecibirClase() = 0;
};

class Estudiante : public Persona, public IRecibeClase
{
protected:
    int horasClaseRecibidas;

public:
    Estudiante(std::string nombre, double salario, int horasClaseRecibidas) : Persona(nombre, salario), horasClaseRecibidas(horasClaseRecibidas) {}
    void RecibirClase() override
    {
        printf("El estudiante %s recibe %i horas clase\n", nombre.c_str(), horasClaseRecibidas);
    }
};

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