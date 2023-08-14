using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicionales

            int a = 10;
            int b = 12;
            // los operadores para armar una condicional  == != < > <= >=
            // Los operadores logicos son   !   &&   ||

            // IF

            if (a == b && b != 10 || !(a == 20))
            {
                Console.WriteLine("Se cumple...");
                // + instrucciones
            }
            else if (a == b && b != 12)
            {
                Console.WriteLine("NO se cumple...");
                // + instrucciones
            }
            else if (a == b && b != 10)
            {
                Console.WriteLine("NO se cumple...");
                // + instrucciones
            }
            else
            {
                Console.WriteLine("Se cumple todo...");
            }

            // SWITCH

            switch (a)
            {
                case 1:
                    // instrucciones
                    break;
                case 2:
                    // instrucciones
                    break;
                default:
                    // instrucciones
                    break;

            }

        }
    }
}
