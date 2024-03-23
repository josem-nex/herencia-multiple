using System.Timers;

#region Ocultacion, polimorfismo, redefinicion de miembros, casteo.


Trabajador Juan = new Trabajador("Juan", 4000);
Empleado Pedro = new Empleado("Pedro", 5000);
Trabajador Carlos = new Trabajador("Carlos", 3000);
Empleado Rafael = new Empleado("Rafael", 5000);

// Pedro.CobrarSalario();
// Console.WriteLine("\n");

// Juan = Pedro;
// Juan.CobrarSalario();

// List<Trabajador> trabajadores = new List<Trabajador>();
// trabajadores.Add(Juan);
// trabajadores.Add(Pedro);
// trabajadores.Add(Carlos);
// trabajadores.Add(Rafael);

// foreach (Trabajador trabajador in trabajadores)
// {
//     trabajador.CobrarSalario();
// }


Pedro = (Empleado)new Trabajador("Pedro", 4000);
Pedro.TrabajarHorasExtra();


public class Trabajador
{
    public string Nombre;
    public int Salario;

    public Trabajador(string Nombre, int Salario)
    {
        this.Nombre = Nombre;
        this.Salario = Salario;
    }

    public virtual void CobrarSalario()
    {
        Console.WriteLine("El trabajador {0} ha cobrado {1}", this.Nombre, this.Salario);
    }
}

public class Empleado : Trabajador
{
    public Empleado(string Nombre, int Salario) : base(Nombre, Salario) { }
    public override void CobrarSalario()
    {
        Console.WriteLine("El Empleado {0} ha cobrado  {1}", this.Nombre, this.Salario);
    }

    public void TrabajarHorasExtra()
    {
        Console.WriteLine("El Empleado {0} ha trabajado en horas extra", this.Nombre);
    }
}

#endregion

#region Colision de Interfaces

// AlumnoAyudante alumnoA = new AlumnoAyudante();

// alumnoA.CobrarSalario();

// IProfesor profesorA = alumnoA;
// profesorA.CobrarSalario();

// ((IEstudiante)alumnoA).CobrarSalario();



// public interface IProfesor
// {
//     void CobrarSalario();
// }
// public interface IEstudiante
// {
//     void CobrarSalario();
// }


// public class AlumnoAyudante : IProfesor, IEstudiante
// {
//     public void CobrarSalario()
//     {
//         Console.WriteLine("AlumnoA cobra su salario");
//     }

//     void IEstudiante.CobrarSalario()
//     {
//         Console.WriteLine("El estudiante cobra su salario");
//     }

//     void IProfesor.CobrarSalario()
//     {
//         Console.WriteLine("El profesor cobra su salario");
//     }
// }


#endregion