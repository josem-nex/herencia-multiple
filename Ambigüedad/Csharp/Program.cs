public interface IProfesor
{
    void CobrarSalario();
}
public interface IEstudiante
{
    void CobrarSalario();
}
public class AlumnoAyudante : IProfesor, IEstudiante
{
    public void CobrarSalario()
    {
        Console.WriteLine("Cobra su salario");
    }
    // void IEstudiante.CobrarSalario()
    // {
    //     Console.WriteLine("El estudiante cobra su salario");
    // }
    // void IProfesor.CobrarSalario()
    // {
    //     Console.WriteLine("El profesor cobra su salario");
    // }
}

class Trabajador
{
    public void CobrarSalario()
    {
        Console.WriteLine("El trabajador cobra su salario");
    }
}
class Empleado : Trabajador
{
    public /* new */ void CobrarSalario()
    {
        // base.CobrarSalario();
        Console.WriteLine("El empleado cobra su salario");
    }
}
class HerenciaImplicita
{

}
class Program
{
    static void Main()
    {
        //  c# utiliza la palabra clave new en el metodo para indicar que se esta ocultando el metodo de la clase base
        Empleado empleado = new Empleado();
        empleado.CobrarSalario();
        ((Trabajador)empleado).CobrarSalario();
        Console.WriteLine("------Interfaces------");
        AlumnoAyudante alumnoA = new AlumnoAyudante();
        alumnoA.CobrarSalario();
        ((IEstudiante)alumnoA).CobrarSalario();
        IProfesor profesorA = alumnoA;
        profesorA.CobrarSalario();
        var test = new HerenciaImplicita();
        Console.WriteLine(test.GetType());
    }
}