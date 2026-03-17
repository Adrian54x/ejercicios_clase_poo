// See https://aka.ms/new-console-template for more information
List<Empleado> empleados = new List<Empleado>();
Console.Write("Ingrese la cantidad de empleados que va a ingresar:");
int cantidad = int.Parse(Console.ReadLine());
for(int i = 0; i < cantidad; i++)
{
    Empleado e = new Empleado();
    Console.Write("Nombre:");
    e.Nombre = Console.ReadLine();
    Console.Write("Puesto:");
    e.Puesto = Console.ReadLine()
    Console.Write("Salario:");
    e.Salario = double.Parse(Console.ReadLine());
}
class Empleado
{
    public string Nombre;
    public string Puesto;
    public double Salario;
    public double SalarioAnual()
    {
        return Salario * 12;
    }
    public double Bono()
    {
        if (Salario > 5000)
        {
            return Salario * 0.2;
        }
        else
        {
            return Salario * 0.1;
        }
    }
    public string ClasificarSalario()
    {
        if(Salario > 5000)
        {
            return "Salario Alto";
        }
        else if(Salario > 1000)
        {
            return "Salario medio";
        }
        else
        {
            return "Salario Basico";
        }
    }
    public void MostrarProductos()
    {
        Console.WriteLine($"\nNombre del Trabajador:{Nombre} \nPuesto:{Puesto} \nSalario:Q{Salario} / {ClasificarSalario()} \nSalario Anual:{SalarioAnual():F2} \nBono:{Bono():F2}");
    }
}

