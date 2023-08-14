using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2_Vehiculos_
{
    internal class Auto : Vehiculo
    {
        // propiedades - 

        public Auto() // esto es el constructor del Auto
        {
            Chasis= new Chasis(); // asi obligamos a que el Auto nace con el Chasis.
        }
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        // Hay 2 tipos de ASOCIACIONES

        // 1 - COMPOSICION - la clase nace con esto

        public Chasis Chasis { get; } // El objeto Auto NACE con un objeto CHASIS y no se le puede
                                      // cambiar, asi se quita el set.  

        // 2 - AGREGACION
        public Motor Motor { get; set; } // El AUTO no nace con un motor, sino que se le incluye
                                         // posteriormente, o se le cambia,....El Auto tiene como
                                         // propiedad el objeto MOTOR.


    }
}
