using System;

namespace Ejercicio_2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            // 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            int sueldoFijo;
            double facturado, comisionFinal, sueldoFinal;
            
            Console.WriteLine("Ingrese Facturación:");
            facturado = double.Parse(Console.ReadLine());

            comisionFinal = facturado * 0.05;
            sueldoFinal = 15000 + comisionFinal;

            Console.WriteLine("Su sueldo final es: " + sueldoFinal);
        }
    }
}
