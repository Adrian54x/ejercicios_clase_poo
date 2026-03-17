// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Estudiante> estudiantes = new List<Estudiante>();
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
        Console.WriteLine($"\nNombre:{Nombre} \nPromedio:{PromedioNota()} \nEstado:{EstadoDeEstudiante}");
    }
}
