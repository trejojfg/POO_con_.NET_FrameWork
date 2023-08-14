using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_ArticulosVenta_
{
    internal class Venta
    {
        // Segundo lote con las ventas de la semana. Cada venta tiene:
        //  - Código Artículo
        //  - Cantidad
        //  - Código Cliente (1 a 100)

        public int CodigoArticulo { get; set; }

        public int Cantidad { get; set; }

        public int CodigoCliente { get; set; }

    }
}
