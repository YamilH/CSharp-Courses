using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, contadorNumeros, contadorImpares, grupoImparesMaximo = -1, min, contadorOrdenados = 0;
            double porcentajeImpares, porcentajeMaximo=-1;
            bool banderaOrdenados;

            for (int x = 0; x < 5; x++)
            {
                contadorNumeros = 0;
                contadorImpares = 0;
                banderaOrdenados = true;
                n = int.Parse(Console.ReadLine());
                min = n;
                while (n != 0 )
                {
                    contadorNumeros++;
                    if(n % 2 != 0)
                        contadorImpares++;

                    //punto B
                    if(n <= min)
                        min = n;
                    else
                        banderaOrdenados = false;

                    n = int.Parse(Console.ReadLine());
                }//fin del while

                porcentajeImpares = contadorImpares * 100 / contadorNumeros;

                if(porcentajeImpares > porcentajeMaximo){
                    porcentajeMaximo = porcentajeImpares;

                    grupoImparesMaximo = x + 1;
                }
                //punto B
                if(banderaOrdenados)
                    contadorOrdenados++;


            }//fil del for

            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);

            Console.WriteLine("La cantidad de grupos con nros ordenados es: " + contadorOrdenados);
        }
    }
}
