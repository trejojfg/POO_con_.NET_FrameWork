using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FUNCIONES

            // Siempre se crean fueran de la funcion MAIN

            int a = 5;
            int b = 10;
            int resultado;
            string persona = saludar("Juanfi");

            Console.WriteLine(persona);
            Console.ReadKey();

            Console.WriteLine("El primer numero es..." +  a);
            Console.WriteLine("El segundo numero es..." +  b);
            Console.ReadKey();
            resultado = sumar(a, ref b);
            Console.WriteLine("El todal es: " + resultado);
            Console.ReadKey();
        }

        // Se pone la palabra STATIC en las funciones

        static int sumar(int a, ref int b)
        {
            return a + b;
        }
        static string saludar(string nombre)
        {
            return "hola " + nombre;
        }

    }
}
