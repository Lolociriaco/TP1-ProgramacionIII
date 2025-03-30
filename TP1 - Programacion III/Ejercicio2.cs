using System;
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
        public Ejercicio2( FormPrincipal formPrincipal )
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
            FormPrincipal formPrincipal = new FormPrincipal(); // Crea una instancia del formulario principal
            formPrincipal.Show(); // Muestra el formulario principal
        }

        private void btnAgregarEj2_Click(object sender, EventArgs e)
        {
            

            listBoxEj2.Items.Add(textName.Text + " " + textSurname.Text);
            OrdenarListBoxAlfabeticamente();
            textName.Clear();
            textSurname.Clear();
        }

        private void OrdenarListBoxAlfabeticamente()
        {
            List<String> Items = new List<string>();

            foreach(String Item in listBoxEj2.Items)
            {
                Items.Add(Item);

            }

            //ordenar la Lista alfabeticamente
            Items.Sort();

            listBoxEj2.Items.Clear();

            foreach (String Item in Items)
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
