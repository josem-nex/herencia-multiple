namespace ClassLib;

public interface IEstudiante
{
    int HorasClaseRecibidas { get; }
    void RecibirClase();
    void RecibirClase(int horasClaseRecibidas);
}
