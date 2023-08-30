using System;

namespace CorteDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // CORTE DE CONTROL

            //legajo, edad, sueldo, codigo de equipo(númerico)
            int legajo, edad, codigoEquipo, equipoActual;
            float sueldo;
            
            Console.WriteLine("Ingrese el legajo");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo");
            codigoEquipo = int.Parse(Console.ReadLine());

            while (sueldo > 0)
            {
                equipoActual = codigoEquipo;
                while (codigoEquipo == equipoActual)
                {
                Console.WriteLine("Ingrese el legajo");
                legajo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la edad");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el sueldo");
                sueldo = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el código de equipo");
                codigoEquipo = int.Parse(Console.ReadLine());

                //aca se puede mostrar resultados
                //

                }
                //  aca tbm se puede mostrar lo que se necesite mostrar
            }
            // aca tbm 
        }
    }
}
