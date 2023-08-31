using System;

namespace Ejercicio_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
        // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int[] numeros = new int[10];
        for (int x = 0; x < 10; x++)
        {   
            Console.WriteLine("Ingrese un nro");
            numeros[x] = int.Parse(Console.ReadLine());
            //voy guardando hasta la posicion 9
        }
        //termina y tengo el vector cargado con los 10 elementos

        int max = numeros[0];
        int pos = 1;
        for (int x = 0; x < 10; x++)
        {
            if(numeros[x] > max){
                max = numeros[x];
                pos = x + 1;
            }
        }
        Console.WriteLine("El máximo es " + max);
        Console.WriteLine("Y su posición es " + pos);
        }
    }
}
