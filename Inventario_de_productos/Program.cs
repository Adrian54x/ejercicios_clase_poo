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
double valorTotalInventario = 0;
Producto mayorPrecio = productos[0];
Console.WriteLine("\nProductos ingresados:");
foreach(Producto p in productos)
{
    p.MostrarProductos();
    if (p.Precio > mayorPrecio.Precio)
    {
        mayorPrecio = p;
    }
    valorTotalInventario += p.ValorTotal();
}
Console.WriteLine($"\nValor total del inventario: Q{valorTotalInventario}");
Console.WriteLine("\nMayor precio:");
mayorPrecio.MostrarProductos();
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
    public void MostrarProductos()
    {
        Console.WriteLine($"\nNombre del producto:{Nombre} \nPrecio:Q{Precio} \nStock:{Stock()} \nValor total del producto:Q{ValorTotal():F2}");
    }
}
