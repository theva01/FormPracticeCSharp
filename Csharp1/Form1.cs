using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp1
{
    public partial class Form1 : Form
    {
        List<string> listaNombres = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string nombre;
            nombre = txtNombres.Text;
            listaNombres.Add(nombre);
            listNombres.DataSource = null;
            listNombres.DataSource = listaNombres;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaNombres.Remove(txtNombres.Text);
            listNombres.DataSource = null;
            listNombres.DataSource = listaNombres;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var indice = listaNombres.IndexOf(txtNombreCambiar.Text);
            listaNombres.RemoveAt(indice);
            listaNombres.Insert(indice, txtNombres.Text.Trim());
            listNombres.DataSource = null;
            listNombres.DataSource = listaNombres;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
