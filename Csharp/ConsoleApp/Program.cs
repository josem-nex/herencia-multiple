using ClassLib;
public class Program
{
    public static void Main(string[] args)
    {
        //  profesor (nombre, salario, horasClaseImpartidas)
        //  alumnoAyudante (nombre, salario, horasClaseRecibidas, horasClaseImpartidas)
        //  profesorAdiestrado (nombre, salario, horasClaseImpartidas, horasClaseRecibidas)
        //  estudiantes (nombre, salario, horasClaseRecibidas)
        //  trabajador (nombre, salario)

        Console.WriteLine("Testing");
        var profesorJuan = new Profesor("Juan", 1000, 10);
        System.Console.WriteLine(profesorJuan.GetType());
        profesorJuan.ImpartirClase();
        var alumnoAyudanteTomas = new AlumnoAyudante("Tomas", 500, 10, 5);
        System.Console.WriteLine(alumnoAyudanteTomas.GetType());
        alumnoAyudanteTomas.ImpartirClase();
        var profesorAdiestradoLuis = new ProfesorAdiestrado("Luis", 1500, 10, 5);
        var estudianteThalia = new Estudiante("Thalia", 10, 20);
        System.Console.WriteLine(estudianteThalia.GetType());
        estudianteThalia.RecibirClase();
        var trabajadorPepe = new Trabajador("Pepe", 1000);
        System.Console.WriteLine("----------------------------------------");
        profesorJuan.CobrarSalario();
        var profesorAsTrabajador = (Trabajador)profesorJuan;
        Trabajador[] trabajadors = new Trabajador[4];
        trabajadors[0] = profesorJuan;
        System.Console.WriteLine(trabajadors[0].GetType());
        profesorAsTrabajador.CobrarSalario();
        // var profesorAsEstudiante = (Estudiante)profesorJuan;  // error
        // var profesorAsAlumnoAyudante = (AlumnoAyudante)profesorJuan;   // error
        // var profesorAsProfesorAdiestrado = (ProfesorAdiestrado)profesorJuan; // error pero si permite ponerlo en el codigo xq es posible que se pueda cumplirs
        Profesor profesortest = new ProfesorAdiestrado("Camilo", 1500, 10, 5);
        var polimorfInverso = (ProfesorAdiestrado)profesortest;
        System.Console.WriteLine(polimorfInverso.GetType());
        System.Console.WriteLine("----------------------------------------");
        Profesor profesorAdiestradoAsProfesor = profesorAdiestradoLuis;
        System.Console.WriteLine(profesorAdiestradoAsProfesor.GetType());
        Estudiante alumnoAyudanteAsEstudiante = alumnoAyudanteTomas;
        System.Console.WriteLine(alumnoAyudanteAsEstudiante.GetType());
        System.Console.WriteLine("Interfaces-----------------------");
        // AlumnoAyudante candela = (AlumnoAyudante)profesorAdiestradoLuis; // no se puede hacer el cast, tipos diferentes
        // System.Console.WriteLine(profesorAsProfesorAdiestrado.GetType());
        IEstudiante estudianteTest = profesorAdiestradoLuis;
        Trabajador trabajadorTest = profesorAdiestradoLuis;
        IProfesor profesorTest = profesorAdiestradoLuis;
        trabajadorTest.CobrarSalario();
        System.Console.WriteLine("-----------DIA DE COBRO----------");
        List<ICobraSalario> cobradores = new List<ICobraSalario>();
        cobradores.Add(profesorJuan);
        cobradores.Add(alumnoAyudanteTomas);
        cobradores.Add(profesorAdiestradoLuis);
        cobradores.Add(estudianteThalia);
        cobradores.Add(trabajadorPepe);
        foreach (var cobrador in cobradores)
            cobrador.CobrarSalario();

    }
}