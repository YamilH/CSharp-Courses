using System;

namespace Ejercicio_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
                Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine("Es mayor a 10");
            }
            else
            {
                Console.WriteLine("No es mayor a 10");
            }
        }
    }
}
