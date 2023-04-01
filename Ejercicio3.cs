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
    public partial class Ejercicio3 : Form
    {
        private int sexo = 1; // 0 => Masculino, 1 => Femenino
        private int estadoCivil = 1; // 0 => Casado/a, 1 => Soltero/a

        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void rbFemaleSex_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 1;
            rbMarried.Text = "Casada";
            rbSingle.Text = "Soltera";
        } 

        private void rbMaleSex_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 0;
            rbMarried.Text = "Casado";
            rbSingle.Text = "Soltero";
        }

        private void rbMarried_CheckedChanged(object sender, EventArgs e)
        {
            estadoCivil = 0;
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            estadoCivil = 1;
        }

        private void btnMostrarSeleccion_Click(object sender, EventArgs e)
        {
            tbResultado.Clear();
            tbResultado.Text += "Usted ha seleccionado los siguientes elementos: \r\n";
            tbResultado.Text += "Sexo: " + (sexo == 1 ? "Femenino" : "Masculino") + "\r\n";
            tbResultado.Text += "Estado Civil: " + (
                    sexo == 1 ? (estadoCivil == 1 ? "Soltera" : "Casada") :
                    (estadoCivil == 1 ? "Soltero" : "Casado")
                ) + "\r\n";
            tbResultado.Text += "Oficio/s: \r\n";
            foreach(var item in checkedListBox1.CheckedItems)
            {
                tbResultado.Text += "  · " + item.ToString() + "\r\n";
            }
            if(checkedListBox1.CheckedItems.Count == 0)
            {
                tbResultado.Text += "  (No se seleccionó ningún oficio)";
            }
        }

    }
}
