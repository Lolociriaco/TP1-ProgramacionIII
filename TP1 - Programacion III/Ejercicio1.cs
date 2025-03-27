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
                        MessageBox.Show("El nombre ya ha sido ingresado, intenta con otro.",
                                      "Nombre duplicado",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Warning);
                        return;
                    }
                }

                listBox1.Items.Add(txtEjercicio1.Text.Trim());
                txtEjercicio1.Text = "";
            }
            else
            {
                MessageBox.Show("Ingresa un nombre, no dejes el espacio vacío",
                              "Campo vacío",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación de item seleccionado
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un nombre de la lista izquierda primero.",
                              "Selección requerida",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            string seleccion = listBox1.SelectedItem.ToString();

            // Validación de duplicdos
            if (listBox2.Items.Cast<string>().Any(item =>
                item.Equals(seleccion, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"El nombre '{seleccion}' ya existe en la lista derecha.",
                              "Nombre duplicado",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            // Transferir elemento
            listBox2.Items.Add(seleccion);
            listBox1.Items.Remove(seleccion);
        }

        private void BtnPasarTodos_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No hay nombres en la lista izquierda para mover.",
                              "Lista vacía",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return;
            }

            TransferirElementos(listBox1, listBox2);
        }

        private void TransferirElementos(ListBox origen, ListBox destino)
        {
            int transferidos = 0;
            int duplicados = 0;

            for (int i = origen.Items.Count - 1; i >= 0; i--)
            {
                string nombre = origen.Items[i].ToString();
                bool existe = destino.Items.Cast<string>()
                    .Any(n => n.Equals(nombre, StringComparison.OrdinalIgnoreCase));

                if (!existe)
                {
                    destino.Items.Add(nombre);
                    origen.Items.RemoveAt(i);
                    transferidos++;
                }
                else
                {
                    duplicados++;
                }
            }

            string mensaje = $"Se transfirieron {transferidos} elementos.";
            if (duplicados > 0)
            {
                mensaje += $"\n{duplicados} elementos no se transfirieron por ser duplicados.";
            }

            MessageBox.Show(mensaje, "Resultado de transferencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Ejercicio1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
