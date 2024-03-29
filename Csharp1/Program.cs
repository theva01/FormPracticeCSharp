using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            #region Primer turotial Csharp en consola
            string Nombre = "Anderson";
            string Cambio = "Feature";
            // int num1 = 450444;
            // uint num2 = 500; //uint nunca valor negativo
            // float num3 = 99.3f;// f indica numero flotante (mas precision decimal)
            // double num4 = 22.43;// nuemro decimal mas grande que float
            // decimal num5 = 7983456.974323m;//m indica decimal (calculos gigantes)
            // byte num6 = 255;//maximo 255

            //quitando texto como ejemplo de arregloRapido hotfix

            // const string dato = "Hola puebas constante";
            // //dato = "cambio constante";
            // MessageBox.Show(dato);
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
