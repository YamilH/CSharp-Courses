using System;

namespace Ejercicio_2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            int n1, resultado;

            Console.WriteLine("Ingrese un número:");
            n1 = int.Parse(Console.ReadLine());

            resultado = n1 * n1 * n1;

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
