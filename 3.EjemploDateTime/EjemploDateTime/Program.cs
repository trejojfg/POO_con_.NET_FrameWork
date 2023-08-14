using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // La 1º manera es llamar al Constructor DateTime (tiene muchas opciones ya que
            // esta sobrecargado) y se elige la que se necesite. Si lo dejas sin referencias,
            // te mostrará la fecha y hora más baja que tiene (01/01/0001 0:00:00).
            
            DateTime fecha1 = new DateTime(2004, 4, 1);

            Console.WriteLine("La fecha es: " + fecha1.ToString());

            // La 2º manera es SIN llamar al Contructor DateTime.

            DateTime fecha2 = DateTime.Now; // fecha actual.

            Console.WriteLine("La fecha y hora actual es: " + fecha2.ToString());// Genera la fecha y hora como String.

            Console.WriteLine("Pasado 5 días, la fecha y hora son: " + fecha2.AddDays(5));// Añade 5 días a la fecha actual.
            
            Console.WriteLine("La fecha es: " + fecha2.ToShortDateString());// muestra solo la fecha, NO la hora.

            Console.WriteLine("La hora es: " + fecha2.ToShortTimeString());// muestra solo la hora, NO la fecha.

            // Para cambiar el FORMATO de la fecha u hora, es con la sobrecarga del
            // método ToString, ya que tiene muchas sobrecargas.

            Console.WriteLine("La fecha es: " + fecha2.ToString("dd/MM/yy"));
            Console.WriteLine("La fecha es: " + fecha2.ToString("dd/MM/yyyy"));
            Console.WriteLine("La fecha es: " + fecha2.ToString("dddd MM/yy"));
            Console.WriteLine("La fecha es: " + fecha2.ToString("dd/MMM/yy"));
            Console.WriteLine("La fecha es: " + fecha2.ToString("dd/MMMM/yy"));

            Console.ReadKey();
        }
    }
}
