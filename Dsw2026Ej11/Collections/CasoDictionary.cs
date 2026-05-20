using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    public Dictionary<int, Alumno> alumnos = new Dictionary<int, Alumno>();

    public void Agregar(int legajo, Alumno a)
    {
        alumnos.Add(legajo, a);
    }
    public Alumno? BuscarAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            var element = alumnos.ElementAt(legajo);
            return element.Value;
        }
        return null;
        
    }
    public Dictionary<int, Alumno> Listar()
    {
        return alumnos;
    }
    public void Eliminar(int legajo)
    {
        alumnos.Remove(legajo);
    }

}
