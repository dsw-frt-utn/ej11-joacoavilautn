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

        var aBuscado = alumnos.BuscarAlumno("Pedro");
        if (aBuscado == null)
            Console.WriteLine($"\nNo existe");
        else
            Console.WriteLine(aBuscado);

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
        var a1 = new Alumno(1, "Joaquin", 8.0);
        var a2 = new Alumno(2, "Lautaro", 7.0);
        var a3 = new Alumno(3, "Tomas", 8.3);

        var alumnos = new CasoDictionary();

        alumnos.Agregar(1,a1);
        alumnos.Agregar(2,a2);
        alumnos.Agregar(3,a3);

        foreach (KeyValuePair<int, Alumno> element in alumnos.Listar())
        {
            int legajo = element.Key;
            Alumno a = element.Value;
            Console.WriteLine($"Legajo: {legajo}, Alumno: {a}");
        }

        Console.WriteLine($"\n{alumnos.BuscarAlumno(1)}");

        var aBuscado = alumnos.BuscarAlumno(4);
        if (aBuscado == null)
            Console.WriteLine("\nNo existe");
        else
            Console.WriteLine(aBuscado);

        Console.WriteLine("\nEliminando alumno con legajo 2");
        alumnos.Eliminar(2);
        foreach (KeyValuePair<int, Alumno> element in alumnos.Listar())
        {
            int legajo = element.Key;
            Alumno a = element.Value;
            Console.WriteLine($"Legajo: {legajo}, Alumno: {a}");
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var libros = new CasoLinq();
        Console.WriteLine("--- PRIMER LIBRO ---");
        var primero = libros.GetPrimero();
        Console.WriteLine(primero);

        Console.WriteLine("\n--- ULTIMO LIBRO ---");
        var ultimo = libros.GetUltimo();
        Console.WriteLine(ultimo);

        Console.WriteLine("\n--- SUMA PRECIOS LIBROS ---");
        Console.WriteLine(libros.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\n--- PROMEDIO PRECIOS LIBROS ---");
        Console.WriteLine(libros.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\n--- LISTA LIBROS POR ID > 15 ---");
        foreach (var l in libros.GetListById())
        {
            Console.WriteLine(l);
        }

        Console.WriteLine("\n--- LISTA LIBROS POR TITULO Y PRECIO ---");
        foreach (var l in libros.GetLibros())
        {
            Console.WriteLine(l);
        }

        Console.WriteLine("\n--- LIBRO MAYOR PRECIO ---");
        var mayor = libros.GetMayorPrecio();
        Console.WriteLine(mayor);

        Console.WriteLine("\n--- LIBRO MENOR PRECIO ---");
        var menor = libros.GetMenorPrecio();
        Console.WriteLine(menor);

        Console.WriteLine("\n--- LISTA LIBROS POR PRECIO > PROMEDIO ---");
        Console.WriteLine($"Promedio: {libros.GetPromedioPrecios():C}");
        foreach (var l in libros.GetMayorPromedio())
        {
            Console.WriteLine(l);
        }
        Console.WriteLine();
        Console.WriteLine("--- LISTA LIBROS ORDENADOS DESCENDENTEMENTE ---");
        foreach (var l in libros.GetLibrosOrdenados())
        {
            Console.WriteLine(l.Titulo);
        }
    }
}
