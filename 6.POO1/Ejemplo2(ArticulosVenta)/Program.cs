using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_ArticulosVenta_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer lote con 10 registros de prodcutos, cada producto tiene:
            //  - Código Artículo (3 dígitos no correlativos)
            //  - Precio
            //  - Código de Marca (1 a 10)
            // Segundo lote con las ventas de la semana. Cada venta tiene:
            //  - Código Artículo
            //  - Cantidad
            //  - Código Cliente (1 a 100)
            // Este lote corta con Código Cliente igual a cero.

            // para la carga del lote:

            // Articulo a1 = new Articulo(); // damos alta la variable "a1" dentro del objeto/clase - Artículo .
            // a1.CodigoMarca = 12           // ingresamos manualmente para evaluar la condicion de CodigoMarca.

            Articulo[] articulos = new Articulo[10]; // damos alta al vector para guardar los 10
                                                     // tipos de articulos con sus 3 propiedades.
            for (int x = 0; x < 10; x++){
                articulos[x] = new Articulo(); // el vector está vacío. Es decir, yo reservo espacio
                                               // de memoria para guardar 10 artículos, pero en cada
                                               // espacio de memoria no hay nada, entonces antes de
                                               // poder guardar un dato a un artículo X, tengo que
                                               // crear ese artículo invocando al constructor con NEW.

                Console.WriteLine("Ingrese los datos del artículo: ");
                Console.WriteLine("Código:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca:");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            
                // aquí estaría cargado el vector con los 10 artículos y sus 3 propiedades.
            }


            // para la venta:

            Venta venta = new Venta(); // damos de alta la variable venta dentro de la clase Venta.

            Console.WriteLine("Ingrese los datos de la venta:");
            Console.WriteLine("Cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while(venta.CodigoCliente !=0) {

                Console.WriteLine("Código");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // trabajamos con los datos introducidos de la venta

                // pedimos nuevamente un nuevo cliente
                Console.WriteLine("Ingrese otra venta o cero para terminar:");
                Console.WriteLine("Cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }

            Console.ReadKey();

        }
    }
}
