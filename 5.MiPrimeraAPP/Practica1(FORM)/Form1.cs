using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_FORM_
{
    public partial class practica1 : Form
    {
        public practica1()
        {
            InitializeComponent();
        }

        private void practica1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void practica1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ....");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparó el evento Click", "Atención");//Atención, se pondria como nombre
            // de la ventana, es decir, después de coma "," en un MessageBox, es como se llama la caja/ventana.
            // this.BackColor = Color.White; // Cuando le damos al btnAgregar, SOLO    la Form se pone del color.

            if (txtbGuardar.Text == "")
            {
                txtbGuardar.BackColor = Color.Red;
            }
            else
            {
                txtbGuardar.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void practica1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e; // instanciamos "click" como variable

            if (click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Le dió al botón Izquierdo", "Atención");
            }
            else if (click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Le dió al botón Derecho", "Atención");
            }
            if (click.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Presionó el botón del Medio", "Atención");
            }
        }

        private void lblGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            lblGuardar.BackColor= Color.Cyan;// sombrea la entiqueta cuando el mouse esta encima,
            // pero cuando quitamos el mouse de la lbl, sigue con el mismo color.
            lblGuardar.Cursor = Cursors.Hand;// cuando el cursor está encima de la lbl, se cambia de flecha
            // a tipo mano.
        }

        private void lblGuardar_MouseLeave(object sender, EventArgs e)
        {
            lblGuardar.BackColor = System.Drawing.SystemColors.Control;// sombrea la entiqueta cuando
            // el mouse esta encima, pero cuando quitamos el mouse de la lbl, vuelve a su color.
            lblGuardar.Cursor = Cursors.Arrow; // cuando el cursor se sale de la lbl, se cambia de tipo mano,
            // y vuelve a tipo flecha.
        }

        private void txtbGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar !=8)
                e.Handled = true;
        }

        private void txtbGuardarMulti_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtbGuardarMulti.Text.Length + "Caracteres");
        }
    }
}
