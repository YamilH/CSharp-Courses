using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "Gris";
            c2.Color = "Blanca";
            c3.Color = "Azul";

            Vehiculo v2 = new Camioneta();

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            // Console.WriteLine("La cantidad de camiones es: " + listaCamionetas.Count);
            // c2.Color = "Verde";
            // Console.WriteLine("El color es: " + listaCamionetas[1].Color);
            // listaCamionetas.Remove(c3);
            // Console.WriteLine("La cantidad de camiones es: " + listaCamionetas.Count);

            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
            }

            Auto a1 = new Auto();

            a1.Motor = new Motor();


            Console.ReadKey();

        }
    }
}
