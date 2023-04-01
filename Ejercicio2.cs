using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//test
namespace TrabajoPractico1
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
            /*// Para probar el programa
            this.lbNombres.Items.Add("Máximo Canedo");
            this.lbNombres.Items.Add("Luis García");
            this.lbNombres.Items.Add("Carmen Itulaín");
            //*/
        }
        private bool verificarNombre()
        {
            return (this.tbNombre.Text.Trim() != "");
        }
        private bool verificarApellido()
        {
            return (this.tbApellido.Text.Trim() != "");
        }
        private string prepararStringParaComparar(string str)
        {
            string paso1 = new string(str
                .Normalize(NormalizationForm.FormD)
                .Where(c => char.GetUnicodeCategory(c) != System.Globalization.UnicodeCategory.NonSpacingMark)
                .ToArray()); // Quita acentos.
            string paso2 = paso1.ToUpper(); // Pasar todo a mayúsculas
            string paso3 = paso2.Trim(); // Cortar espacios
            string paso4 = paso3.Replace(" ", ""); // Cortar espacios, definitivamente
            return paso4;
        }
        private bool compararItems(string item1, string item2)
        {
            string a = prepararStringParaComparar(item1);
            string b = prepararStringParaComparar(item2);
            /* MessageBox.Show(
                "Comparando: \r\n"+a+"\r\n"+b
                ); // */
            return a == b; 
        }
        private void limpiarCampos(bool focusAfter = false)
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            if(focusAfter)
            {
                tbNombre.Focus();
            }
        }

        private bool existeEnLaLista(string nombre, string apellido)
        {
            bool existe = false;
            for (int i = 0; i < lbNombres.Items.Count; i++)
            {
                string original = lbNombres.Items[i].ToString();
                string item = (string)original.Clone();
                string completeName = nombre + " " + apellido;
                if(compararItems(item, completeName))
                {
                    existe = true;
                }
            }
            return existe;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool nombreOK = verificarNombre();
            bool apellidoOK = verificarApellido();
            

            if(!nombreOK || !apellidoOK)
            {
                MessageBox.Show("¡El nombre y/o el apellido están en blanco!", "Atención");
                limpiarCampos(true);
            }
            else
            {
                // Nos fijamos que el nombre y apellidos no existan en la lista.
                if(existeEnLaLista(this.tbNombre.Text, this.tbApellido.Text))
                {
                    MessageBox.Show("El nombre y apellido ya existen en la lista.");
                    limpiarCampos(true);
                } else
                {
                    // No existen el nombre y apellido, así que procedemos a agregarlos a la lista.
                    lbNombres.Items.Add(this.tbNombre.Text.Trim() + " " + this.tbApellido.Text.Trim());
                }
            }
            tbNombre.Text = "";
            tbApellido.Text = "";
        }

        private void lbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            bool elUsuarioSeleccionoAlgo = lbNombres.SelectedIndex != -1;
            if(!elUsuarioSeleccionoAlgo)
            {
                MessageBox.Show("Seleccione primero el elemento que desea eliminar. ");
            } else
            {
                lbNombres.Items.RemoveAt(lbNombres.SelectedIndex);
            }
        }
    }
}
