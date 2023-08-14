using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3_Animales_SobreescribirMetrodo_
{
    internal class AnimalDomestico : Animal
    {
        // propiedad
        public string Nombre { get; set; }

        // metodo
        public override string ToString()
        {
            return "Animal Doméstico: " + Nombre;
        }


    }
}
