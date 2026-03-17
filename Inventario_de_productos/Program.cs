// See https://aka.ms/new-console-template for more information
List<Producto> productos = new List<Producto>();
Console.Write("Cuantos productos desea ingresar:");
int cantidad = int.Parse(Console.ReadLine());
for (int i = 0; i < cantidad; i++)
{
    Producto p = new Producto();
    Console.Write($"\n{i+1}. Nombre del producto:");
    p.Nombre = Console.ReadLine();
    Console.Write("  Precio:Q");
    p.Precio = double.Parse(Console.ReadLine());
    Console.Write("  Cantidad:");
    p.Cantidad = int.Parse(Console.ReadLine());
    productos.Add(p);
}
class Producto
{
    public string Nombre;
    public double Precio;
    public int Cantidad;
    public double ValorTotal()
    {
        return Precio * Cantidad;
    }
    public string Stock()
    {
        if (Cantidad == 0)
        {
            return "Sin Existencia";
        }
        else if(Cantidad < 5)
        {
            return "Stock Bajo";
        }
        else
        {
            return "Stock Suficiente";
        }
    }
}
