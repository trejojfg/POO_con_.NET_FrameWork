using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Animales_SobreescribirMetrodo_
{
    internal class Animal
    {
        // esta es la CLASE BASE y que heredan todas las demás.
        public virtual string comunicarse() // se pone "virtual" para que pueda ser sobreescrito
                                            // por la función override en la clase por familia
        {
            return "ruido....ruido.....";
        }

    }
}
