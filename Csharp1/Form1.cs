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

            string user = txtUser.Text, password = txtPassword.Text;
            try
            {

                if (user != "Anderson" || Convert.ToInt32(password)+32 == 800)
                {
                    MessageBox.Show("Accediste correctamente");

                }
                else
                {
                    MessageBox.Show("Datos incorrectos, intenta de nuevo");
                }

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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
