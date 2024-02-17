namespace ClassLib;

public class Estudiante : Persona, IRecibeClase
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
    public Estudiante(string nombre, decimal salario, int horasClaseRecibidas) : base(nombre, salario)
    {
        _horasClaseRecibidas = horasClaseRecibidas;
    }

    public void RecibirClase()
    {
        Console.WriteLine("El estudiante {0} ha recibido {1} horas clase", Nombre, HorasClaseRecibidas);
    }
    public override void CobrarSalario()
    {
        Console.WriteLine("El estudiante {0} ha cobrado {1}", Nombre, Salario);
    }
}
