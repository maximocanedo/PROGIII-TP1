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

        private void button1_Click(object sender, EventArgs e) {
            if (tbNombre.Text.Trim() == "") {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else {
                bool seRepite = false;
                foreach (string nombreList1 in lbNombres1.Items) {
                    if (normalizarString(nombreList1) == normalizarString(tbNombre.Text)) {
                        seRepite = true;
                    }
                }
                foreach (string nombreList2 in lbNombres2.Items) {
                    if (normalizarString(nombreList2) == normalizarString(tbNombre.Text)) {
                        seRepite = true;
                    }
                }
                if (seRepite == false) {
                    lbNombres1.Items.Add(tbNombre.Text.Trim());
                    tbNombre.Text = "";
                }
                else {
                    MessageBox.Show("Nombre repetido.", "Error");
                }
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

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {



        }
    }
}
