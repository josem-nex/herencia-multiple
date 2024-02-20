namespace ClassLib;

public class Estudiante : Persona, IEstudiante
{
    protected int _horasClaseRecibidas;
    public int HorasClaseRecibidas
    {
        get => _horasClaseRecibidas;
    }
    public Estudiante(string nombre, decimal salario, int horasClaseRecibidas) : base(nombre, salario)
    {
        _horasClaseRecibidas = horasClaseRecibidas;
    }
    public virtual void RecibirClase()
    {
        Console.WriteLine("El estudiante {0} ha recibido {1} horas clase", Nombre, HorasClaseRecibidas);
    }
    public virtual void RecibirClase(int horasClaseRecibidas)
    {
        VerificarValor(horasClaseRecibidas);
        _horasClaseRecibidas = horasClaseRecibidas;
        Console.WriteLine("El estudiante {0} ahora recibe {1} horas clase", Nombre, HorasClaseRecibidas);
    }
    public override void CobrarSalario()
    {
        Console.WriteLine("El estudiante {0} ha cobrado {1}", Nombre, Salario);
    }
    public override void CobrarSalario(decimal newSalario)
    {
        VerificarValor(newSalario);
        _salario = newSalario;
        Console.WriteLine("El estudiante {0} ahora cobra {1}", Nombre, newSalario);
    }
}
