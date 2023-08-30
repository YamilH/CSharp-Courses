using System;

namespace Ejercicio_2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            // 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

            float nota1, nota2, nota3, promedioFinal;
            
            Console.WriteLine("Ingrese la nota de su primer exámen:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de su segundo exámen:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota de su tercer exámen:");
            nota3 = float.Parse(Console.ReadLine());

            promedioFinal = (nota1 + nota2 + nota3)/3;

            Console.WriteLine("Su sueldo final es: " + promedioFinal);
        }
    }
}
