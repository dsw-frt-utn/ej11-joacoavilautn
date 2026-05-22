using Dsw2026Ej11.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    public List<Alumno> alumnos = new List<Alumno>();

    public void Agregar(Alumno a)
    {
        alumnos.Add(a);
    }
    public List<Alumno> Listar()
    {
        return alumnos;
    }
    public Alumno? BuscarAlumno(string nombre)
    {
        foreach(Alumno a in alumnos)
        {
            if (a.Nombre.Equals(nombre))
                return a;
        }
        return null;
    }
    public void Eliminar(Alumno a)
    {
        alumnos.Remove(a);
    }
    public void EliminarEn(int index)
    {
        alumnos.RemoveAt(index);
    }
}
