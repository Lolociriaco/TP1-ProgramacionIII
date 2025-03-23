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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1(FormPrincipal formPrincipal)
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtEjercicio1.Text.Trim().ToUpper();

            if (nuevoNombre.Length > 0)
            {
                foreach (string item in listBox1.Items) 
                {
                    if (item.ToUpper() == nuevoNombre)
                    {
                        MessageBox.Show("El nombre ya ha sido ingresado, intenta con otro.");
                        return;
                    }
                }

                listBox1.Items.Add(txtEjercicio1.Text.Trim());
                txtEjercicio1.Text = "";
            }
            else
            {
                MessageBox.Show("Ingresa un nombre rey, No dejes el espacio vacío");
            }
        }

    }
}
