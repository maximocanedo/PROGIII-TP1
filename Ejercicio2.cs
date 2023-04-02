using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TrabajoPractico1 {
    public partial class Ejercicio2 : Form {
        public Ejercicio2() {
            InitializeComponent();
        }
        /// <summary>
        /// Comprueba si un nombre y apellido normalizados existen en la lista.
        /// </summary>
        /// <param name="nombre">El nombre a comprobar.</param>
        /// <param name="apellido">El apellido a comprobar.</param>
        /// <returns>True si el nombre y apellido normalizados ya existen en la lista; False en caso contrario.</returns>
        private bool existeEnLaLista(string nombre, string apellido) {
            string nombreNormalizado = Funciones.NormalizarString(nombre);
            string apellidoNormalizado = Funciones.NormalizarString(apellido);
            string aux = nombreNormalizado + apellidoNormalizado;
            foreach (string nombreList1 in this.lbNombres.Items) {
                if (Funciones.NormalizarString(nombreList1) == aux) {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Agrega un nuevo elemento a la lista de nombres si se cumplen ciertas condiciones.
        /// </summary>
        private void AgregarItem() {
            bool nombreOK = Funciones.EstaVacio(tbNombre.Text);
            bool apellidoOK = Funciones.EstaVacio(tbApellido.Text);
            if (!nombreOK || !apellidoOK) {
                MessageBox.Show("¡El nombre y/o el apellido están en blanco!", "Atención");
                return;
            }
            if (existeEnLaLista(this.tbNombre.Text, this.tbApellido.Text)) {
                MessageBox.Show("El nombre y apellido ya existen en la lista.");
                return;
            }
            string nombreAAgregar = Funciones.EliminarEspacios(this.tbNombre.Text);
            string apellidoAAgregar = Funciones.EliminarEspacios(this.tbApellido.Text);
            lbNombres.Items.Add(nombreAAgregar + " " + apellidoAAgregar);
            tbNombre.Text = "";
            tbApellido.Text = "";
        }
        /// <summary>
        /// Borra el elemento seleccionado en la lista @lbNombres.
        /// </summary>
        private void BorrarItem() {
            if (lbNombres.SelectedItems.Count != 0) {
                lbNombres.Items.Remove(lbNombres.SelectedItem);
            }
            else {
                MessageBox.Show("Debe seleccionar un nombre.");
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e) {
            AgregarItem();
        }
        private void btnBorrar_Click(object sender, EventArgs e) {
            BorrarItem();
        }
    }
}
