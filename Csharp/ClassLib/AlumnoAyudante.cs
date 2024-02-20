namespace ClassLib;

public sealed class AlumnoAyudante : Estudiante, IProfesor
{
    private int _horasClaseImpartidas;
    public int HorasClaseImpartidas
    {
        get => _horasClaseImpartidas;
    }
    public AlumnoAyudante(string nombre, decimal salario, int horasClaseRecibidas, int horasClaseImpartidas) : base(nombre, salario, horasClaseRecibidas)
    {
        _horasClaseImpartidas = horasClaseImpartidas;
    }
    public void ImpartirClase()
    {
        Console.WriteLine("El alumno ayudante {0} ha impartido {1} horas clase.", Nombre, HorasClaseImpartidas);
    }
    public void ImpartirClase(int horasClaseImpartidas)
    {
        VerificarValor(horasClaseImpartidas);
        _horasClaseImpartidas = horasClaseImpartidas;
        Console.WriteLine("El alumno ayudante {0} ahora imparte {1} horas clase.", Nombre, HorasClaseImpartidas);
    }
    public override void CobrarSalario()
    {
        System.Console.WriteLine("El alumno ayudante {0} ha cobrado {1}", Nombre, _salario);
    }
    public override void CobrarSalario(decimal newSalario)
    {
        VerificarValor(newSalario);
        _salario = newSalario;
        Console.WriteLine("El alumno ayudante {0} ahora cobra {1}", Nombre, newSalario);
    }
}
