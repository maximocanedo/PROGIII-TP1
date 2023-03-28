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
            string name = textBox1.Text;
            textBox1.Text = "";
            bool seRepite = false;
            foreach (string nombreList in listBox1.Items)
            {
                if (nombreList.Trim().ToUpper() == name.Trim().ToUpper())
                {
                    seRepite = true;
                }
            }
            if (seRepite == false)
            {
                listBox1.Items.Add(name);
            }
            else
            {
                MessageBox.Show("Nombre repetido", "error");
            }
        }


     

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay ningun nombre seleccionado");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                foreach (int item in listBox1.SelectedIndices)
                {
                    listBox2.Items.Add(listBox1.Items[item]);
                    listBox1.Items.RemoveAt(item);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun nombre seleccionado");
            }
        }
    }
}
