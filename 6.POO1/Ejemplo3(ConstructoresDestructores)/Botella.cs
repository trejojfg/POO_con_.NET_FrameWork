using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        // - Botella: Capacidad, Color, Material
        
        private int capacidad;
        private string color;
        private string material;
         
        // CONTRUSTORES - son funciones para cargar los objetos desde un punto de
        // vista inicial que no es vacio. El primer constructor es OBJECT y de aqui
        // heredan todos los demás constructores. Para crear un constructor:
        public Botella (string color, string material) // recibe 2 parametros por referencia
        {
            this.color = color;
            this.material = material;
        }

        public string Material
        {
            get { return material; }
        }


        // para tener un CONSTRUCTOR VACIO, hay que SOBRECARGAR el Constructor. Se hace:

        public Botella() { }

        // DESTRUCTOR, no se usa casi nunga por el Garbage Collector (elimina todos los objetos
        // que ya no se usan en el programa)

        ~Botella() 
        {
            // se introduce la lógica del DESTRUCTOR.
        }


        // crear una PROPIEDAD
        
        public int Capacidad 
        {
            get { return capacidad; } 
            set { capacidad = value; } 
        } 


    }
}
