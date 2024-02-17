namespace ClassLib;

public class AlumnoAyudante : Estudiante, IImparteClase
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
    public AlumnoAyudante(string nombre, decimal salario, int horasClaseRecibidas, int horasClaseImpartidas) : base(nombre, salario, horasClaseRecibidas)
    {
        _horasClaseImpartidas = horasClaseImpartidas;
    }


    public void ImpartirClase()
    {
        Console.WriteLine("El alumno ayudante {0} ha impartido {1} horas clase.", Nombre, HorasClaseImpartidas);
    }
    public override void CobrarSalario()
    {
        System.Console.WriteLine("El alumno ayudante {0} ha cobrado", Nombre);
    }
}
