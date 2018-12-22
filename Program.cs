using System;

// EJERCICIO 24. Programa que solicite la entrada un carácter por teclado hasta que se introduzca un punto ‘.’.
// En dicho momento deberá parar la ejecución.
// Mientras no se introduzca el punto, para cada letra introducida deberá informar si es un dígito(0 a 9), 
// un carácter alfabético(a..z / A..Z). 
// Utiliza una función tipoCaracter que reciba el carácter y devuelva si es dígito, alfabético u otro.

namespace EJ24
{
    class Program
    {
        
        private static string TipoCaracter(char car)
        {  
           if (car >= '0' && car <= '9')  // Si es digito
                return " --> Es un dígito";
            else if ((car >= 'a' && car <= 'z') || (car >= 'A' && car <= 'Z'))  // si es carácter
                return " --> Es una letra";
            else
                return " --> No es ni letra ni dígito";   // Ni letra ni caracter 
        }

        static void Main(string[] args)
        {
            char caracter;

            Console.WriteLine("Introduce carácteres (para finalizar '.' (punto)): ");
            do
            {
                caracter = Console.ReadKey().KeyChar;
                if (caracter!='.')
                    Console.WriteLine(TipoCaracter(caracter));
            } while (caracter != '.');
        }
    }
}
