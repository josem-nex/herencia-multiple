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
        var alumnoAyudanteTomas = new AlumnoAyudante("Tomas", 500, 10, 5);
        var profesorAdiestradoLuis = new ProfesorAdiestrado("Luis", 1500, 10, 5);
        var estudianteThalia = new Estudiante("Thalia", 10, 20);
        var trabajadorPepe = new Trabajador("Pepe", 1000);

        System.Console.WriteLine("----------------------------------------");
        Persona[] personas =
        [
            profesorJuan,
            alumnoAyudanteTomas,
            profesorAdiestradoLuis,
            estudianteThalia,
            trabajadorPepe,
        ];
        foreach (var persona in personas)
        {
            Console.WriteLine(persona.GetType() + " " + persona.Nombre);
            persona.CobrarSalario();
        }
        System.Console.WriteLine("------------CobrarInterface--------------");
        ICobraSalario[] cobradores =
        [
            profesorJuan,
            alumnoAyudanteTomas,
            profesorAdiestradoLuis,
            estudianteThalia,
            trabajadorPepe,
        ];
        foreach (var cobrador in cobradores)
            cobrador.CobrarSalario();
        // var profesorAsEstudiante = (Estudiante)profesorJuan;  // error
        // var profesorAsAlumnoAyudante = (AlumnoAyudante)profesorJuan;   // error
        // var profesorAsProfesorAdiestrado = (ProfesorAdiestrado)profesorJuan; // error pero si permite ponerlo en el codigo xq es posible que se pueda cumplirs
        System.Console.WriteLine("----------------------------------------");
        Profesor profesortest = new ProfesorAdiestrado("Camilo", 1500, 10, 5);
        var polimorfInverso = (ProfesorAdiestrado)profesortest;
        System.Console.WriteLine(polimorfInverso.GetType());
    }
}