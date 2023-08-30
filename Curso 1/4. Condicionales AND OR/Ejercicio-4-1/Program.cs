using System;

namespace Ejercicio_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            int resResta, resSuma, resMulti;
            Console.WriteLine("Ingrese un primer número");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            int n2 = int.Parse(Console.ReadLine());

            if(n1 > n2){
                resResta = n1 - n2;
                Console.WriteLine("Resultado resta: " + resResta);
            }
            else if(n1 == n2){
                resSuma = n1 + n2;
                Console.WriteLine("Resultado Suma: " + resSuma);
            }
            else if(n1 < n2){
                resMulti = n1 * n2;
                Console.WriteLine("Resultado Multi: " + resMulti);
            }
            else{
                Console.WriteLine("los parámetros no estan dados");
            }

        }
    }
}
