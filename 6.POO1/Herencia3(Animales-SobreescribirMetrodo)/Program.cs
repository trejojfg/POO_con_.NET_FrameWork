using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Animales_SobreescribirMetrodo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AnimalDomestico a1 = new AnimalDomestico(); // sobreescritura del metodo ToString
            // a1.Nombre = "Pepe";
            Gato g1 = new Gato();
            g1.Nombre = "Pepe";
            Perro p1 = new Perro();
            p1.Nombre = "Negrito";

            //Console.WriteLine(g1.comunicarse());

            //Animal a1 = g1; // Se puede asignar una variable gato a una variable Animal
            //Gato g8 = (Gato)a1; // (Gato)a1  se usa para decirle al compilador que a1 tiene dentro
                                  // un gato y sus caracteristicas.

            //Console.WriteLine(g8.comunicarse());

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Canario());
            animales.Add(new Gato());
            animales.Add(new Tigre());
            animales.Add(g1);
            animales.Add(new Aguila());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse()); // POLIMORFISMO, es un objeto se comporta de manera
                                                       // distinta sobre un mismo estimulo:
                                                       // estimulo = comunicarse
                                                       // comportamiento = sonido diferente de cada objeto
            }


            // Esto es una lista por INTERFACE, donde no hace estancia de un Flayable, sino que
            // hace estancia de una collección

            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());
            //listaVoladores.Add(new Perro()); // Un perro no vuela, por lo que no puede unirse a la lista

            foreach (Flyable item in listaVoladores)
            {
                Console.WriteLine(item.volar());
            }

            Console.ReadKey();

        }
    }
}
