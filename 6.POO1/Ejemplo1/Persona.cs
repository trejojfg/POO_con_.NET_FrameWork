using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        // - Persona: Edad, Sueldo, Nombre
        // la clase Persona puede tener varios ATRIBUTOS o MIEMBROS
        // la clase siempre tiene que cumplir con el ENCAPSULAMIENTO:
        // un atributo/miembro no puede ser accedido desde el exterior DIRECTAMENTE
        // para leer/escribir un atributo/miembro con los modificadores de visibilidad:
        // PRIVATE (sin acceso), PUBLIC (con acceso), PROTEGIDO y OTROS.
        // Luego se puede decidir si un atributo/miembro puede ser accedido desde fuera
        // con estos modificadores de visibilidad.

        private int edad;
        private float sueldo;
        private string nombre;

        // función para escribir un valor
        public void setEdad(int e)
        {
            edad = e;
        }
        // función para obtener un valor

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public int getEdad()
        {
            return edad;
        }

        // METODOS - son las funciones que se diseñan para los COMPORTAMIENTOS de un OBJETO

        public string saludar()
        {
            return "Hola soy...." + nombre;
        }



    }
}
