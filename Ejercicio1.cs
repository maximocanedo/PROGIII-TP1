using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PROBANDO GITHUB .. 

namespace TrabajoPractico1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private int getIndexOfLB1(string nombre)
        {
            // Esta funcion recibe un string y lo busca en en LB1. De existir devuelve el Index, si no un -1.
            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                string item = this.listBox1.Items[i].ToString();
                // Comparar
                if (item.Trim().ToUpper() == nombre.Trim().ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
        private int getIndexOfLB2(string nombre)
        {
            // Esta funcion recibe un string y lo busca en en LB2. De existir devuelve el Index, si no un -1.
            for (int i = 0; i < this.listBox2.Items.Count; i++)
            {
                string item = this.listBox2.Items[i].ToString();
                // Comparar
                if (item.Trim().ToUpper() == nombre.Trim().ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }
        private bool verificarNombre(string nombre)
        {
            // Verificamos que no esté en blanco
            if(nombre.Trim() != "")
            {
                // No está en blanco. Ahora tenemos que verificar que no exista en el lb1
                if(getIndexOfLB1(nombre) == -1 && getIndexOfLB2(nombre) == -1)
                {
                    // No hay registro igual en la lista y no está en blanco. Es nombre aceptable.
                    return true;
                }
                else
                { // No está en blanco, pero hay un ítem en la lista idéntico.
                    MessageBox.Show("El nombre ingresado ya existe. Intente con otro. ", "Error");
                    return false;
                }
            } else
            { // El nombre está en blanco. 
                MessageBox.Show("Debe ingresar un nombre antes de continuar. ", "Advertencia");
                return false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreDadoPorElUsuario = this.tbNombre.Text;
            bool esAceptable = verificarNombre(nombreDadoPorElUsuario);
            if(esAceptable)
            {
                listBox1.Items.Add(nombreDadoPorElUsuario);
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            // Verificamos primero que el usuario haya seleccionado un ítem del lb1.
            int selectedIndex = listBox1.SelectedIndex;
            if(selectedIndex != -1)
            {
                // El usuario sí seleccionó un ítem. Procedemos a moverlo.
                string selectedItemContent = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(selectedItemContent);
                listBox1.Items.RemoveAt(selectedIndex);
            } else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista.", "Error");
            }
        }

        private void btnMoverTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i].ToString());
            }
            listBox1.Items.Clear();
        }
    }
}
