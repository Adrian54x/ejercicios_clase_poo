// See https://aka.ms/new-console-template for more information
List<Empleado> empleados = new List<Empleado>();
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
            return "Salario Bajo";
        }
    }
    public void MostrarProductos()
    {
        Console.WriteLine($"\nNombre del Trabajador:{Nombre} \nSalario:Q{Salario} / {ClasificarSalario()} \nValor total del producto:{ValorTotal():F2}");
    }
}

