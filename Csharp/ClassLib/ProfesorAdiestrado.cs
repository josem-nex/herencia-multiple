namespace ClassLib;
public class ProfesorAdiestrado : Profesor, IRecibeClase
{
    private int _horasClaseRecibidas;
    public int HorasClaseRecibidas
    {
        get => _horasClaseRecibidas;
        set
        {
            if (value < 0)
                throw new ArgumentException("Las horas de clase no pueden ser menores que 0");
            _horasClaseRecibidas = value;
        }
    }
    public ProfesorAdiestrado(string nombre, decimal salario, int horasClaseImpartidas, int horasClaseRecibidas) : base(nombre, salario, horasClaseImpartidas)
    {
        _horasClaseRecibidas = horasClaseRecibidas;
    }
    public void RecibirClase()
    {
        Console.WriteLine("El profesor adiestrado {0} ha recibido {1} horas clase.", Nombre, HorasClaseRecibidas);
    }
}