using System;

class Program
{
    static void Main()
    {
        int numero1 = 10;
        int numero2 = 5;

        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        int division = numero1 / numero2;

        Console.WriteLine("=== EJERCICIO 2 ===");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División: {division}");

        numero1 += 3;
        Console.WriteLine($"Nuevo valor de numero1 después de += 3: {numero1}");
    }
}
