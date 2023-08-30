using System;

namespace CiclosCombinados
{
    class Program
    {
        static void Main(string[] args)
        {
        // Ciclos Combinados;
        // FOR CON FOR,

        // int prom, acu, n;

        // for (int y = 0; y < 10; y++)
        // {
        //     acu = 0;
        //     for (int x = 0; x < 20; x++){
        //         Console.WriteLine("Ingrese la edad: ");
        //         n = int.Parse(Console.ReadLine());
        //         acu += n;
        //     }
        // prom = acu / 20;
        // Console.WriteLine("El promedio es: " + prom);
        // }


        // FOR CON WHILE

            // int prom, acu, n, con;

            // for(int x = 0; x < 10; x++){

            //     Console.WriteLine("Ingrese la edad: ");
            //     n = int.Parse(Console.ReadLine());
            //     acu = 0;
            //     con = 0;
            //     while(n != 0){
            //         acu += n;
            //         con++;
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     prom = acu / con;
            //     Console.WriteLine("El promedio es: " + prom);

            // }

            // WHILE CON FOR

            // int prom, acu, n;

            // Console.WriteLine("Ingrese 1 para comenzar o 2 para terminar");
            // n = int.Parse(Console.ReadLine());

            // while(n != 0){
            //     acu = 0;
            //     for (int x = 0; x < 20; x++){
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     prom = acu / 20;
            //     Console.WriteLine("El promedio es: " + prom);
            //     Console.WriteLine("Ingrese 1 para comenzar o 2 para terminar");
            //     n = int.Parse(Console.ReadLine());

            // }

            // WHILE CON WHILE (comun en corte de control)

            int prom, acu, n, con;

            Console.WriteLine("Ingrese la edad: ");
            n = int.Parse(Console.ReadLine());
            while (n >= 0 && n != 0){
                
                acu = 0;
                con = 0;
                while(n != 0){
                    acu += n;
                    con++;
                    Console.WriteLine("Ingrese la edad: ");
                        n = int.Parse(Console.ReadLine());
                }
                prom = acu / con;
                Console.WriteLine("El promedio es: " + prom);

                Console.WriteLine("Ingrese la edad para continuar o un negativo para cortar: ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
