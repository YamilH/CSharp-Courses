using System;

namespace Ejercicio_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int n, con = 0;
        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            if(par(n))
                con++;
        }
        Console.WriteLine("La cantidad de numeros pares es: " + con);
        }

        static bool par(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
