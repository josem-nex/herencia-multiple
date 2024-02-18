public interface IProfesor
{
    void CobrarSalario();
}
public interface ITrabajador
{
    void CobrarSalario();
}
public class Maestro
{
    public void CobrarSalario()
    {
        Console.WriteLine("El maestro cobra su salario");
    }

}
public class Profesor : IProfesor, ITrabajador
{
    public void CobrarSalario()
    {
        Console.WriteLine("Cobra su salario");
    }
    // void ITrabajador.CobrarSalario()
    // {
    //     Console.WriteLine("El trabajador cobra su salario");
    // }
    // void IProfesor.CobrarSalario()
    // {
    //     Console.WriteLine("El profesor cobra su salario");
    // }
}

class Trabajador
{
    public string Nombre { get; set; }

    public Trabajador(string nombre)
    {
        Nombre = nombre;
    }

    public void CobrarSalario()
    {
        Console.WriteLine("El trabajador cobra su salario");
    }
}
class Empleado : Trabajador
{
    public Empleado(string nombre) : base(nombre) { }

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
        Empleado empleado = new Empleado("Juan Perez");
        empleado.CobrarSalario();
        ((Trabajador)empleado).CobrarSalario();
        Console.WriteLine("------Interfaces------");
        Profesor profesor = new Profesor();
        profesor.CobrarSalario();
        ((ITrabajador)profesor).CobrarSalario();
        ((IProfesor)profesor).CobrarSalario();
        var test = new HerenciaImplicita();
        Console.WriteLine(test.GetType());
    }
}