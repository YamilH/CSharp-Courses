using System;

namespace Ejercicio_4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
            
            Console.WriteLine("Ingrese litros: ");
            int litros = int.Parse(Console.ReadLine());

            if (litros > 500)
            {
                Console.WriteLine("25% off");
            }
            else if(litros >= 301)
            {
                Console.WriteLine("15% off");
            }
            else if(litros >= 101)
            {
                Console.WriteLine("10% off");
            }
            else
            {
                Console.WriteLine("No hay descuento");
            }
        }
    }
}
