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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMuestra.Text = "";
            lblMuestra.Text = "Usted seleccionó los siguientes elementos:";
            if (rbFemenino.Checked)
            {
                lblSexo.Text = "";
                lblSexo.Text = "Sexo: Femenino";
            }
            else
            {
                lblSexo.Text = "";
                lblSexo.Text = "Sexo: Masculino";
            }

            if (rbCasado.Checked)
            {
                lblEstadoCivil.Text = "";
                lblEstadoCivil.Text = "Estado Civil: Casado";
            }
            else
            {
                lblEstadoCivil.Text = "";
                lblEstadoCivil.Text = "Estado Civil: Soltero";
            }

            // REVISAR ESTO
            // Para mí hay que contar la cantidad de ítems, y a partir de eso verificar 
            // los items que tienen check. 
            // Y luego escribir para que figuren por pantalla.
            lblOficio.Text = "";
            lblOficio.Text = "Oficio:";
            /*for (int I = 1; I <= clbOficios.Items.Count; I++)
            {
                if (clbOficios.GetItemChecked(I))
                {
                    // no sé cómo hacer para mostrar por pantalla el nombre o el texto del item seleccionado.
                }
            }*/
            // HASTA ACÁ.
        }
    }
}
