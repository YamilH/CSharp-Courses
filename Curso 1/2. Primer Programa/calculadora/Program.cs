using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
            // tipo de dato: int entero, float numeros con coma, char letra, bool
            int n1, n2, resultado;
            
            // pedir valores
            Console.WriteLine("Ingrese un número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            n2 = int.Parse(Console.ReadLine());

            // realizar calculo
            resultado = n1 + n2;

            // emitir resultado

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
