using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Perro
    {
        //- Perro: Nombre, Color, Origen
        private string nombre;
        private string color;
        private string origen;

        public void setNombre (string n1)
        {
            nombre = n1;
        }
        public string getNombre ()
        {
            return nombre;
        }
    }
}
