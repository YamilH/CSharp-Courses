using System;

namespace CadenaDeCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            // CADENA DE CARACTERES
            // char[] cadena = char[10];
            // BARRA CERO (caracter especial)
            // \0  le da fin a una cadena de caracteres
            // frase[5] = '\0';

            // |H|O|L|A| |Q|U|E| |T|A|L|?|\0| | | | | | | | 

            //no es lo mismo un string que una cadena de caracteres que un vector de char.



            char[] nombre = new char[10];

            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese su nombre letra por letra");
            Console.WriteLine("Ponga un punto para finalizar.");
            letra = char.Parse(Console.ReadLine());

            while(letra != '.' && indice < 10)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }
            if(indice == 10)
                indice--;

            nombre[indice] = '\0';

            //|y|a|m|i|\0| | | | | |


            Console.Write("Hola ");
            indice = 0;
            while (nombre[indice] != '\0')
            {
                Console.Write(nombre[indice]);
                indice++;
            }


            //este es el futuro
            // string nombre;
            // Console.WriteLine("ingrese su nombre...");
            // nombre = Console.ReadLine();
            // Console.WriteLine("Hola " + nombre);

        }
    }
}
