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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2(FormPrincipal formPrincipal)
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxFullName_Enter(object sender, EventArgs e)
        {

        }

        private void Ejercicio2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void btnAgregarEj2_Click(object sender, EventArgs e)
        {
            // Validacion de campos vacios
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textSurname.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textSurname.Focus();
                return;
            }

            // Validar que el nombre y apellido ingresado no existan en la lista y validar tambien que no se repita el nombre y apellido corroborando mayusculas y minusculas
            bool exists = false;
            foreach (string item in listBoxEj2.Items)
            {
                //Recorre la lista y verifica los datos ingresados (concatenados) con los datos de la lista
                if (item == textName.Text + " " + textSurname.Text || item == textName.Text.ToLower() + " " + textSurname.Text.ToLower() || item == textName.Text.ToUpper() + " " + textSurname.Text.ToUpper())
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                MessageBox.Show("El nombre y apellido ingresado ya existe en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxEj2.Items.Add(textName.Text + " " + textSurname.Text);
            OrdenarListBoxAlfabeticamente();
            textName.Clear();
            textSurname.Clear();
        }

        private void OrdenarListBoxAlfabeticamente()
        {
            List<string> Items = new List<string>();

            foreach (string Item in listBoxEj2.Items)
            {
                Items.Add(Item);
            }

            Items.Sort();

            listBoxEj2.Items.Clear();

            foreach (string Item in Items)
            {
                listBoxEj2.Items.Add(Item);
            }
        }

        private void listBoxEj2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (listBoxEj2.SelectedItem != null)
            {
                string elementoEliminado = listBoxEj2.SelectedItem.ToString();
                listBoxEj2.Items.Remove(listBoxEj2.SelectedItem);
                MessageBox.Show("El elemento " + elementoEliminado + " fue eliminado");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento para eliminar.");
            }
        }
    }
}
