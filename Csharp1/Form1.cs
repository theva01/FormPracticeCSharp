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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string bienvenida = " bienvenido al curso de CSharp";
                string textoUsuario = "holas " + txtNombre.Text + bienvenida;
                lblBienvenido.Text = textoUsuario;

            }
            catch (Exception varCaptura)
            {
                MessageBox.Show("Error atrapado en catch :  " + varCaptura);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
