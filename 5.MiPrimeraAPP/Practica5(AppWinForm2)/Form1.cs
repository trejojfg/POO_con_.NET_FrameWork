using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Practica5_AppWinForm2_
{
    public partial class Practica5 : Form
    {
        public Practica5()
        {
            InitializeComponent();
        }

        Persona p1 = new Persona();
        bool bApellido, bNombre, bEdad, bDireccion = false;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                p1.Apellido = txtApellido.Text;
                bApellido = true;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor= Color.Red;
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
                p1.Nombre= txtNombre.Text;
                bNombre = true;
            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor= Color.Red;
            }
            else
            {
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
                p1.Edad = txtEdad.Text;
                bEdad = true;
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor= Color.Red;
            }
            else
            {
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
                p1.Direccion = txtDireccion.Text;
                bDireccion = true;
            }

            if (bApellido == true && bNombre == true && bEdad == true && bDireccion == true)
            {
                string ResultadoEdad = "Edad: " + p1.Edad;
                string ResultadoDireccion = "Dirección: " + p1.Direccion;
                txtResultado.Text = "Apellido y Nombre: " + p1.Apellido + " " + p1.Nombre + Environment.NewLine + ResultadoEdad + Environment.NewLine + ResultadoDireccion;
            }
            else
                MessageBox.Show("Por favor, rellene correctamente los campos");

        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAceptar.Cursor= Cursors.Hand;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.Cursor = Cursors.Hand;
        }

        private void Practica5_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por utilizar la APP", "Atención");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 2)
                e.Handled = true;
        }



    }
}
