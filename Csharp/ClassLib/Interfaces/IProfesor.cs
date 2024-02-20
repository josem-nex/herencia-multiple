namespace ClassLib;

public interface IProfesor
{
    int HorasClaseImpartidas { get; }
    void ImpartirClase();
    void ImpartirClase(int horasClaseImpartidas);
}
