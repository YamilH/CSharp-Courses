using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AnimalDomestico a1 = new AnimalDomestico();
            // a1.Nombre = "PEPE";
            
            Gato g1 = new Gato();
            g1.Nombre = "Rufi";

            Perro p1 = new Perro();
            p1.Nombre = "Laika";

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Tigre());
            animales.Add(new Gato());


            //Polimorfismo. frente a un mismo estimulo, responde de manera distinta
            foreach (Animal item in animales) 
            {
                Console.WriteLine(item.comunicarse());
            }



            // Animal a1 = g1;
            // Gato g8 = (Gato)a1;
            // Console.WriteLine(g1.Nombre);


            // Console.WriteLine(g1.comunicarse());
            // Console.WriteLine(p1.comunicarse());

            //interfaces
            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Aguila());


            Console.ReadKey();
        }
    }
}
