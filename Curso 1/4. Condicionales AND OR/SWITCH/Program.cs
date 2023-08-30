using System;

namespace SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch
            //para trabajar con opciones concretas
        
        char letra = 'A';

            switch(letra){
                case 'M':
                    Console.WriteLine("es la letra M");
                    break;
                case 'H':
                    Console.WriteLine("es la letra M");
                    break;
                default:
                    Console.WriteLine("no coincide con ninguna");
                    break;
                
            }
        }
    }
}
