namespace ClassLib;

public abstract class Persona : ICobraSalario
{
    public readonly string Nombre;
    private decimal _salario;

    public decimal Salario
    {
        get => _salario;
        set
        {
            if (value <= 0)
                throw new ArgumentException("El salario no puede ser menor o igual a 0");
            _salario = value;
        }
    }

    public Persona(string nombre, decimal salario)
    {
        Nombre = nombre;
        _salario = salario;
    }

    public virtual void CobrarSalario()
    {
        Console.WriteLine("La persona {0} ha cobrado {1}", Nombre, Salario);
    }
}
