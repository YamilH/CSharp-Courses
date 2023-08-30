using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialización.
            // Condición.
            // Incremento.

            // for(int i = 0; i < 5; i++ ){
            //     Console.WriteLine("Prueba For N°" + i);
            // }

            int n = 0, promedio, suma = 0;

            for (int x = 0; x < 5; x++)
            {
            Console.WriteLine("Ingrese la nota:");
            n = int.Parse(Console.ReadLine());
            suma += n;
            }
            promedio = suma / 5;
            Console.WriteLine("El promedio de notas es: " + promedio);
        }
    }
}
