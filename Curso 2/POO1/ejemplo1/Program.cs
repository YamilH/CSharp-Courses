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
       
            Persona p1 = new Persona("Pepe");
            p1.setEdad(20);

            Console.WriteLine(p1.saludar());
            Console.WriteLine("la edad de la persona es: " + p1.getEdad());

            Botella b1 = new Botella("Rojo", "Plástico");
     //       b1.Capacidad = 200;

     //       Botella b2 = new Botella();

            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es " + b1.CantidadActual);
            b1.recargar();
            Console.WriteLine("Luego de recargar, La cantidad actual es " + b1.CantidadActual);


            int algo = b1.Capacidad;


            Perro pe1 = new Perro();
            pe1.Nombre = "Tito";
            string something = pe1.Nombre;


            Console.ReadKey();

        }
    }
}
