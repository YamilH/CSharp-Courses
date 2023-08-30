using System;

namespace Ejercicio_3_4
{
    class Program
    {
        static void Main(string[] args)
        {

           // 4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
           
            Console.WriteLine("Ingrese el primer numero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero: ");
            int n4 = int.Parse(Console.ReadLine());

            int numChico = n1;
            if (n2 < numChico)
            {
                numChico = n2;
            }
            if (n3 < numChico)
            {
                numChico = n3;
            }
            if (n4 < numChico)
            {
                numChico = n4;
            }
             Console.WriteLine($"El menor número es: {numChico}");
        }
    }
}
