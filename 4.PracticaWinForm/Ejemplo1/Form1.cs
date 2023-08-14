using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;

            //Operador Ternario = combierte a un checkBox de True/False en TEXTO
            string chocolate = ckbChocolate.Checked == true ? "Le gusta Choco" : "Odia el Choco....";

            string tipo;
            if (rbtWizard.Checked == true)
                tipo = "Wizard";
            else if (rbtMuggle.Checked == true)
                tipo = "Muggle";
            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es: " + colorFavorito + " y su numero es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + ", Fecha: " + fecha + ", " + mensaje); 

        }
    }
}
