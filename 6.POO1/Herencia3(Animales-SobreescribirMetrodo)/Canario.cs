using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Animales_SobreescribirMetrodo_
{
    internal class Canario : AnimalDomestico, Flyable
    {
        public override string comunicarse()  // se sobreescribe el metodo "comunicarse" que es base
        {
            return "Pio..... pio.......";  // ya no pone "ruido....ruido...." al override
        }

        public string volar()
        {
            return "sabe volar como un canario";
        }
    }
}
