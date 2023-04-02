using System;
using System.Windows.Forms;

namespace TrabajoPractico1 {
    public partial class Ejercicio3 : Form {
        public Ejercicio3() {
            InitializeComponent();
        }
        private void btnMostrar_Click(object sender, EventArgs e) {
            lblMuestra.Text = "";
            lblMuestra.Text = "Usted seleccionó los siguientes elementos:";
            string sexo = rbFemenino.Checked ? "Femenino" : "Masculino";
            string estadoCivil = rbCasado.Checked ? "Casado" : "Soltero";
            lblSexo.Text = "Sexo: " + sexo;
            lblEstadoCivil.Text = "Estado Civil: " + estadoCivil;
            lblOficio.Text = "Oficio:";
            tbListaOficios.Text = "";
            foreach (string aux in clbOficios.CheckedItems) {
                tbListaOficios.SelectedText = "- " + aux + "\r\n";
            }
        }
    }
}
