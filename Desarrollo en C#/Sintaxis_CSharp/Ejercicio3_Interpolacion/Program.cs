using System;

class Program
{
    static void Main()
    {
        string producto = "Laptop";
        double precio = 2500.50;
        int cantidad = 2;

        double total = precio * cantidad;

        Console.WriteLine("=== EJERCICIO 3 ===");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"Precio unitario: {precio}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Total a pagar: {total}");
    }
}
