using System;

namespace Ejercicio_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
        // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        // - Número de Artículo (1 a 15)
        // - Cantidad Vendida 

        // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        // Se pide determinar e informar:
        // a) El número de artículo que más se vendió en total.
        // b) Los números de artículos que no registraron ventas.
        // c) Cuantas unidades se vendieron del número de artículo 10.

        int nroArticulo;
        int cantidad;
        int[] totalCantidadVendida = new int[15];
        for (int x = 0; x < length; x++)
        {
            totalCantidadVendida[x] = 0;
        }

        Console.WriteLine("Ingrese el nro de artículo");
        nroArticulo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida");
        cantidad = int.Parse(Console.ReadLine());

        while (nroArticulo != 0)
        {
            totalCantidadVendida[nroArticulo - 1] += cantidad;

            Console.WriteLine("Ingrese el nro de artículo");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());
        }

        // terminado ciclo de carga de ventas

        //punto A

        int maxCantidad = totalCantidadVendida[0];
        int nroMaximo = 1;
        for (int x = 0; x < length; x++)
        {
            if (totalCantidadVendida[x] > maxCantidad){
                maxCantidad = totalCantidadVendida[x];
                nroArticulo = x + 1;
            }
        }
        Console.WriteLine("El producto mas vendio es el: " + nroArticulo + " con la cantidad de " + maxCantidad);

        // punto B

        for (int x = 0; x < length; x++)
        {
            if(totalCantidadVendida[x] == 0){
                Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas");
            }
        }

        // punto C

        Console.WriteLine("La cantidad vendida del articulo 10 es: " + totalCantidadVendida[9]);


        }
    }
}
