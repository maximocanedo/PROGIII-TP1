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
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            lblMuestra.Text = "";
            lblMuestra.Text = "Usted seleccionó los siguientes elementos:";
            if (rbFemenino.Checked)
            {
                lblSexo.Text = "";
                lblSexo.Text = "Sexo: Femenino";
            }
            else
            {
                lblSexo.Text = "";
                lblSexo.Text = "Sexo: Masculino";
            }

            if (rbCasado.Checked)
            {
                lblEstadoCivil.Text = "";
                lblEstadoCivil.Text = "Estado Civil: Casado";
            }
            else
            {
                lblEstadoCivil.Text = "";
                lblEstadoCivil.Text = "Estado Civil: Soltero";
            }

            lblOficio.Text = "";
            lblOficio.Text = "Oficio:";

            tbListaOficios.Text = "";
            foreach (string aux in clbOficios.CheckedItems)
            {
                tbListaOficios.SelectedText = "- " + aux +  "\r\n";
            }
        }
    }
}
