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
                byte textoUsuario = Convert.ToByte(txtNombre.Text);
                lblBienvenido.Text = textoUsuario.ToString();
            }
            catch (OverflowException varCaptura)
            {
                MessageBox.Show("Error atrapado en catch :  " + varCaptura);
            }
            catch (FormatException varCaptura1)
            {
                MessageBox.Show("Error, formato incorrecto :  " + varCaptura1);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
