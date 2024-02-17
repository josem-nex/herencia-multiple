namespace ClassLib;

public class Profesor : Trabajador, IImparteClase
{
    private int _horasClaseImpartidas;
    public int HorasClaseImpartidas
    {
        get => _horasClaseImpartidas;
        set
        {
            if (value < 0)
                throw new ArgumentException("Las horas de clase no pueden ser menores que 0");
            _horasClaseImpartidas = value;
        }
    }
    public Profesor(string nombre, decimal salario, int horasClaseImpartidas) : base(nombre, salario)
    {
        _horasClaseImpartidas = horasClaseImpartidas;
    }

    public void ImpartirClase()
    {
        Console.WriteLine("El profesor {0} ha impartido {1} horas clase.", Nombre, HorasClaseImpartidas);
    }
}
