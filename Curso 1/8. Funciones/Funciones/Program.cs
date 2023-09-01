using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Funciones Introducción
            // Partes de la funcion:
            // Cabecera
            // 1. Tipo de Dato (void)
            // 2. Nombre (Main)
            // 3. Opcional. Parámetros (string)
            // Cuerpo (dentro de la llave)
            // Definición/Lógica
            // Opcional: retorno de valor/resultado


            Console.WriteLine("Fin del Programa " + devolverUno());

            int n = devolverUno();
            Console.WriteLine("Fin del Programa " + n);
            
            int n1, n2, resultado;
            Console.WriteLine("ingrese un nro");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro ");
            n2 = int.Parse(Console.ReadLine());

            resultado = sumar(n1, n2);

            Console.WriteLine("Fin del Programa " + resultado);
        }

        static int devolverUno()
        {
            int nro = 15;
            return nro;
        }

        static int sumar(int a, int b)
        {
            int r;
            r = a + b + 2;
            return r;
        }


    }
}
