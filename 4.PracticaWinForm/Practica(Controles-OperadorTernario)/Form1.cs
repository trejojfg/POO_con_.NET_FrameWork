using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Controles_OperadorTernario_
{
    public partial class practica1 : Form
    {
        public practica1()
        {
            InitializeComponent();
        }

        int codigoNumeroSocio = 0;
        // DateTime FechaHora = DateTime.Now;
        
        Persona p1 = new Persona();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            p1.Nombre = txtNombre.Text;
            DateTime FechaIntroducida;
            FechaIntroducida = dtpFecha.Value;
            p1.Fecha = dtpFecha.Text;

            if (chbSocio.Checked == true)
            { 
                p1.CodigoNombreSocio = codigoNumeroSocio++;
                lblNumeroCodigoNombre.Text = p1.CodigoNombreSocio.ToString("000");
                lwListaNombres.Items.Add(p1.CodigoNombreSocio.ToString("000"));
                lwListaNombres.Items.Add(p1.Nombre);
            }
            else
                return;

            if (rbEdadMenor.Checked == true)
                p1.Edad = "Menor de Edad";
            else if (rbEdadMayor.Checked == true)
                p1.Edad = "Mayor de Edad";
            else
                p1.Edad = "Jubilado";

            if (FechaIntroducida < DateTime.Now)
            {
                p1.Cumpleaños = DateTime.Now.Year - FechaIntroducida.Year;
                lblTuEdadAnio.Text = p1.Cumpleaños.ToString();
            }

        }

        //private void practica1_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Bienvenido a la nueva APP");

        //}

        //private void practica1_closing(object sender, FormClosingEventArgs e)
        //{
        //    MessageBox.Show("Hasta Pronto!!!!!!!!!!!!");
        //}
    }
}
