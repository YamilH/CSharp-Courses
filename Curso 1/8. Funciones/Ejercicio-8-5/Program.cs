using System;

namespace Ejercicio_8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("nro1");
            // int a = int.Parse(Console.ReadLine());
            // Console.WriteLine("nro2");
            // int b = int.Parse(Console.ReadLine());

            // Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref b));
            // Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref b));
            // Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref b));


        int n;
        int suma;

        for (int x = 0; x < 3; x++)
        {
            n = int.Parse(Console.ReadLine());
            suma = 0;

            while (n != 0)
            {
                suma += n + 5;
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La suma de la vuelta " + (x + 1) + " fue de: " + suma);
        }


        

        // static int haceAlgo2(ref int numero, ref int numero2)
        // {
        //     int res;
        //     numero  = numero * 2;
        //     numero2 = numero2 * 3;

        //     res = numero * numero2;

        //     return res;
        // }


    }}
}
