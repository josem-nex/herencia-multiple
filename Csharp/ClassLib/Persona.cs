namespace ClassLib;

public abstract class Persona : ICobraSalario
{
    public readonly string Nombre;
    protected decimal _salario;

    public decimal Salario
    {
        get => _salario;
    }
    public Persona(string nombre, decimal salario)
    {
        Nombre = nombre;
        _salario = salario;
    }

    public virtual void CobrarSalario()
    {
        Console.WriteLine("La persona {0} ha cobrado {1}", Nombre, _salario);
    }
    protected void VerificarValor(decimal valor)
    {
        if (valor < 0)
            throw new ArgumentOutOfRangeException("El valor introducido no puede ser negativo.");
    }
    public virtual void CobrarSalario(decimal newSalario)
    {
        VerificarValor(newSalario);
        _salario = newSalario;
        Console.WriteLine("La persona {0} ahora cobra {1}", Nombre, newSalario);
    }
}
