using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        // CLASES, OBJETOS, PROPIEDADES Y ENCAPSULAMIENTO

        // La clase se forma con "class + nombre_clase" y dentro de esta,
        // se introducen las funciones, entre ellas la principal MAIN, y dentro 
        // de las funciones, estaría la codificación de los algoritmos.

        static void Main(string[] args)
        {
            //  - Persona: Edad, Sueldo, Nombre

            //int Edad;
            //float Sueldo;
            //string Nombre;
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            //for (int x= 0; x < 10;x++){

                //Console.WriteLine("Introduce una edad");
                //edades[x] = int.Parse(Console.ReadLine());
                //Console.WriteLine("Introduce el sueldo");
                //sueldos[x] = float.Parse(Console.ReadLine());
                //Console.WriteLine("Introduce el Nombre");
                //nombres[x] = Console.ReadLine();
            //}

            //Console.ReadKey();

            Persona p1 = new Persona("Jose Juan");
            
            p1.setEdad(18);
            Console.WriteLine(p1.saludar());
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            // Botella b1 = new Botella();
            // b1.Capacidad = 200;

            // int leerbotella = b1.Capacidad;

            // Perro c1 = new Perro();
            // c1.setNombre(P);
            // Console.WriteLine("El nombre del perro es: " + c1.getNombre());


            Console.ReadKey();

        }
    }
}
