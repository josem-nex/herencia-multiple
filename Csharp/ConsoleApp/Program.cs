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
        var alumnoAyudantePedro = new AlumnoAyudante("Pedro", 500, 10, 5);
        var profesorAdiestradoLuis = new ProfesorAdiestrado("Luis", 1500, 10, 5);
        var estudianteAna = new Estudiante("Ana", 10, 20);
        var trabajadorPepe = new Trabajador("Pepe", 1000);

        var profesorAsTrabajador = (Trabajador)profesorJuan;
        System.Console.WriteLine(profesorAsTrabajador.GetType());
        // var profesorAsEstudiante = (Estudiante)profesorJuan;  // error
        // var profesorAsAlumnoAyudante = (AlumnoAyudante)profesorJuan;   // error
        // var profesorAsProfesorAdiestrado = (ProfesorAdiestrado)profesorJuan; // error pero si permite ponerlo en el codigo xq es posible que se pueda cumplirs
        Profesor profesortest = new ProfesorAdiestrado("Camilo", 1500, 10, 5);
        var polimorfInverso = (ProfesorAdiestrado)profesortest;
        System.Console.WriteLine(polimorfInverso.GetType());
        System.Console.WriteLine("----------------------------------------");
        Profesor profesorAdiestradoAsProfesor = profesorAdiestradoLuis;
        System.Console.WriteLine(profesorAdiestradoAsProfesor.GetType());
        Estudiante alumnoAyudanteAsEstudiante = alumnoAyudantePedro;
        System.Console.WriteLine(alumnoAyudanteAsEstudiante.GetType());
        System.Console.WriteLine("----------------------------------------");
        // AlumnoAyudante candela = (AlumnoAyudante)profesorAdiestradoLuis; // no se puede hacer el cast, tipos diferentes
        // System.Console.WriteLine(profesorAsProfesorAdiestrado.GetType());
    }
}