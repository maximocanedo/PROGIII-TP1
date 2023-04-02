﻿using System;
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
        private bool estaVacio(string str) 
        { return str.Trim() != ""; }

        private string normalizarString(string str)
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
        private bool existeEnLaLista(string nombre, string apellido)
        {
            string nombreNormalizado = normalizarString(nombre);
            string apellidoNormalizado = normalizarString(apellido);
            string aux = nombreNormalizado + apellidoNormalizado;
            foreach (string nombreList1 in this.lbNombres.Items)
            {
                if (normalizarString(nombreList1) == aux)
                {
                    return true;
                }
            }         
            return false;
        }
        /*private bool existeEnLaLista(string nombre, string apellido)
        {
            bool existe = false;
            for (int i = 0; i < lbNombres.Items.Count; i++)
            {
                string aux = lbNombres.Items[i].ToString();
                string n = nombre.Trim().ToUpper() + " " + apellido.Trim().ToUpper();
                string x = aux.Trim().ToUpper();
                // MessageBox.Show("n=" + n + "\r\nx=" + x);
                // No me fue posible hacer .Trim() a 'aux'. Me sale siempre con el espacio en medio, así que por eso le agregué un espacio entre 'nombre' y 'apellido' para poder comparar.
                if (x.Trim().ToUpper() == n)
                {
                    existe = true;
                }
            }
            return existe;
        }*/
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool nombreOK = estaVacio(tbNombre.Text);
            bool apellidoOK = estaVacio(tbApellido.Text);
            

            if(!nombreOK || !apellidoOK)
            {
                MessageBox.Show("¡El nombre y/o el apellido están en blanco!", "Atención");
            }
            else
            {
                // Nos fijamos que el nombre y apellidos no existan en la lista.
                if(existeEnLaLista(this.tbNombre.Text, this.tbApellido.Text))
                {
                    MessageBox.Show("El nombre y apellido ya existen en la lista.");
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
            if (lbNombres.SelectedItems.Count != 0)
            {
                lbNombres.Items.Remove(lbNombres.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nombre.");
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e) {

        }
    }
}
