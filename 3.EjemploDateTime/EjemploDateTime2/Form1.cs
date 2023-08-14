using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploDateTime2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            fecha1 = dtpFecha.Value;//fecha concreta

            MessageBox.Show("La fecha seleccionada es: " + dtpFecha.Value.ToString("dd/MM/yyyy"));
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            DateTime fecha2;
            fecha2 = calFecha.SelectionStart;//fecha en un calendario

            MessageBox.Show("La fecha seleccionada es: " + calFecha.SelectionStart.ToString("dd/MM/yyyy"));

        }
    }
}
