using System;

namespace AND_OR
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND y OR ........ NOT
            // AND [y] Operador: &&
            // OR [o] Operador: ||
            // NOT Operador: !
            // v OP v OR v OP v

            int edad = 20;
            char inicial = 'J';

            if(!( inicial == 'J' || inicial == 'H') && edad > 20){
                    Console.WriteLine("21 OFF...");
            }
            Console.WriteLine("Fin de Programa");
        }
    }
}
