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
        
        /// <summary>
        /// Busca en @lbNombres1 y @lbNombres2 si hay algún ítem repetido. 
        /// </summary>
        /// <param name="nombre">El string dado, del cual se quiere saber si está repetido en las listas.</param>
        /// <returns>True, si hay un ítem ídentico al string dado. False, si no lo hay.</returns>
        private bool NombreEstaRepetido(string nombre) {
            string nombreNormalizado = Funciones.NormalizarString(nombre);
            foreach (string nombreList1 in this.lbNombres1.Items) {
                if (Funciones.NormalizarString(nombreList1) == nombreNormalizado) {
                    return true;
                }
            }
            foreach (string nombreList2 in this.lbNombres2.Items) {
                if (Funciones.NormalizarString(nombreList2) == nombreNormalizado) {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Examina el nombre dado por el usuario y si no está en blanco, no está repetido en ninguna de las listas, lo agrega a la @lbNombres1
        /// </summary>
        private void AgregarItem() {
            string nombreSinEspacios = tbNombre.Text.Trim();
            if (nombreSinEspacios == "") {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (NombreEstaRepetido(nombreSinEspacios)) {
                MessageBox.Show("Nombre repetido.", "Error");
            }
            else {
                lbNombres1.Items.Add(nombreSinEspacios);
                tbNombre.Text = "";
            }
        }
        /// <summary>
        /// De haber un ítem seleccionado por el usuario en la @lbNombres1, lo mueve a la @lbNombres2.
        /// </summary>
        private void MoverItemDeLista1ALista2() {
            if (lbNombres1.SelectedIndex >= 0) {
                lbNombres2.Items.Add(lbNombres1.SelectedItem);
                lbNombres1.Items.RemoveAt(lbNombres1.SelectedIndex);
            }
            else {
                MessageBox.Show("No hay ningun nombre seleccionado.");
            }
        }
        /// <summary>
        /// Mueve todos los ítems de la @lbNombres1 a la @lbNombres2.
        /// </summary>
        private void MoverTodosLosNombresDeLista1aLista2() {
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
        private void button1_Click(object sender, EventArgs e) {
            AgregarItem();
        }
        private void button2_Click_1(object sender, EventArgs e) {
            MoverItemDeLista1ALista2();
        }
        private void button3_Click_1(object sender, EventArgs e) {
            MoverTodosLosNombresDeLista1aLista2();
        }
    }
}
