using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TrabajoPractico1 {
    public partial class Ejercicio2 : Form {
        public Ejercicio2() {
            InitializeComponent();
            /*// Para probar el programa
            this.lbNombres.Items.Add("Máximo Canedo");
            this.lbNombres.Items.Add("Luis García");
            this.lbNombres.Items.Add("Carmen Itulaín");
            //*/
        }
        private bool estaVacio(string str) { return str.Trim() != ""; }

        private string normalizarString(string str) {
            string paso1 = new string(str
                .Normalize(NormalizationForm.FormD)
                .Where(c => char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                .ToArray()); // Quita acentos.
            string paso2 = paso1.ToUpper(); // Pasar todo a mayúsculas
            string paso3 = paso2.Trim(); // Cortar espacios
            string paso4 = paso3.Replace(" ", ""); // Cortar espacios, definitivamente
            return paso4;
        } // Optimizado
        private bool existeEnLaLista(string nombre, string apellido) {
            string nombreNormalizado = normalizarString(nombre);
            string apellidoNormalizado = normalizarString(apellido);
            string aux = nombreNormalizado + apellidoNormalizado;
            foreach (string nombreList1 in this.lbNombres.Items) {
                if (normalizarString(nombreList1) == aux) {
                    return true;
                }
            }
            return false;
        } // Optimizado
        private void btnAgregar_Click(object sender, EventArgs e) {
            bool nombreOK = estaVacio(tbNombre.Text);
            bool apellidoOK = estaVacio(tbApellido.Text);
            if (!nombreOK || !apellidoOK) {
                MessageBox.Show("¡El nombre y/o el apellido están en blanco!", "Atención");
                return;
            }
            if (existeEnLaLista(this.tbNombre.Text, this.tbApellido.Text)) {
                MessageBox.Show("El nombre y apellido ya existen en la lista.");
                return;
            }
            lbNombres.Items.Add(this.tbNombre.Text.Trim() + " " + this.tbApellido.Text.Trim());
            tbNombre.Text = "";
            tbApellido.Text = "";
        } // Optimizado

        private void lbNombres_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            if (lbNombres.SelectedItems.Count != 0) {
                lbNombres.Items.Remove(lbNombres.SelectedItem);
            }
            else {
                MessageBox.Show("Debe seleccionar un nombre.");
            }
        } // Optimizado

        private void tbNombre_TextChanged(object sender, EventArgs e) {

        }
    }
}
