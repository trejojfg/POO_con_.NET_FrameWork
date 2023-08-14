using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_ArticulosVenta_
{
    internal class Articulo
    {
        // Primer lote con 10 registros de prodcutos, cada producto tiene:
        //  - Código Artículo (3 dígitos no correlativos)
        //  - Precio
        //  - Código de Marca (1 a 10)

        // private int codigoArticulo;
        public int CodigoArticulo { get; set; }

        // private float precio;
        public float Precio { get; set; }

        private int codMarca; // int codMarca;
        public int CodigoMarca  // int CodigoMarca;
        {
            get { return codMarca; } // MOSTRAR con GET:  return codMarca;
            set{                     // LEER/ESCRIBIR con SET: codMarca = value;
                if (value > 0 && value < 11){
                    codMarca = value;
                }
                else{
                    codMarca = -1;
                }
            }
        }




    }
}
