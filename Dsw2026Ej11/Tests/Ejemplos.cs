namespace Dsw2026Ej11.Tests;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var a1 = new Alumno(1, "Joaquin", 8.0);
        var a2 = new Alumno(2, "Lautaro", 7.0);
        var a3 = new Alumno(3, "Tomas", 8.3);

        var alumnos = new CasoList();

        alumnos.Agregar(a1);
        alumnos.Agregar(a2);
        alumnos.Agregar(a3);

        foreach (var a in alumnos.Listar())
            Console.WriteLine($"{a}");

        Console.WriteLine($"\n{alumnos.BuscarAlumno("Lautaro")}");

        if (alumnos.BuscarAlumno("Pedro") == null)
            Console.WriteLine($"\nNo existe");
        else
            Console.WriteLine($"{alumnos.BuscarAlumno("Pedro")}");

        Console.WriteLine("\nEliminando el alumno a2.");
        alumnos.Eliminar(a2);
        foreach (var a in alumnos.Listar())
            Console.WriteLine($"{a}");

        Console.WriteLine("\nEliminando el primer elemento.");
        alumnos.EliminarEn(0);
        foreach (var a in alumnos.Listar())
            Console.WriteLine($"{a}");
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

    }
}
