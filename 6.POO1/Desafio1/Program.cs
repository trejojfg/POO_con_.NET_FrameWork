using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Crear la clase Telefono.
            // 2.Agregale los siguientes atributos:
            //  - Modelo string.
            //  - Marca string.
            //  - NumeroTelefonico string.
            //  - CodigoOperador int (1, 2 o 3).

            // 3.Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
            //  - Modelo: solo lectura. Es decir, solo get.
            //  - Marca: solo lectura.
            //  - NumeroTelefonico: lectura y escritura.
            //  - CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3,
            //    caso contrario escribir un cero.
            // 4.Agregar Constructor que reciba Modelo y Marca.
            // 5.Crear algunos objetos en el main de Program y probar escribirle datos y mostrar
            //   en pantalla el estado del Telefono.
            // 6.Agregar método Llamar() sin parámetros que devuelva un string
            //   con la leyenda "Realizando llamada...".
            // 7.Sobrecargar el método Llamar(string contacto) para que reciba un contacto
            //   y devuelva un string con la leyenda "Llamando a " + contacto
            // 8.Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

            Telefono t1 = new Telefono("T4-2023AB", "Wonka");
            //Telefono t2 = new Telefono();

            Console.WriteLine("Hola amig@, ¿cómo estas?");
            Console.WriteLine("¿Me indicas tu nombre?");
            t1.Nombre = Console.ReadLine();
            Console.WriteLine (t1.saludar());
            Console.WriteLine("Por favor, introduces tu numero tlf.: ");
            t1.NumeroTlf = Console.ReadLine();
            Console.WriteLine("En la base de datos con el tlf. " + t1.NumeroTlf + ", salen los siguientes datos:");
            Console.WriteLine("Modelo: " + t1.Modelo);
            Console.WriteLine("Marca: " + t1.Marca);
            Console.ReadKey();
            Console.WriteLine("Vamos a probar a hacer alguna llamada");
            Console.WriteLine("Selecciona el Código Operador: ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            if (t1.CodigoOperador != 0)
            {
                Console.WriteLine("Di el contacto de tu agenda que quieres llamar");
                t1.Contacto = Console.ReadLine();
                Console.WriteLine(t1.llamar(t1.Contacto));

            }else{
                Console.WriteLine("Indica el numero de tlf. al que llamar");
                t1.NumeroTlfContacto = Console.ReadLine();
                Console.WriteLine(t1.llamar());
            }
            
            Console.ReadKey();



        }
    }
}
