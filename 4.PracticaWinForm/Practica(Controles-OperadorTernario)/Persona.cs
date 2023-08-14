using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Controles_OperadorTernario_
{
    internal class Persona
    {
        private string nombre;
        private string fecha;
        private int codigoNombreSocio;
        //private bool socio;
        private int cumpleaños;


        public Persona() { }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Fecha 
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int CodigoNombreSocio
        {
            get { return codigoNombreSocio; }
            set { codigoNombreSocio = value; }
        }
        //public bool Socio { get; set; }
        public string Edad { get; set; }

        public int Cumpleaños 
        { 
            get { return cumpleaños; }
            set { cumpleaños = value; } 
        }



    }
}
