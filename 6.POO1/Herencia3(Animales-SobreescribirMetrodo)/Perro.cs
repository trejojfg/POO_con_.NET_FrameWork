using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Animales_SobreescribirMetrodo_
{
    internal class Perro : AnimalDomestico
    {
        public override string comunicarse()  // se sobreescribe el metodo "comunicarse" que es base
        {
            return "guau guau ......."; // ya no pone "ruido....ruido...." al override
        }
    }
}
