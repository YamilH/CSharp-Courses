using System;

namespace Ejercicio_3_5
{
    class Program
    {
        static void Main(string[] args)
    {

        // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

        Console.Write("Ingrese el primer número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        int n3 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el cuarto número: ");
        int n4 = int.Parse(Console.ReadLine());

        if (n1 > 100) Console.WriteLine("Número mayor a 100: " + n1);
        if (n2 > 100) Console.WriteLine("Número mayor a 100: " + n2);
        if (n3 > 100) Console.WriteLine("Número mayor a 100: " + n3);
        if (n4 > 100) Console.WriteLine("Número mayor a 100: " + n4);
    }
    }
}
