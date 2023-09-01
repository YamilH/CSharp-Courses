using System;

namespace Parametros
{
    class Program
    {
        static void Main(string[] args)
        {

             int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);

            resultado = sumar(n1, n2);

            Console.WriteLine("El resultado es: " + resultado);
            Console.WriteLine("Contenido de variable n1 es: " + n1);

        }

        static int sumar(int a, int b)
        {
            int r;
            r = a + b;
            a = 9999; //esto solo esta en el espacio de memoria de esta funcion, el main lo pisa
            return r;
        }

        static void pedirDatos(ref int j, ref int h)
        {
            Console.WriteLine("ingrese un nro");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro ");
            h = int.Parse(Console.ReadLine());            
        }

    }
}
