using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vectores. Array. Arreglo.
            // Variable especial, dimensional, me permite darle un tamaño.

            int n;
            int[] numeros = new int[10];
            //  0 1 2 3 4 5 6 7 8 9
            // |7| | | | | |1| | |345|

            // numeros[6] = 1;
            // numeros[0] = 7;
            // numeros[9] = 345;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la nota..");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
            }

            int acu = 0;

            for (int x = 0; x < 10; x++)
            {
                acu += numeros[x];
                Console.WriteLine(numeros[x]);
            }

            int prom = acu / 10;
   

        }
    }
}
