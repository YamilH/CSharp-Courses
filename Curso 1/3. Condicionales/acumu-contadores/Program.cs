using System;

namespace acumu_contadores
{
    class Program
    {
        static void Main(string[] args)
        {
           //Acumuladores y Contadores;
        //    int contador = 0, e1 = 20, e2 = 30, e3 = 15;

            // contador = contador + 1	
            //++
            //--

        //    if(e1 > 18)
        //         contador = contador + 1;
        //    if(e2 > 18)
        //         contador = contador + 1;
        //    if(e3 > 18)
        //         contador = contador + 1;
        
        // Console.WriteLine("El conteo es: " + contador);

            int contador = 0, e1 = 20, e2 = 25, e3 = 30;
            int acumulador = 0, promedio;

            if(e1 > 18){
                contador++;
                acumulador += e1;
            }
            if(e2 > 18){
                contador = contador + 1;
                acumulador = acumulador + e2;
            }
            if(e3 > 18){
                contador = contador + 1;
                acumulador += e3;
            }

            // Console.WriteLine("El conteo es: " + contador);

            promedio = acumulador / contador;
            Console.WriteLine("El promedio es: " + promedio);
        
        }
    }
}
