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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a la nueva APP!!!!!!!!!!!");
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("GRACIAS y Hasta Pronto!!!!!!!!!");
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)//Application es una coleccion, por eso
            // usamos el foreach.
            {
                if (item.GetType() == typeof(practica1))
                // GetType es para sabe el Tipo de Objeto que se cuenta.
                // typeof es para decir, que Tipo de Objeto es el que se busca.
                {
                    MessageBox.Show("Ya existe esta ventana abierta...");
                    return;
                }
            }
            practica1 ventana = new practica1();
            ventana.MdiParent= this;
            //ventana.ShowDialog(); se quita porque se rompe utilizando el MdiParent, ya
            //que la ventana no puede estar anclada y ser el foco a la vez siendo ventana hija.
            ventana.Show();
        }

        private void toolStripBtnPersona_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms) //Application es una coleccion, por eso
                // usamos el foreach.
            {
                if (item.GetType() == typeof(practica1))
                // GetType es para sabe el Tipo de Objeto que se cuenta.
                // typeof es para decir, que Tipo de Objeto es el que se busca.
                {
                    MessageBox.Show("Ya existe esta ventana abierta...");
                    return;
                }
            }
            practica1 ventana = new practica1();
            ventana.MdiParent= this;
            //ventana.ShowDialog(); se quita porque se rompe utilizando el MdiParent, ya
            //que la ventana no puede estar anclada y ser el foco a la vez siendo ventana hija.
            ventana.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
