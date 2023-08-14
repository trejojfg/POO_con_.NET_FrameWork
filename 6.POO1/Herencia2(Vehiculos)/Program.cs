using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2_Vehiculos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehículo  > Auto  > AutoDeportivo  > AutoUrbano
            //           > Camiioneta
            //           > Moto

            Vehiculo v1 = new Vehiculo();
            //v1.Motor;
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            //c1.Motor;
            //c1.CargaMaxima;
            c1.Color = "Amarillo";
            c2.Color = "Roja";
            c3.Color = "Blanca";
            // Vehiculo v2 = new Camioneta(); // Una camioneta es un vehículo (se puede guardar un objeto
                                           // Camioneta dentro de un Vehiculo), ya que son familia.
            // Camioneta c2 = new Auto(); // NO puede ser porque un Auto no es un Vehiculo (no son famlia)

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);
            //listaCamionetas[1].Color = "negro"; // cambia a negro pq lo cambio en la lista y esta
            //                                   // referenciada al objeto.
            //c2.Color = "verde"; // Tambien lo cambia a verde pq c2 tiene referencia del objeto y
            //                    // a la lista.
            //Console.WriteLine("El color es: " + listaCamionetas[1].Color);

            listaCamionetas.Remove(c2);
            
            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);

            foreach (Camioneta item in listaCamionetas) // Es un for para una Coleccion
            {
                Console.WriteLine("Color: " + item.Color);
            }
            
            // asociacion por Agregación:
            Auto a1 = new Auto(); // Se crea el Auto pero sin motor

            a1.Motor = new Motor(); // se le agrega al Auto el motor



            Console.ReadKey();
        }
    }
}
