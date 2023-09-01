using System;

namespace Ejercicio_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            int a = 0, b = 0, resultado;

            Console.WriteLine("Ingrese precio");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida");
            b = int.Parse(Console.ReadLine());

            resultado = Producto(a, b);

            Console.WriteLine("Monto a pagar: $" + resultado);


        }

        static int Producto(int a, int b)
        {
            int r;
            r = a * b;
            return r;
        }
    }
}
