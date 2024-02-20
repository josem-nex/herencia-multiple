namespace ClassLib;
public sealed class ProfesorAdiestrado : Profesor, IEstudiante
{
    private int _horasClaseRecibidas;
    public int HorasClaseRecibidas
    {
        get => _horasClaseRecibidas;
    }
    public ProfesorAdiestrado(string nombre, decimal salario, int horasClaseImpartidas, int horasClaseRecibidas) : base(nombre, salario, horasClaseImpartidas)
    {
        _horasClaseRecibidas = horasClaseRecibidas;
    }
    public void RecibirClase()
    {
        Console.WriteLine("El profesor adiestrado {0} ha recibido {1} horas clase.", Nombre, HorasClaseRecibidas);
    }
    public void RecibirClase(int horasClaseRecibidas)
    {
        VerificarValor(horasClaseRecibidas);
        _horasClaseRecibidas = horasClaseRecibidas;
        Console.WriteLine("El profesor adiestrado {0} ahora recibe {1} horas clase.", Nombre, HorasClaseRecibidas);
    }

}