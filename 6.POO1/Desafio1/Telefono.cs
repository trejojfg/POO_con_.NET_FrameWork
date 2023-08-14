using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        // 1.Crear la clase Telefono.
        // 2.Agregale los siguientes atributos:
        //  - Modelo string.
        //  - Marca string.
        //  - NumeroTelefonico string.
        //  - CodigoOperador int (1, 2 o 3).

        // 3.Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
        //  - Modelo: solo lectura. Es decir, solo get.
        //  - Marca: solo lectura.
        //  - NumeroTelefonico: lectura y escritura.
        //  - CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3,
        //    caso contrario escribir un cero.
        // 4.Agregar Constructor que reciba Modelo y Marca.
        // 5.Crear algunos objetos en el main de Program y probar escribirle datos y mostrar
        //   en pantalla el estado del Telefono.
        // 6.Agregar método Llamar() sin parámetros que devuelva un string
        //   con la leyenda "Realizando llamada...".
        // 7.Sobrecargar el método Llamar(string contacto) para que reciba un contacto
        //   y devuelva un string con la leyenda "Llamando a " + contacto
        // 8.Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

        // ATRIBUTOS
        private string modelo;
        private string marca;
        private string numeroTlf;
        private int codigoOperador;
        private string nombre;
        private string contacto;
        private string numeroTlfContacto;

        // PROPIEDADES
        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTlf { get; set; }

        public int CodigoOperador{

            get { return codigoOperador; }
            set { 
                if (value > 0 && value <= 3)
                    codigoOperador = value; 
                else
                    codigoOperador = 0;
            }
        }

        public string Nombre { 
            get { return nombre; }
            set { nombre = value; }
        }
        public string Contacto{
            get { return contacto; }
            set { contacto = value; }
        }
        public string NumeroTlfContacto 
        {
            get { return numeroTlfContacto; }
            set { numeroTlfContacto = value; }  
        }

        // CONSTRUCTORES

        public Telefono(string modelo, string marca) 
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        public Telefono() { }

        // METODOS
        public string saludar()
        {
            return "Magnífico, " + nombre + "!!!!!!!";
        }
        public string llamar()
        {
            return "Realizando llamada a " + numeroTlfContacto + "....";
        }
        public string llamar(string contacto)
        {
            return "llamando a " + contacto;
        }


    }
}
