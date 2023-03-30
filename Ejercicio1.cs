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

        private void button1_Click(object sender, EventArgs e)
        {
            //string name = tbNombre.Text;
            //tbNombre.Text = "";
            bool seRepite = false;
            foreach (string nombreList in lbNombres1.Items)
            {
                //if (nombreList.Trim().ToUpper() == name.Trim().ToUpper())
                if (nombreList.Trim().ToUpper() == tbNombre.Text.Trim().ToUpper())
                {
                    seRepite = true;
                }
            }
            if (tbNombre.Text.Trim() != "" && seRepite == false)
            {
                lbNombres1.Items.Add(tbNombre.Text.Trim());
                tbNombre.Text = "";
            }
            else
            {
                if (seRepite == false)
                {
                    MessageBox.Show("Debe ingresar un nombre");
                    
                }
                else
                {
                    MessageBox.Show("Nombre repetido", "error");
                    
                }
                tbNombre.Text = "";
            }  
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (lbNombres1.SelectedIndex >= 0)
            {
                lbNombres2.Items.Add(lbNombres1.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay ningun nombre seleccionado");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (lbNombres1.Items.Count != 0)
            {
                lbNombres2.Items.Clear();

                foreach (string item in lbNombres1.Items)
                {

                    lbNombres2.Items.Add(item);

                }
                lbNombres1.Items.Clear();
            }
            else
            {
                MessageBox.Show("La lista izquierda se encuentra vacia");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
