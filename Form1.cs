using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico1
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            Ejercicio2 ejercicioventana = new Ejercicio2();
            ejercicioventana.ShowDialog();
        }

        private void btnPrimerEjercicio_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1ventana = new Ejercicio1();
            ejercicio1ventana.ShowDialog();

        }

        private void btnSegundoEjercicio_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2ventana = new Ejercicio2();
            ejercicio2ventana.ShowDialog();
        }

        private void btnTercerEjercicio_Click(object sender, EventArgs e)
        {
            Ejercicio3 ejercicio3ventana = new Ejercicio3();
            ejercicio3ventana.ShowDialog();
        }
    }
}
