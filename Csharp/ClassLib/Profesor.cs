namespace ClassLib;

public class Profesor : Trabajador, IProfesor
{
    protected int _horasClaseImpartidas;
    public int HorasClaseImpartidas
    {
        get => _horasClaseImpartidas;
    }
    public Profesor(string nombre, decimal salario, int horasClaseImpartidas) : base(nombre, salario)
    {
        _horasClaseImpartidas = horasClaseImpartidas;
    }
    public override void CobrarSalario()
    {
        Console.WriteLine("El profesor {0} ha cobrado {1}", Nombre, Salario);
    }
    public override void CobrarSalario(decimal newSalario)
    {
        VerificarValor(newSalario);
        _salario = newSalario;
        Console.WriteLine("El profesor {0} ahora cobra {1}", Nombre, newSalario);
    }

    public virtual void ImpartirClase()
    {
        Console.WriteLine("El profesor {0} ha impartido {1} horas clase.", Nombre, HorasClaseImpartidas);
    }
    public virtual void ImpartirClase(int horasClaseImpartidas)
    {
        VerificarValor(horasClaseImpartidas);
        _horasClaseImpartidas = horasClaseImpartidas;
        Console.WriteLine("El profesor {0} ahora imparte {1} horas clase.", Nombre, HorasClaseImpartidas);
    }
}
