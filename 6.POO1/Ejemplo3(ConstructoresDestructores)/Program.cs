using Ejemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3_ConstructoresDestructores_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLASES, OBJETOS, PROPIEDADES Y ENCAPSULAMIENTO

            // La clase se forma con "class + nombre_clase" y dentro de esta,
            // se introducen las funciones, entre ellas la principal MAIN, y dentro 
            // de las funciones, estaría la codificación de los algoritmos.

            Botella b1 = new Botella(); // new es cuando se invoca al CONSTRUCTOR "OBJECT" que es la clase madre y
                                        // crear la estancia en la memoria del objeto.
                                        // O con el constructur VACIO (Sobrecargado) tambien se usa así.
            b1.Capacidad = 200;
            // b1.Material = "azul";    // no se puede porque solo tiene propiedad de GET y no SET
            Botella b2 = new Botella("rojo","plástico"); // new con el nuevo CONSTRUCTOR predifinido y hereda todas
                                                         // las propiedades/funcionalidades de la clase Object.
            b2.Capacidad = 5;

            Console.ReadKey();

        }
    }
}