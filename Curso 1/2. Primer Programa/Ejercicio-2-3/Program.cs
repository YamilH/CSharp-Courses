using System;

namespace Ejercicio_2_3
{
    class Program
    {
        static void Main(string[] args)
        
        {

            // 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

            double kilometros, velocidad, tiempo;
            
            Console.WriteLine("Ingrese la distancia en kilómetros:");
            kilometros = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese la velocidad promedio en km/h:");
            velocidad = double.Parse(Console.ReadLine());

            tiempo = kilometros / velocidad;

            Console.WriteLine("Tiempo aproximado de viaje: " + tiempo + " horas");
        }
        
    }
}
