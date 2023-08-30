using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            do{
                Console.WriteLine("Ingrese N°:");
                n = int.Parse(Console.ReadLine());
            }while(n != 0);

            Console.WriteLine("Ingresaste " + con + "nros.");
        }
    }
}
