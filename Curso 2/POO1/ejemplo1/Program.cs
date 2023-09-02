using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clases, Objetos y Propiedades. Encapsulamiento.
       
            Persona p1 = new Persona();
            p1.setEdad(20);

            Console.WriteLine("la edad de la persona es: " + p1.getEdad());

            Botella b1 = new Botella();
            b1.Capacidad = 200;

            int algo = b1.Capacidad;


            Perro pe1 = new Perro();
            pe1.Nombre = "Tito";
            string something = pe1.Nombre;


            Console.ReadKey();

        }
    }
}
