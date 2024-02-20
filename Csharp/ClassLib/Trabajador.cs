namespace ClassLib;

public class Trabajador : Persona
{
    public Trabajador(string nombre, decimal salario) : base(nombre, salario) { }
    public override void CobrarSalario()
    {
        Console.WriteLine("El trabajador {0} ha cobrado {1}", Nombre, Salario);
    }
    public override void CobrarSalario(decimal newSalario)
    {
        VerificarValor(newSalario);
        _salario = newSalario;
        Console.WriteLine("El trabajador {0} ahora cobra {1}", Nombre, newSalario);
    }
}
