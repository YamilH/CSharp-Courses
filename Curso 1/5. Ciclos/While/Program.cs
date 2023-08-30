using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n, con = 0;
            // Console.WriteLine("Ingrese un N°");
            // n = int.Parse(Console.ReadLine());
            // while (n != 0){
            //     con++;
            //     Console.WriteLine("Ingrese un N°");
            //     n = int.Parse(Console.ReadLine());
            // }
            // Console.WriteLine("Ingresaste: " + con + "nrs.");

            int n, con = 0;

            while (con < 10){
                con++;
                Console.WriteLine(con);
            }
        }
    }
}
