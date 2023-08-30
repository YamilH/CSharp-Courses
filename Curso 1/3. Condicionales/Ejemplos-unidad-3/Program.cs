using System;

namespace Ejemplos_unidad_3
{
    class Program
    {
        static void Main(string[] args)
        {
           //BLOQUE IF: Condicionales
           // > < >= <= == !=
           // valor OP valor
           // n1 > 10
           // 10 > 5 esto no

        int edad = 15;

        //    if(edad > 20){
        //       if(edad > 30){
        //         Console.WriteLine("30 off");
        //     }else{
        //     Console.WriteLine("21 OFF");
        //     }
        //    }else{
        //     Console.WriteLine("10 OFF");
        //    }


        if(edad > 30){
            Console.WriteLine("30 off");
        }else if(edad > 20){
            Console.WriteLine("20 off");
        }else if(edad == 18){
            Console.WriteLine("10 off");
        }else{
            Console.WriteLine("5 off");
        }
        
        }
    }
}
