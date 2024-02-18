namespace ClassLib;

public class Profesor : Trabajador, IProfesor
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
    public override void CobrarSalario()
    {
        Console.WriteLine("El profesor {0} ha cobrado {1}", Nombre, Salario);
    }

    public virtual void ImpartirClase()
    {
        Console.WriteLine("El profesor {0} ha impartido {1} horas clase.", Nombre, HorasClaseImpartidas);
    }
}
