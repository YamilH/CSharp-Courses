using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contacto;

            // Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
           Telefono tel1 = new Telefono("V3","Motorola");
            Console.WriteLine("Intrese su número de teléfono");
            tel1.NumeroTel = Console.ReadLine();
            Console.WriteLine("Ingrese el código de operador (1, 2 o 3)");
            tel1.CodigoOpe = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número de contacto");
            contacto = Console.ReadLine();

            Console.WriteLine("El número de teléfono ingresado es " + tel1.NumeroTel);
            Console.WriteLine(tel1.llamar(contacto));
            Console.WriteLine("El estado del telefono es: " + tel1.CodigoOpe);

            Console.ReadKey();
        }
    }
}
