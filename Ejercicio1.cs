using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//PROBANDO GITHUB .. 

namespace TrabajoPractico1 {
    public partial class Ejercicio1 : Form {
        public Ejercicio1() {
            InitializeComponent();
        }
        private string normalizarString(string str) {
            string paso1 = new string(str
                .Normalize(NormalizationForm.FormD)
                .Where(c => char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                .ToArray()); // Quita acentos.
            string paso2 = paso1.ToUpper(); // Pasar todo a mayúsculas
            string paso3 = paso2.Trim(); // Cortar espacios
            string paso4 = paso3.Replace(" ", ""); // Cortar espacios, definitivamente
            return paso4;
        }
        private bool NombreEstaRepetido(string nombre) {
            string nombreNormalizado = normalizarString(nombre);
            foreach (string nombreList1 in this.lbNombres1.Items) {
                if (normalizarString(nombreList1) == nombreNormalizado) {
                    return true;
                }
            }
            foreach (string nombreList2 in this.lbNombres2.Items) {
                if (normalizarString(nombreList2) == nombreNormalizado) {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (tbNombre.Text.Trim() == "") {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (NombreEstaRepetido(tbNombre.Text.Trim())) {
                MessageBox.Show("Nombre repetido.", "Error");
            }
            else {
                lbNombres1.Items.Add(tbNombre.Text.Trim());
                tbNombre.Text = "";
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {
            if (lbNombres1.SelectedIndex >= 0) {
                lbNombres2.Items.Add(lbNombres1.SelectedItem);
                lbNombres1.Items.RemoveAt(lbNombres1.SelectedIndex);
            }
            else {
                MessageBox.Show("No hay ningun nombre seleccionado.");
            }
        }

        // Esta función mueve todos los elementos de @lbNombres1 a @lbNombres2.
        private void button3_Click_1(object sender, EventArgs e) {
            if (lbNombres1.Items.Count != 0) {
                foreach (string item in lbNombres1.Items) {
                    lbNombres2.Items.Add(item);
                }
                lbNombres1.Items.Clear();
            }
            else {
                MessageBox.Show("La lista izquierda se encuentra vacía.");
            }
        }

        private void lbNombres2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
