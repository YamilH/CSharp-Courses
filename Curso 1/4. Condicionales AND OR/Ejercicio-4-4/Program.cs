using System;

namespace Ejercicio_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
           // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

           int n1, n2, n3, suma, producto;

            Console.WriteLine("Ingrese el 1er número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 3er número");
            n3 = int.Parse(Console.ReadLine());

            suma = n1 + n2;
            producto = n2 * n3;

            if (suma > producto)
                Console.WriteLine("La suma de los dos primeros números es mayor al producto del segundo y el tercer número.");

            Console.WriteLine("Programa Terminado.");
            
        }
    }
}
