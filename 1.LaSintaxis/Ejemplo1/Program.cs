using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - Declaracion de VARIABLES
            // Los tipos de variables son int, float, bool, char
            // Hay otros como double, decimal, long, short, string, datetime

            int a, b, c;
            float d, f;

            Console.WriteLine("Hola Cómo va?");
            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());
            b = 10;
            c = a + b;


            Console.WriteLine("El resultado es: " + c);
            Console.ReadKey();
        }
    }
}
