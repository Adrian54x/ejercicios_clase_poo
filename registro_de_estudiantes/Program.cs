// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
List<Estudiante> estudiantes = new List<Estudiante>();
Console.Write("Cuantos estudiantes desea ingresar:");
int cantidad = int.Parse(Console.ReadLine());
for (int i = 0; i < cantidad; i++)
{
    Estudiante e = new Estudiante();
    Console.Write($"{i + 1}. Nombre de estudiante:");
    e.Nombre = Console.ReadLine();
    Console.Write(" Nota1:");
    e.Nota1 = double.Parse(Console.ReadLine());
    Console.Write(" Nota2:");
    e.Nota2 = double.Parse(Console.ReadLine());
    Console.Write(" Nota3:");
    e.Nota3 = double.Parse(Console.ReadLine());
    estudiantes.Add(e);
}
Estudiante mejorPromedio = estudiantes[0];
Console.WriteLine("\nEstudiamntes registrados");
foreach(Estudiante e in estudiantes)
{
    e.InformacionEstudiante();
    if(e.PromedioNota() > mejorPromedio.PromedioNota())
    {
        mejorPromedio = e;
    }
}
Console.WriteLine("El mejor promedio es:");
mejorPromedio.InformacionEstudiante();
class Estudiante
{
    public string Nombre;
    public double Nota1;
    public double Nota2;
    public double Nota3;
    public double PromedioNota()
    {
        return (Nota1 + Nota2 + Nota3)/3;
    }
    public string EstadoDeEstudiante()
    {
        if (PromedioNota() >= 60)
        {
            return "Aprovado";
        }
        else
        {
            return "Reprobado";
        }
    }
    public void InformacionEstudiante()
    {
        Console.WriteLine($"\nNombre:{Nombre} \nPromedio:{PromedioNota():F2} \nEstado:{EstadoDeEstudiante}");
    }
}
