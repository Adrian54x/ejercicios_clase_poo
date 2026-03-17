// See https://aka.ms/new-console-template for more information
List<Producto> productos = new List<Producto>();
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
