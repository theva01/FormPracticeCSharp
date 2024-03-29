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

                switch (user) 
                { 
                    case "Eduardo":
                        MessageBox.Show("Ingreso Correctamente Eduardo");
                        switch (password)
                        {
                            case "123":
                                MessageBox.Show("Correctamente la contraseña");
                                break;
                            default:
                                MessageBox.Show("la contraseña es InCorrecta ");
                                break;
                        }
                        break;
                    case "Anderson":
                        MessageBox.Show("Ingreso Correctamente Anderson");
                        break;
                    default:
                        MessageBox.Show("Accion Invalida, intente nuevamente");
                        break;
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
