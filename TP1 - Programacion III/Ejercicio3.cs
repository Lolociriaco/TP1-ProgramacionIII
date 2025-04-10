﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1___Programacion_III
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3( FormPrincipal formPrincipal )
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxsexo_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxsoltero_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxEstCivil_Enter(object sender, EventArgs e)
        {

        }

        private bool oficiosMostrados = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (oficiosMostrados)
            {
                MessageBox.Show("Ya has mostrado los oficios.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            String sexo = femenino.Checked ? "Femenino" : "Masculino";
            String estadoCivil = casado.Checked ? "Casado" : "Soltero";
            String roles = "";

            

            if (checkedRoles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos un oficio.",
                                "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            else 
            {
                foreach (object item in checkedRoles.CheckedItems)
                {
                    roles += "   " + item.ToString() + "\n";
                }

                mostrarSexo.Text = "Sexo: " + sexo;
                mostrarEstadoCivil.Text = "Estado Civil: " + estadoCivil;

                mostrarRoles.Text += "\nOficio:";
                foreach (object item in checkedRoles.CheckedItems)
                {
                    mostrarRoles.Text += "\n" + "  -" + item.ToString();
                }
            }
           

            oficiosMostrados = true;
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }
    }
}
